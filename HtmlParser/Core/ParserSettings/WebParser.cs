
using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Core.ParserSettings
{
   using AngleSharp.Dom;
   using AngleSharp.Dom.Html;
   using HtmlAgilityPack;

   public class WebParser : IStoreParser<string[]>
   {
      public string[] ParseProductCategory()
      {
         throw new System.NotImplementedException();
      }

      public string[] ParseProductPrice()
      {
         throw new System.NotImplementedException();
      }

      public string[] ParseProductTitle()
      {
         throw new System.NotImplementedException();
      }

      //public string[] ParseStoreElements(IHtmlDocument document,IParserSettings settings)
      //{
      //   var list = new List<string>();
      //   var priceList = new List<string>();


      //   var items = document.QuerySelectorAll(settings.Tag);
      //   var price = document.QuerySelectorAll("div").Where(_ => _.ClassName != null && _.ClassName.Equals("u"));

      //   foreach (var item in price)
      //   {
      //      priceList.Add(item.InnerHtml);
      //   }



      //   return list.ToArray();
      //}

      public string[] ParseStoreElements(HtmlDocument document, IParserSettings settings)
      {
         var priceList = new List<string>();

         var price = document.DocumentNode.SelectNodes(".//div[@class='g-price-uah']//text()");

         //foreach (var item in price)
         //{
         //   priceList.Add(item.InnerHtml);
         //}

         HtmlNodeCollection col = price;

         return col.ToArray();
      }
   }
}
