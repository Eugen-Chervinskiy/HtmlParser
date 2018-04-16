
using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Core.ParserSettings
{
   using AngleSharp.Dom.Html;

   public class WebParser : IParser<string[]>
   {
      public string[] Parse(IHtmlDocument document,IParserSettings settings)
      {
         var list = new List<string>();


         var items = document.QuerySelectorAll(settings.Tag);

         foreach (var item in items)
         {
            list.Add(item.TextContent);

         }

         return list.ToArray();
      }
   }
}
