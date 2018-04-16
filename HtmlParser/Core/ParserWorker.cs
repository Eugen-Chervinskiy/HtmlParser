
namespace HtmlParser.Core
{
   using System;

   public class ParserWorker<T> where T : class
   {
      private IParser<T> parser;

      private IParserSettings parserSettings;

      private HtmlLoader loader;

      private bool isActive;


      public event Action<object, T> OneNewData;
      public event Action<object> OneCompleted;
      public IParser<T> Parser
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


      public ParserWorker(IParser<T> parser)
      {
         this.parser = parser;

      }

      public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
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

         var source = await loader.GetSourceByPageId();

         var domParser = new AngleSharp.Parser.Html.HtmlParser();

         var document = await domParser.ParseAsync(source);

         var result = parser.Parse(document,settings);

         OneNewData?.Invoke(this, result);


         OneCompleted?.Invoke(this);
         isActive = false;
      }
   }
}
