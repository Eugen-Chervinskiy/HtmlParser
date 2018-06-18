namespace GraphicalUserInterface
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.panel1 = new System.Windows.Forms.Panel();
         this.button4 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
         this.main1 = new GraphicalUserInterface.Main();
         this.step21 = new GraphicalUserInterface.Step2();
         this.step31 = new GraphicalUserInterface.Step3();
         this.step41 = new GraphicalUserInterface.Step4();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.panel1.Controls.Add(this.button4);
         this.panel1.Controls.Add(this.button3);
         this.panel1.Controls.Add(this.button2);
         this.panel1.Controls.Add(this.button1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(209, 554);
         this.panel1.TabIndex = 0;
         // 
         // button4
         // 
         this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button4.ForeColor = System.Drawing.Color.Teal;
         this.button4.Location = new System.Drawing.Point(0, 274);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(209, 55);
         this.button4.TabIndex = 5;
         this.button4.Text = "Step4";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button3
         // 
         this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button3.ForeColor = System.Drawing.Color.Teal;
         this.button3.Location = new System.Drawing.Point(0, 207);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(209, 61);
         this.button3.TabIndex = 4;
         this.button3.Text = "Step3";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button2
         // 
         this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button2.ForeColor = System.Drawing.Color.Teal;
         this.button2.Location = new System.Drawing.Point(0, 145);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(209, 56);
         this.button2.TabIndex = 3;
         this.button2.Text = "Step2";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button1
         // 
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button1.ForeColor = System.Drawing.Color.Teal;
         this.button1.Location = new System.Drawing.Point(0, 80);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(209, 59);
         this.button1.TabIndex = 2;
         this.button1.Text = "Step1";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(209, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(715, 22);
         this.panel2.TabIndex = 1;
         // 
         // bunifuDragControl1
         // 
         this.bunifuDragControl1.Fixed = true;
         this.bunifuDragControl1.Horizontal = true;
         this.bunifuDragControl1.TargetControl = this.panel1;
         this.bunifuDragControl1.Vertical = true;
         // 
         // main1
         // 
         this.main1.Location = new System.Drawing.Point(209, 23);
         this.main1.Name = "main1";
         this.main1.Size = new System.Drawing.Size(757, 519);
         this.main1.TabIndex = 2;
         // 
         // step21
         // 
         this.step21.Location = new System.Drawing.Point(209, 12);
         this.step21.Name = "step21";
         this.step21.Size = new System.Drawing.Size(731, 464);
         this.step21.TabIndex = 3;
         // 
         // step31
         // 
         this.step31.Location = new System.Drawing.Point(207, 3);
         this.step31.Name = "step31";
         this.step31.Size = new System.Drawing.Size(759, 526);
         this.step31.TabIndex = 4;
         // 
         // step41
         // 
         this.step41.Location = new System.Drawing.Point(207, 0);
         this.step41.Name = "step41";
         this.step41.Size = new System.Drawing.Size(754, 476);
         this.step41.TabIndex = 5;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(924, 554);
         this.Controls.Add(this.step41);
         this.Controls.Add(this.step31);
         this.Controls.Add(this.step21);
         this.Controls.Add(this.main1);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "MainForm";
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button2;
      private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
      private Main main1;
      private Step2 step21;
      private Step3 step31;
      private Step4 step41;
   }
}