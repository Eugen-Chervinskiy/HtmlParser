using System;
using System.Diagnostics;
using DataAccess;
using HtmlParser.Core;
using HtmlParser.Core.ParserSettings;
using HtmlParser.Core.Scanners.Rozetka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CrawlerWorkTests
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void TestMethod1()
      {
         var scannerSettings = new RozetkaSettings();
         var provider = new CrawlerDataProvider();
         var categories = provider.GetCategories(scannerSettings.FileResultPath);

         foreach (var item in categories)
         {
            Debug.WriteLine(item);
         }
      }

      [TestMethod]
      public void TestMethod2()
      {
         var scanner = new RozetkaCrawler();
         var settings = new RozetkaSettings();
         var crawler = new CrawlingProccess<List<RozetkaProduct>>(scanner,settings);

         crawler.Start();
      }
   }
}
