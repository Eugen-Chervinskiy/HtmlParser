
namespace HtmlParser.Core
{
   //using AngleSharp.Dom.Html;
   using HtmlAgilityPack;

   public interface IStoreParser<T> where T : class
   {
      T ParseStoreElements(HtmlDocument document,IParserSettings settings);
      string ParseProductTitle();
      string ParseProductCategory();
      string ParseProductPrice();


   }
}
