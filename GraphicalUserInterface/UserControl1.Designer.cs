namespace GraphicalUserInterface
{
   partial class UserControl1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
         this.button1 = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.button1.FlatAppearance.BorderSize = 0;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.button1.Location = new System.Drawing.Point(255, 286);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(186, 46);
         this.button1.TabIndex = 8;
         this.button1.Text = "Get Started";
         this.button1.UseVisualStyleBackColor = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(114, 173);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(552, 90);
         this.label1.TabIndex = 7;
         this.label1.Text = resources.GetString("label1.Text");
         // 
         // bunifuCustomLabel1
         // 
         this.bunifuCustomLabel1.AutoSize = true;
         this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Turquoise;
         this.bunifuCustomLabel1.Location = new System.Drawing.Point(111, 99);
         this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
         this.bunifuCustomLabel1.Size = new System.Drawing.Size(188, 33);
         this.bunifuCustomLabel1.TabIndex = 6;
         this.bunifuCustomLabel1.Text = "Web Crawler";
         // 
         // UserControl1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.bunifuCustomLabel1);
         this.Name = "UserControl1";
         this.Size = new System.Drawing.Size(777, 431);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label1;
      private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
   }
}
