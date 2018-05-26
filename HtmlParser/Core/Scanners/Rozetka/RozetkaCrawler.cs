using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using HtmlParser.Core.Interfaces;
using HtmlParser.Core.ParserSettings;

namespace HtmlParser.Core.Scanners.Rozetka
{
   public class RozetkaCrawler : ICrawler<RozetkaProduct[]>, ICrawlerDataProvider
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

      public RozetkaProduct[] ParseStoreElements(HtmlDocument document, ICrawlerSettings settings)
      {
         throw new NotImplementedException();
      }

      public void UpdateCrawlerData(ICrawlerSettings settings)
      {
         throw new NotImplementedException();
      }
   }
}
