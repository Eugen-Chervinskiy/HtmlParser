
namespace HtmlParser.Core
{
   using HtmlAgilityPack;
   using System;

   public class ParserWorker<T> where T : class
   {
      private IStoreParser<T> parser;

      private IParserSettings parserSettings;

      private HtmlLoader loader;

      private bool isActive;


      public event Action<object, T> OneNewData;
      public event Action<object> OneCompleted;
      public IStoreParser<T> Parser
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

      public IParserSettings Settings
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


      public ParserWorker(IStoreParser<T> parser)
      {
         this.parser = parser;

      }

      public ParserWorker(IStoreParser<T> parser, IParserSettings parserSettings) : this(parser)
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


      private async void Worker(IParserSettings settings)
      {
         if (!isActive)
         {
            OneCompleted?.Invoke(this);
            return;
         }

         //var source = await loader.GetSourceByPageId();

         //var domParser = new AngleSharp.Parser.Html.HtmlParser();

         var domParser = new HtmlWeb();

         var document = domParser.Load(settings.BaseUrl);

         var result = parser.ParseStoreElements(document,settings);

         OneNewData?.Invoke(this, result);
         OneCompleted?.Invoke(this);
         isActive = false;
      }
   }
}
