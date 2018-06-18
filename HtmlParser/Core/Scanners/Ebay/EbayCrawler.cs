using HtmlAgilityPack;
using HtmlParser.Core.ParserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
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
         var parentNodes = document
                        .DocumentNode
                        .Descendants("li")
                        .Where(_ => _.GetAttributeValue("class", "")
                        .Contains("sresult"))
                        .ToList();

         
         foreach (var node in parentNodes)
         {

            //var parsedProduct = new EbayProduct
            //{
            //   Name = item.Descendants("h3").Where(_ => _.GetAttributeValue("class", "").Equals("lvtitle")).FirstOrDefault().InnerText,
            //   //SubTitle = item.Descendants("div").Where(_ => _.GetAttributeValue("class", "").Equals("lvsubtitle")).MyFirstOrDefault().InnerText,
            //   Category = document.DocumentNode.Descendants("span").Where(_ => _.GetAttributeValue("class", "").Equals("cptname")).FirstOrDefault().InnerText,
            //   ImageLink = item.Descendants("a").Where(_ => _.GetAttributeValue("class", "").Equals("img imgWr2")).FirstOrDefault().Descendants("img").FirstOrDefault().GetAttributeValue("src", ""),
            //   Price = item.Descendants("span").Where(_ => _.GetAttributeValue("class", "").Equals("prRange")).FirstOrDefault().InnerText ?? "empty",
            //   ProductLink = item.Descendants("h3").Where(_ => _.GetAttributeValue("class", "").Equals("lvtitle")).FirstOrDefault().Descendants("a").FirstOrDefault().GetAttributeValue("href", ""),
            //   //ProductSold = item.Descendants("div").Where(_ => _.GetAttributeValue("class", "").Equals("hotness-signal red")).FirstOrDefault().InnerText

            //};

            var parsedProduct = new EbayProduct();
            parsedProduct.Name = node.Descendants("h3").FirstOrDefault().InnerText;
            parsedProduct.Category = document.DocumentNode.Descendants("span").Where(_ => _.GetAttributeValue("class", "").Equals("cptname")).FirstOrDefault().InnerText;
            parsedProduct.ImageLink = node.Descendants("a").Where(_ => _.GetAttributeValue("class", "").Equals("img imgWr2")).FirstOrDefault().Descendants("img").FirstOrDefault().GetAttributeValue("src", "");
            parsedProduct.SubTitle = ParseProductSubtitle(node);


            products.Add(parsedProduct);
            productCount++;
         }
         return products;
      }

      private string ParseProductTitle()
      {
         return "";
      }

      private string ParseProductPrice()
      {
         return "";
      }

      private string ParseProductSubtitle(HtmlNode node)
      {
         var result = node
            .Descendants("div")
            .Where(_ => _.GetAttributeValue("class", "")
            .Equals("lvsubtitle"))
            .FirstOrDefault()?.InnerText ?? "not found";




         return result;
      }

      private string ParseProductImage()
      {
         return "";
      }

     

      public bool CanScanPage()
      {
         throw new NotImplementedException();
      }

      public Task<IEnumerable<string>> ParseCategoriesAsync(ICrawlerSettings settings)
      {
         throw new NotImplementedException();
      }
   }
}
