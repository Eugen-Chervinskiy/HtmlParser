using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.Interfaces
{
   public interface IProduct
   {
      string Category { get; set; }
      string Name { get; set; }
      string Price { get; set; }
      string ProductLink { get; set; }
      string ImageLink { get; set; }
   }
}
