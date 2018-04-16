
namespace HtmlParser.Core
{
   public interface IParserSettings
   {
      string BaseUrl { get; set; }
      string Tag { get; set; }
      string Prefix { get; set; }
      int StartPoint { get; set; }
      int EndPoint { get; set; }
   }
}
