using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DataAccess;
using HtmlAgilityPack;
using HtmlParser.Core.Interfaces;
using HtmlParser.Core.ParserSettings;
using System.Web.UI;
using Newtonsoft.Json.Linq;

namespace HtmlParser.Core.Scanners.Rozetka
{
   public class RozetkaCrawler : ICrawler<List<RozetkaProduct>>
   {
      
      private int productCount;
      public ICrawlerDataProvider DataProvider { get; set; }

      public bool CanScanPage()
      {
         throw new NotImplementedException();
      }

      public async Task<IEnumerable<string>> ParseCategoriesAsync(ICrawlerSettings settings)
      {
         var resut = new List<string>();

         var httpClient = new HttpClient();

         var html = await httpClient.GetStringAsync(settings.CategoriesPageUrl);

         var htmlDocument = new HtmlDocument();
         htmlDocument.LoadHtml(html);


         var categories = htmlDocument
            .DocumentNode
            .Descendants("a")

            .Where(node => node.GetAttributeValue("class", "").Equals("all-cat-b-l-i-link-child novisited"))
            .ToList();


         //var categories = htmlDocument
         //   .DocumentNode
         //   .Descendants("ul")

         //   .Where(node => node.GetAttributeValue("class", "").Equals("sub-categories-list"))
         //   .ToList();

         using (var writer = new StreamWriter("textTTTT.txt"))
         {
            foreach (var item in categories)
            {
               //File.AppendAllText($"textTTTT.txt", item.GetAttributeValue("href", "") + $"\n\r");
               await writer.WriteLineAsync(item.GetAttributeValue("href", ""));
            }
         }
         

         return resut.ToList();
      }

      public List<RozetkaProduct> ParseStoreElements(HtmlDocument document, ICrawlerSettings settings)
      {
         RozetkaProduct parsedProduct = null;
         var serializator = new Serializator<List<RozetkaProduct>>();
         productCount = 0;
         var products = new List<RozetkaProduct>();
         var parentDivs = document
                        .DocumentNode
                        .Descendants("div")
                        .Where(_ => _.GetAttributeValue("class", "")
                        .Equals("g-i-tile g-i-tile-catalog"))
                        .ToList();

         var scriptPrice = document.DocumentNode.Descendants("script").Skip(3).Take(1).FirstOrDefault().InnerText;

         var configJson = scriptPrice.Replace("dataLayer.push(","").Replace(");","");

         JObject jObject = JObject.Parse(configJson);
         JToken jproduct = jObject["products"];
         
         foreach (var item in parentDivs)
         {

            parsedProduct = new RozetkaProduct
            {
               Category = document.DocumentNode.Descendants("h1").Where(_ => _.GetAttributeValue("itemprop", "").Equals("name")).FirstOrDefault().InnerText,
               Name = item.Descendants("div").Where(_ => _.GetAttributeValue("class", "").Equals("g-i-tile-i-title clearfix")).FirstOrDefault().InnerText,
               ImageLink = item.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
               ProductLink = item.Descendants("div").Where(_ => _.GetAttributeValue("class", "").Equals("g-i-tile-i-title clearfix")).FirstOrDefault().Descendants("a").FirstOrDefault().GetAttributeValue("href",""),
               Price = (string)jproduct[productCount]["productPrice"],
               ProductID = (string)jproduct[productCount]["prodictID"],
               Condition = (string)jproduct[productCount]["productCondition"],
               VendorID = (string)jproduct[productCount]["productVendorID"],
               SalesRank = (string)jproduct[productCount]["productPosition"]
            };

            products.Add(parsedProduct);
            productCount++;
         }
         
         //serializator.SerializeToXml(products,parsedProduct.Category);
         serializator.SerializeToJson(products, parsedProduct.Category);
         return products;
      }

      
   }
}
