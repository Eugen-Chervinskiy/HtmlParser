
using System.Collections.Generic;

namespace HtmlParser.Core
{
   public interface ICrawlerSettings
   {
      string CategoriesPageUrl { get; set; }
      IDictionary<string, string> ScannerCategories { get; set; }
      string FileResultPath { get; set; }
      
   }
}
