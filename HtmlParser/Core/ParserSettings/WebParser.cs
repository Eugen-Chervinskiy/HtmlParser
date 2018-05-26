


namespace HtmlParser.Core.ParserSettings
{
   using System.Collections.Generic;
   using System.Linq;
   using HtmlAgilityPack;
   using System.Net.Http;

   public class WebParser : ICrawler<string[]>
   {
      private HtmlDocument _document;
      //public WebParser(HtmlDocument document)
      //{
      //   _document = document;
      //}
      public string ParseProductCategory(/*HtmlDocument document*/)
      {
         //return document
         //   .DocumentNode
         //   .Descendants("h1")
         //   .Where(_ => _.GetAttributeValue("itemprop", "")
         //   .Equals("name"))
         //   .FirstOrDefault()
         //   .InnerText;
         throw new System.NotImplementedException();
      }

      public string ParseProductPrice()
      {
         throw new System.NotImplementedException();
      }

      public string ParseProductTitle()
      {
         throw new System.NotImplementedException();
      }


      public string[] ParseStoreElements(HtmlDocument document, ICrawlerSettings settings)
      {
         var priceList = new List<string>();
         var parentDivs = document
                        .DocumentNode
                        .Descendants("div")
                        .Where(_ => _.GetAttributeValue("class", "")
                        .Equals("g-i-tile g-i-tile-catalog"))
                        .ToList();
         
         var price = document.DocumentNode.Descendants("div").Where(_ => _.GetAttributeValue("class", "").Equals("g-i-tile-l g-i-tile-catalog-hover-left-side clearfix")).ToList();
         
         foreach (var item in parentDivs)
         {
            var parsedProduct = new RozetkaProduct
            {
               Category = document.DocumentNode.Descendants("h1").Where(_ => _.GetAttributeValue("itemprop", "").Equals("name")).FirstOrDefault().InnerText,
               Name = item.Descendants("div").Where(_ => _.GetAttributeValue("class", "").Equals("g-i-tile-i-title clearfix")).FirstOrDefault().InnerText,
               ImageLink = item.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
               //Price = item.Descendants("div").Where(_ => _.GetAttributeValue("id", "").Equals("goods_price_block_2323992")).FirstOrDefault().InnerText
               //Scripts = 
            };
            priceList.Add(parsedProduct.ToString());
         }

         return priceList.ToArray();
      }

      
   }
}
