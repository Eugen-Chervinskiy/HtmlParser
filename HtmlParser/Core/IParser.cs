
namespace HtmlParser.Core
{
   using AngleSharp.Dom.Html;

   public interface IParser<T> where T : class
   {
      T Parse(IHtmlDocument document,IParserSettings settings);
   }
}
