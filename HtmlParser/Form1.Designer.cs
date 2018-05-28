namespace HtmlParser
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.ListTitles = new System.Windows.Forms.ListBox();
         this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
         this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
         this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
         this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
         this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
         this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
         this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
         this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.materialTabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.tabPage2.SuspendLayout();
         this.SuspendLayout();
         // 
         // ListTitles
         // 
         this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.ListTitles.BackColor = System.Drawing.Color.White;
         this.ListTitles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.ListTitles.ColumnWidth = 255;
         this.ListTitles.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ListTitles.FormattingEnabled = true;
         this.ListTitles.ItemHeight = 21;
         this.ListTitles.Location = new System.Drawing.Point(6, 20);
         this.ListTitles.Name = "ListTitles";
         this.ListTitles.Size = new System.Drawing.Size(643, 401);
         this.ListTitles.TabIndex = 0;
         this.ListTitles.SelectedIndexChanged += new System.EventHandler(this.ListTitles_SelectedIndexChanged);
         // 
         // materialLabel1
         // 
         this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.materialLabel1.AutoSize = true;
         this.materialLabel1.Depth = 0;
         this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
         this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.materialLabel1.Location = new System.Drawing.Point(747, 23);
         this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialLabel1.Name = "materialLabel1";
         this.materialLabel1.Size = new System.Drawing.Size(75, 19);
         this.materialLabel1.TabIndex = 9;
         this.materialLabel1.Text = "Enter URL";
         // 
         // materialLabel2
         // 
         this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.materialLabel2.AutoSize = true;
         this.materialLabel2.Depth = 0;
         this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
         this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.materialLabel2.Location = new System.Drawing.Point(747, 123);
         this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialLabel2.Name = "materialLabel2";
         this.materialLabel2.Size = new System.Drawing.Size(73, 19);
         this.materialLabel2.TabIndex = 10;
         this.materialLabel2.Text = "Enter Tag";
         // 
         // materialFlatButton1
         // 
         this.materialFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.materialFlatButton1.AutoSize = true;
         this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.materialFlatButton1.Depth = 0;
         this.materialFlatButton1.Icon = null;
         this.materialFlatButton1.Location = new System.Drawing.Point(686, 223);
         this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
         this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialFlatButton1.Name = "materialFlatButton1";
         this.materialFlatButton1.Primary = false;
         this.materialFlatButton1.Size = new System.Drawing.Size(110, 36);
         this.materialFlatButton1.TabIndex = 11;
         this.materialFlatButton1.Text = "Start Parse";
         this.materialFlatButton1.UseVisualStyleBackColor = true;
         this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
         // 
         // materialFlatButton2
         // 
         this.materialFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.materialFlatButton2.AutoSize = true;
         this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.materialFlatButton2.Depth = 0;
         this.materialFlatButton2.Icon = null;
         this.materialFlatButton2.Location = new System.Drawing.Point(686, 289);
         this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
         this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialFlatButton2.Name = "materialFlatButton2";
         this.materialFlatButton2.Primary = false;
         this.materialFlatButton2.Size = new System.Drawing.Size(129, 36);
         this.materialFlatButton2.TabIndex = 12;
         this.materialFlatButton2.Text = "Abort Process";
         this.materialFlatButton2.UseVisualStyleBackColor = true;
         this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
         // 
         // materialSingleLineTextField1
         // 
         this.materialSingleLineTextField1.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.materialSingleLineTextField1.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.materialSingleLineTextField1.Depth = 0;
         this.materialSingleLineTextField1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.materialSingleLineTextField1.Hint = "";
         this.materialSingleLineTextField1.Location = new System.Drawing.Point(689, 72);
         this.materialSingleLineTextField1.MaxLength = 32767;
         this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
         this.materialSingleLineTextField1.PasswordChar = '\0';
         this.materialSingleLineTextField1.SelectedText = "";
         this.materialSingleLineTextField1.SelectionLength = 0;
         this.materialSingleLineTextField1.SelectionStart = 0;
         this.materialSingleLineTextField1.Size = new System.Drawing.Size(193, 23);
         this.materialSingleLineTextField1.TabIndex = 13;
         this.materialSingleLineTextField1.TabStop = false;
         this.materialSingleLineTextField1.UseSystemPasswordChar = false;
         // 
         // materialSingleLineTextField2
         // 
         this.materialSingleLineTextField2.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.materialSingleLineTextField2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.materialSingleLineTextField2.Depth = 0;
         this.materialSingleLineTextField2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.materialSingleLineTextField2.Hint = "";
         this.materialSingleLineTextField2.Location = new System.Drawing.Point(686, 160);
         this.materialSingleLineTextField2.MaxLength = 32767;
         this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
         this.materialSingleLineTextField2.PasswordChar = '\0';
         this.materialSingleLineTextField2.SelectedText = "";
         this.materialSingleLineTextField2.SelectionLength = 0;
         this.materialSingleLineTextField2.SelectionStart = 0;
         this.materialSingleLineTextField2.Size = new System.Drawing.Size(193, 23);
         this.materialSingleLineTextField2.TabIndex = 14;
         this.materialSingleLineTextField2.TabStop = false;
         this.materialSingleLineTextField2.UseSystemPasswordChar = false;
         // 
         // materialFlatButton3
         // 
         this.materialFlatButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.materialFlatButton3.AutoSize = true;
         this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.materialFlatButton3.Depth = 0;
         this.materialFlatButton3.Icon = null;
         this.materialFlatButton3.Location = new System.Drawing.Point(686, 370);
         this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
         this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialFlatButton3.Name = "materialFlatButton3";
         this.materialFlatButton3.Primary = false;
         this.materialFlatButton3.Size = new System.Drawing.Size(94, 36);
         this.materialFlatButton3.TabIndex = 15;
         this.materialFlatButton3.Text = "Save Data";
         this.materialFlatButton3.UseVisualStyleBackColor = true;
         this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
         // 
         // materialTabSelector2
         // 
         this.materialTabSelector2.BaseTabControl = this.materialTabControl1;
         this.materialTabSelector2.Depth = 0;
         this.materialTabSelector2.Location = new System.Drawing.Point(0, 64);
         this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialTabSelector2.Name = "materialTabSelector2";
         this.materialTabSelector2.Size = new System.Drawing.Size(1980, 40);
         this.materialTabSelector2.TabIndex = 17;
         this.materialTabSelector2.Text = "Manual";
         // 
         // materialTabControl1
         // 
         this.materialTabControl1.Controls.Add(this.tabPage1);
         this.materialTabControl1.Controls.Add(this.tabPage2);
         this.materialTabControl1.Depth = 0;
         this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.materialTabControl1.Location = new System.Drawing.Point(0, 98);
         this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialTabControl1.Name = "materialTabControl1";
         this.materialTabControl1.SelectedIndex = 0;
         this.materialTabControl1.Size = new System.Drawing.Size(900, 514);
         this.materialTabControl1.TabIndex = 18;
         // 
         // tabPage1
         // 
         this.tabPage1.BackColor = System.Drawing.Color.White;
         this.tabPage1.Controls.Add(this.pictureBox1);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(892, 488);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Home";
         this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(154, 6);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(593, 392);
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // tabPage2
         // 
         this.tabPage2.BackColor = System.Drawing.Color.White;
         this.tabPage2.Controls.Add(this.ListTitles);
         this.tabPage2.Controls.Add(this.materialSingleLineTextField1);
         this.tabPage2.Controls.Add(this.materialLabel1);
         this.tabPage2.Controls.Add(this.materialFlatButton3);
         this.tabPage2.Controls.Add(this.materialLabel2);
         this.tabPage2.Controls.Add(this.materialSingleLineTextField2);
         this.tabPage2.Controls.Add(this.materialFlatButton1);
         this.tabPage2.Controls.Add(this.materialFlatButton2);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(892, 488);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Parser";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(900, 612);
         this.Controls.Add(this.materialTabControl1);
         this.Controls.Add(this.materialTabSelector2);
         this.Name = "Form1";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Angle Parser";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.materialTabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

