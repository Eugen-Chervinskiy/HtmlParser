using HtmlAgilityPack;
using HtmlParser.Core.ParserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.Scanners.Ebay
{
   public class EbayCrawler : ICrawler<List<EbayProduct>>
   {
      private int productCount;
      public IEnumerable<string> ParseCategoriesAsync()
      {
         throw new NotImplementedException();
      }

      public List<EbayProduct> ParseStoreElements(HtmlDocument document, ICrawlerSettings settings)
      {
         productCount = 0;
         var products = new List<EbayProduct>();
         var parentDivs = document
                        .DocumentNode
                        .Descendants("li")
                        .Where(_ => _.GetAttributeValue("class", "")
                        .Equals("s-item__wrapper clearfix"))
                        .ToList();

         return products;
      }
   }
}
