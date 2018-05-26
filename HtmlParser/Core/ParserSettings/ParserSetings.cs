
namespace HtmlParser.Core.ParserSettings
{
   public class ParserSettings : ICrawlerSettings
   {
      public ParserSettings(string text,string tag)
      {
         CategoriesPageUrl = text;
         Tag = tag;
      }

      public string CategoriesPageUrl { get; set; }
      public string Prefix { get; set; } = "page{CurrentId}";
      public int StartPoint { get; set; }
      public int EndPoint { get; set; }
      public string Tag { get; set; }
   }
}
