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
         main1.BringToFront();
         



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
         main1.BringToFront();
         var scanner = new RozetkaCrawler();
         var settings = new RozetkaSettings();
         var crawler = new ParserWorker<List<RozetkaProduct>>(scanner, settings);
         crawler.OneCompleted += Parser_OneCompleted;
         crawler.Start();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         step21.BringToFront();
      }

      private void button3_Click(object sender, EventArgs e)
      {
         step31.BringToFront();
         
      }

      private void button4_Click(object sender, EventArgs e)
      {
         step41.BringToFront();
      }
   }
}
