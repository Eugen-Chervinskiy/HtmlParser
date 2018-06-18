
namespace HtmlParser.Core
{
   using DataAccess;
   using HtmlAgilityPack;
   using HtmlParser.Core.ParserSettings;
   using System;
   using System.Collections.Generic;


   public class CrawlingProccess<T> where T : class
   {
      private ICrawler<T> parser;
      private ICrawlerSettings parserSettings;
      private PageDownloader loader;
      private CrawlerDataProvider crawlerDataProvider;
      private bool isActive;

      public event Action<object, T> OneNewData;
      public event Action<object> OneCompleted;
      public ICrawler<T> Crawler
      {
         get
         {
            return parser;
         }

         set
         {
            parser = value;
         }
      }

      public ICrawlerSettings Settings
      {
         get
         {
            return parserSettings;
         }

         set
         {
            parserSettings = value;
            loader = new PageDownloader(value);
         }
      }

      public bool IsActive
      {
         get
         {
            return isActive;
         }
      }

      
      public CrawlingProccess(ICrawler<T> parser)
      {
         this.parser = parser;
         crawlerDataProvider = new CrawlerDataProvider();
      }

      public CrawlingProccess(ICrawler<T> parser, ICrawlerSettings parserSettings) : this(parser)
      {
         this.parserSettings = parserSettings;
         crawlerDataProvider = new CrawlerDataProvider();
         loader = new PageDownloader(parserSettings);
      }

      public void Start()
      {
         isActive = true;
         Worker(parserSettings);
      }

      public void Abort()
      {
         isActive = false;
      }


      private async void Worker(ICrawlerSettings settings)
      {
         await Crawler.ParseCategoriesAsync(settings);
         var categories = crawlerDataProvider.GetCategories(settings.FileResultPath);

         foreach (var category in categories)
         {
            if (!isActive)
            {
               OneCompleted?.Invoke(this);
               return;
            }

            var domParser = new HtmlWeb();
            var document = new HtmlDocument();
            
            var page = await loader.GetSourceByPageId(category);
            
            document.LoadHtml(page);
           
            var result = Crawler.ParseStoreElements(document, settings);
            
            OneNewData?.Invoke(this, result);
            
           
         }
         OneCompleted?.Invoke(this);
         isActive = false;
      }
   }
}
