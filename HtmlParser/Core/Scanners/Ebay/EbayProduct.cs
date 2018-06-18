using HtmlParser.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.ParserSettings
{
   public class EbayProduct : IProduct
   {
      public string Category { get; set; }
      public string Name { get; set; }
      public string SubTitle { get; set; }
      public string Price { get; set; }
      public string ImageLink { get; set; }
      public string ProductLink { get; set; }
      public string ProductSold { get; set; }


   }
}
