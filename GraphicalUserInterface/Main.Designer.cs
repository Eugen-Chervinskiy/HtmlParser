namespace GraphicalUserInterface
{
   partial class Main
   {
      /// <summary> 
      /// Обязательная переменная конструктора.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Освободить все используемые ресурсы.
      /// </summary>
      /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Код, автоматически созданный конструктором компонентов

      /// <summary> 
      /// Требуемый метод для поддержки конструктора — не изменяйте 
      /// содержимое этого метода с помощью редактора кода.
      /// </summary>
      private void InitializeComponent()
      {
         this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // bunifuCustomLabel1
         // 
         this.bunifuCustomLabel1.AutoSize = true;
         this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Turquoise;
         this.bunifuCustomLabel1.Location = new System.Drawing.Point(90, 66);
         this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
         this.bunifuCustomLabel1.Size = new System.Drawing.Size(188, 33);
         this.bunifuCustomLabel1.TabIndex = 0;
         this.bunifuCustomLabel1.Text = "Web Crawler";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(93, 118);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(357, 108);
         this.label1.TabIndex = 4;
         this.label1.Text = "\r\nThis program is designed \r\nto collect information about products in online stor" +
    "es.\r\nAll instructions are described in steps\r\n\r\nClick \"Get Started\" to see how i" +
    "t works\r\n";
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.button1.FlatAppearance.BorderSize = 0;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.button1.Location = new System.Drawing.Point(234, 253);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(186, 46);
         this.button1.TabIndex = 5;
         this.button1.Text = "Get Started";
         this.button1.UseVisualStyleBackColor = false;
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.bunifuCustomLabel1);
         this.Name = "Main";
         this.Size = new System.Drawing.Size(757, 519);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
   }
}
