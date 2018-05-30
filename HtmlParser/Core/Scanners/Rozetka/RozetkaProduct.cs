using HtmlAgilityPack;
using HtmlParser.Core.Interfaces;
using Newtonsoft.Json.Linq;
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

      public string Category { get; set; }
      public string Name { get; set;}
      public string Price { get; set; }
      public string ImageLink { get; set; }
      public string ProductLink { get; set; }
      public string VendorID { get; set; }
      public string ProductID { get; set; }
      public string SalesRank { get; set; }
      public string Condition { get; set; }

      public override string ToString()
      {
         return string.Format(
                              $"Category: {this.Category} \n\r" +
                              $"Name: {this.Name} \n\r" +
                              $"Image: {this.ImageLink} \n\r" +
                              $"Price: {this.Price} \n\r");
      }

      
   }
}
