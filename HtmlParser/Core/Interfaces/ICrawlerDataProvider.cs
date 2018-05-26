using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlParser.Core.Interfaces
{
   public interface ICrawlerDataProvider
   {
      ICrawlerDataProvider dataProvider { get; set; }
      void UpdateCrawlerData(ICrawlerSettings settings);
   }
}
