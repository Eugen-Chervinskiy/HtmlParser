using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.Scanners.Ebay
{
   public static class EbayHelper
   {
      public static TSource MyFirstOrDefault<TSource>(this IEnumerable<TSource> source)
      {
         if (source == null)
         {
            source = new List<TSource>();
         }

         IList<TSource> list = source as IList<TSource>;
         if (list != null)
         {
            if (list.Count > 0)
            {
               return list[0];
            }
         }
         else
         {
            using (IEnumerator<TSource> enumerator = source.GetEnumerator())
            {
               if (enumerator.MoveNext())
               {
                  return enumerator.Current;
               }
            }
         }
         return default(TSource);
      }
   }
}
