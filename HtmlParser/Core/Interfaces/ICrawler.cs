
namespace HtmlParser.Core
{
   using HtmlAgilityPack;

   //using HtmlAgilityPack;
   using System.Collections.Generic;
   using System.Threading.Tasks;

   public interface ICrawler<T> where T : class
   {
      Task<IEnumerable<string>> ParseCategoriesAsync(ICrawlerSettings settings);
      bool CanScanPage();
      T ParseStoreElements(HtmlDocument document, ICrawlerSettings settings);
     
   }
}
