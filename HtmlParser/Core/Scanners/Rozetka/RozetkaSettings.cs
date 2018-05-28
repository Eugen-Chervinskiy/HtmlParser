
using System.Collections.Generic;


namespace HtmlParser.Core.Scanners.Rozetka
{
   public class RozetkaSettings : ICrawlerSettings
   {
      public string CategoriesPageUrl { get; set; } = "https://rozetka.com.ua/all-categories-goods/";
      public IDictionary<string, string> ScannerCategories { get; set; }
      public string FileResultPath { get; set; } = "rozetka.txt";
   }
}
