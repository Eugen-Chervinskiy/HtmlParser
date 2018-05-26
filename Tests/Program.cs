using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
   class Program
   {
      static void Main(string[] args)
      {
         string json = JSonScript.JSon;
         dynamic stuff = JObject.Parse(json);

         string name = stuff.Title;

         Console.WriteLine(name);
      }
   }
}
