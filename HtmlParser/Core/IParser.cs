
namespace HtmlParser.Core
{
   //using AngleSharp.Dom.Html;
   using HtmlAgilityPack;

   public interface IStoreParser<T> where T : class
   {
      T ParseStoreElements(HtmlDocument document,IParserSettings settings);
      T ParseProductTitle();
      T ParseProductCategory();
      T ParseProductPrice();


   }
}
