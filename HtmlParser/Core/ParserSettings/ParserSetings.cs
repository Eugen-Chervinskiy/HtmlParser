
using System.Collections.Generic;

namespace HtmlParser.Core.ParserSettings
{
   public class ParserSettings : ICrawlerSettings
   {
      public ParserSettings(string text,string tag)
      {
         CategoriesPageUrl = text;
         Tag = tag;
      }

      public string CategoriesPageUrl { get; set; }
      public string Prefix { get; set; } = "page{CurrentId}";
      public int StartPoint { get; set; }
      public int EndPoint { get; set; }
      public string Tag { get; set; }
      public IDictionary<string, string> ScannerCategories { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
      public string FileResultPath { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
   }
}
