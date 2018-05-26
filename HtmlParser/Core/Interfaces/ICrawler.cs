
namespace HtmlParser.Core
{

   using HtmlAgilityPack;
   using System.Collections.Generic;

   public interface ICrawler<T> where T : class
   {
      IEnumerable<string> ParseCategoriesAsync();
      T ParseStoreElements(HtmlDocument document,ICrawlerSettings settings);
      string ParseProductTitle();
      string ParseProductCategory();
      string ParseProductPrice();
   }
}
