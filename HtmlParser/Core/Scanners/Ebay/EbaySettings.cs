using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.Scanners.Ebay
{
   public class EbaySettings : ICrawlerSettings
   {
      public string CategoriesPageUrl { get; set; } = "https://www.ebay.com/v/allcategories";
      public IDictionary<string, string> ScannerCategories { get; set; }
      public string FileResultPath { get; set; } = "ebay.txt";
   }
}
