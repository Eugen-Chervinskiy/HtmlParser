﻿namespace GraphicalUserInterface
{
   partial class Step2
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2));
         this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.button1 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.SuspendLayout();
         // 
         // bunifuCustomLabel1
         // 
         this.bunifuCustomLabel1.AutoSize = true;
         this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightSeaGreen;
         this.bunifuCustomLabel1.Location = new System.Drawing.Point(199, 27);
         this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
         this.bunifuCustomLabel1.Size = new System.Drawing.Size(318, 24);
         this.bunifuCustomLabel1.TabIndex = 0;
         this.bunifuCustomLabel1.Text = "Step1 - Choose Store to Crawl";
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.radioButton1.Location = new System.Drawing.Point(126, 302);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(75, 26);
         this.radioButton1.TabIndex = 1;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "Ebay";
         this.radioButton1.UseVisualStyleBackColor = true;
         // 
         // radioButton2
         // 
         this.radioButton2.AutoSize = true;
         this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.radioButton2.Location = new System.Drawing.Point(523, 302);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(102, 26);
         this.radioButton2.TabIndex = 2;
         this.radioButton2.TabStop = true;
         this.radioButton2.Text = "Rozetka";
         this.radioButton2.UseVisualStyleBackColor = true;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(42, 66);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(258, 230);
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
         this.pictureBox2.Location = new System.Drawing.Point(427, 66);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(252, 228);
         this.pictureBox2.TabIndex = 4;
         this.pictureBox2.TabStop = false;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.button1.FlatAppearance.BorderSize = 0;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.button1.Location = new System.Drawing.Point(274, 346);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(186, 46);
         this.button1.TabIndex = 6;
         this.button1.Text = "Get Categories";
         this.button1.UseVisualStyleBackColor = false;
         // 
         // Step2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.button1);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.radioButton2);
         this.Controls.Add(this.radioButton1);
         this.Controls.Add(this.bunifuCustomLabel1);
         this.Name = "Step2";
         this.Size = new System.Drawing.Size(731, 464);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
      private System.Windows.Forms.RadioButton radioButton1;
      private System.Windows.Forms.RadioButton radioButton2;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Button button1;
   }
}
