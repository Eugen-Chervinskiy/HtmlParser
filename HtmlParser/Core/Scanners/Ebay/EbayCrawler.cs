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
                        .Equals("sresult lvresult clearfix li shic"))
                        .ToList();

         
         foreach (var item in parentDivs)
         {

            var parsedProduct = new EbayProduct
            {
               Name = item.Descendants("h3").Where(_ => _.GetAttributeValue("class", "").Equals("lvtitle")).FirstOrDefault().InnerText,
               SubTitle = item.Descendants("div").Where(_ => _.GetAttributeValue("class", "").Equals("lvsubtitle")).MyFirstOrDefault().InnerText,
               Category = document.DocumentNode.Descendants("span").Where(_ => _.GetAttributeValue("class", "").Equals("cptname")).FirstOrDefault().InnerText,
               ImageLink = item.Descendants("a").Where(_ => _.GetAttributeValue("class", "").Equals("img imgWr2")).FirstOrDefault().Descendants("img").FirstOrDefault().GetAttributeValue("src",""),
               Price = item.Descendants("span").Where(_ => _.GetAttributeValue("class", "").Equals("prRange")).FirstOrDefault().InnerText ?? "empty",
               ProductLink = item.Descendants("h3").Where(_ => _.GetAttributeValue("class", "").Equals("lvtitle")).FirstOrDefault().Descendants("a").FirstOrDefault().GetAttributeValue("href","")

            };

            products.Add(parsedProduct);
            productCount++;
         }
         return products;
      }
   }
}
