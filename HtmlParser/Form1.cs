
namespace HtmlParser
{
   using HtmlParser.Core;
   using HtmlParser.Core.ParserSettings;
   using MaterialSkin;
   using MaterialSkin.Controls;
   using System;
   using System.IO;
   using System.Windows.Forms;
   using System.Linq;

   public partial class Form1 : MaterialForm
   {
      ParserWorker<string[]> parser;

      public Form1()
      {
         InitializeComponent();
         //var materialSkinManager = MaterialSkinManager.Instance;
         //materialSkinManager.AddFormToManage(this);
         //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
         //materialSkinManager.ColorScheme =
         //                  new ColorScheme(Primary.Cyan400,
         //                                  Primary.BlueGrey900,
         //                                  Primary.BlueGrey500,
         //                                  Accent.LightBlue200,
         //                                  TextShade.WHITE);

         parser = new ParserWorker<string[]>(new WebParser());

         parser.OneCompleted += Parser_OneCompleted;
         parser.OneNewData += Parser_OneNewData;

      }

      private void Parser_OneNewData(object arg1, string[] arg2)
      {
         var query = arg2.ToArray();
         ListTitles.Items.AddRange(query);
      }

      private void Parser_OneCompleted(object obj)
      {
         MessageBox.Show("All works is done");
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void materialFlatButton1_Click(object sender, EventArgs e)
      {

         parser.Settings = new ParserSettings(materialSingleLineTextField1.Text,materialSingleLineTextField2.Text);
         ListTitles.Items.Clear();
         parser.Start();

      }

      private void materialFlatButton2_Click(object sender, EventArgs e)
      {
         parser.Abort();
      }

      private void materialFlatButton3_Click(object sender, EventArgs e)
      {
         TextWriter writer = new StreamWriter(@"new_file.txt");
         foreach (var item in ListTitles.Items)
         {
            writer.WriteLine(item.ToString());
         }
            
         writer.Close();

         MessageBox.Show("Saving Completed");

      }

      private void tabPage1_Click(object sender, EventArgs e)
      {

      }
   }
}
