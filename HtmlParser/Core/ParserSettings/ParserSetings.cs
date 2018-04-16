
namespace HtmlParser.Core.ParserSettings
{
   public class ParserSettings : IParserSettings
   {
      public ParserSettings(string text,string tag)
      {
         BaseUrl = text;
         Tag = tag;
      }

      public string BaseUrl { get; set; }
      public string Prefix { get; set; } = "page{CurrentId}";
      public int StartPoint { get; set; }
      public int EndPoint { get; set; }
      public string Tag { get; set; }
   }
}
