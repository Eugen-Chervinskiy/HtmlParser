
namespace HtmlParser.Core
{
   using HtmlAgilityPack;

   //using HtmlAgilityPack;
   using System.Collections.Generic;

   public interface ICrawler<T> where T : class
   {
      IEnumerable<string> ParseCategoriesAsync();
      T ParseStoreElements(HtmlDocument document, ICrawlerSettings settings);
     
   }
}
