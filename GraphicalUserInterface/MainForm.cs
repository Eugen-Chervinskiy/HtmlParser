using HtmlParser.Core;
using HtmlParser.Core.ParserSettings;
using HtmlParser.Core.Scanners.Rozetka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         
      }

      private void MainForm_Load(object sender, EventArgs e)
      {

      }

      private void Parser_OneCompleted(object obj)
      {
         MessageBox.Show("All works is done");
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var scanner = new RozetkaCrawler();
         var settings = new RozetkaSettings();
         var crawler = new ParserWorker<List<RozetkaProduct>>(scanner, settings);
         crawler.OneCompleted += Parser_OneCompleted;

         crawler.Start();
      }
   }
}
