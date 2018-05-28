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

namespace HtmlParser.Core.Scanners.Rozetka
{
   public class RozetkaCrawler : ICrawler<List<RozetkaProduct>>, ICrawlerDataProvider
   {
      public ICrawlerDataProvider dataProvider { get; set; }

      public IEnumerable<string> ParseCategoriesAsync()
      {
         throw new NotImplementedException();
      }

      //public async Task<IEnumerable<string>> ParseCategoriesAsync()
      //{
      //   var resut = new List<string>();

      //   var httpClient = new HttpClient();

      //   var html = await httpClient.GetStringAsync();

      //   var htmlDocument = new HtmlDocument();
      //   htmlDocument.LoadHtml(html);



      //   //var categories = htmlDocument
      //   //   .DocumentNode
      //   //   .Descendants("a")

      //   //   .Where(node => node.GetAttributeValue("class", "").Equals("categories-with-links"))
      //   //   .ToList();


      //   var categories = htmlDocument
      //      .DocumentNode
      //      .Descendants("ul")

      //      .Where(node => node.GetAttributeValue("class", "").Equals("sub-categories-list"))
      //      .ToList();

      //   foreach (var item in categories)
      //   {
      //      Console.WriteLine(item.InnerText);
      //      //Console.WriteLine(item.InnerHtml);
      //      Console.WriteLine(item.GetAttributeValue("href", ""));
      //      resut.Add(item.GetAttributeValue("href", ""));
      //      File.AppendAllText("text.txt", item.InnerHtml + "\n");

      //   }
      //}

      public string ParseProductCategory()
      {
         throw new NotImplementedException();
      }

      public string ParseProductPrice()
      {
         throw new NotImplementedException();
      }

      public string ParseProductTitle()
      {
         throw new NotImplementedException();
      }

      public List<RozetkaProduct> ParseStoreElements(HtmlDocument document, ICrawlerSettings settings)
      {
         var products = new List<RozetkaProduct>();
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
            products.Add(parsedProduct);
         }
         var serializator = new Serializator<List<RozetkaProduct>>();
         serializator.SerializeToXml(products);
         return products;
      }

      public void UpdateCrawlerData(ICrawlerSettings settings)
      {
         throw new NotImplementedException();
      }
   }
}
