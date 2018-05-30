using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class CrawlerDataProvider
   {
      public IEnumerable<string> GetCategories(string path)
      {
         if (!File.Exists(path))
         {
            throw new FileNotFoundException("File not found!");
         }

         IEnumerable<string> categories = File.ReadAllLines(path);
         return categories;
      }
   }
}
