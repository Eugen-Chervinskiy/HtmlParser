
namespace HtmlParser.Core
{
   using DataAccess;
   using HtmlAgilityPack;
   using System;

   public class ParserWorker<T> where T : class
   {
      private ICrawler<T> parser;
      private ICrawlerSettings parserSettings;
      private HtmlLoader loader;
      private CrawlerDataProvider crawlerDataProvider;
      private bool isActive;

      public event Action<object, T> OneNewData;
      public event Action<object> OneCompleted;
      public ICrawler<T> Parser
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
            loader = new HtmlLoader(value);
         }
      }

      public bool IsActive
      {
         get
         {
            return isActive;
         }
      }

      
      public ParserWorker(ICrawler<T> parser)
      {
         this.parser = parser;

      }

      public ParserWorker(ICrawler<T> parser, ICrawlerSettings parserSettings) : this(parser)
      {
         this.parserSettings = parserSettings;
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
         if (!isActive)
         {
            OneCompleted?.Invoke(this);
            return;
         }

         var domParser = new HtmlWeb();

         var document = domParser.Load(settings.CategoriesPageUrl);

         var result = Parser.ParseStoreElements(document,settings);

         OneNewData?.Invoke(this, result);
         OneCompleted?.Invoke(this);
         isActive = false;
      }
   }
}
