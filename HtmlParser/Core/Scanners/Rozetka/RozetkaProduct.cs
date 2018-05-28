using HtmlAgilityPack;
using HtmlParser.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.ParserSettings
{
   public class RozetkaProduct : IProduct
   {
      public RozetkaProduct()
      {

      }
      //public IEnumerable<HtmlNode> Scripts;
      public string Category { get; set; }
      public string Name { get; set;}
      public string Price { get; set; }
      public string ImageLink { get; set; }
      public string ProductLink { get; set; }

      public override string ToString()
      {
         return string.Format(
                              $"Category: {this.Category} \n\r" +
                              $"Name: {this.Name} \n\r" +
                              $"Image: {this.ImageLink} \n\r" +
                              $"Price: {this.Price} \n\r");
      }

      //public IEnumerable<HtmlNode> ShowScripts()
      //{
      //   return Scripts;
      //}

   }
}
