namespace Bai4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TextPlace = new RichTextBox();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            NewMenuBtn = new ToolStripMenuItem();
            OpenMenuBtn = new ToolStripMenuItem();
            SaveMenuBtn = new ToolStripMenuItem();
            ExitMenuBtn = new ToolStripMenuItem();
            FontDLMenu = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            NewFileBtn = new ToolStripButton();
            SaveBtn = new ToolStripButton();
            FontCbBox = new ToolStripComboBox();
            SizeCbBox = new ToolStripComboBox();
            BoldBtn = new ToolStripButton();
            ItalicBtn = new ToolStripButton();
            UnderlineBtn = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextPlace
            // 
            TextPlace.Dock = DockStyle.Bottom;
            TextPlace.Location = new Point(0, 61);
            TextPlace.Margin = new Padding(10);
            TextPlace.Name = "TextPlace";
            TextPlace.Size = new Size(800, 389);
            TextPlace.TabIndex = 0;
            TextPlace.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightSkyBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, FontDLMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewMenuBtn, OpenMenuBtn, SaveMenuBtn, ExitMenuBtn });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // NewMenuBtn
            // 
            NewMenuBtn.Name = "NewMenuBtn";
            NewMenuBtn.Size = new Size(203, 26);
            NewMenuBtn.Text = "Tạo văn bản mới";
            NewMenuBtn.Click += NewMenuBtn_Click;
            // 
            // OpenMenuBtn
            // 
            OpenMenuBtn.Name = "OpenMenuBtn";
            OpenMenuBtn.Size = new Size(203, 26);
            OpenMenuBtn.Text = "Mở tập tin";
            OpenMenuBtn.Click += OpenMenuBtn_Click;
            // 
            // SaveMenuBtn
            // 
            SaveMenuBtn.Name = "SaveMenuBtn";
            SaveMenuBtn.Size = new Size(203, 26);
            SaveMenuBtn.Text = "Lưu nội dung";
            SaveMenuBtn.Click += SaveMenuBtn_Click;
            // 
            // ExitMenuBtn
            // 
            ExitMenuBtn.Name = "ExitMenuBtn";
            ExitMenuBtn.Size = new Size(203, 26);
            ExitMenuBtn.Text = "Thoát";
            ExitMenuBtn.Click += ExitMenuBtn_Click;
            // 
            // FontDLMenu
            // 
            FontDLMenu.Name = "FontDLMenu";
            FontDLMenu.Size = new Size(92, 24);
            FontDLMenu.Text = "Định dạng";
            FontDLMenu.Click += FontDLMenu_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { NewFileBtn, SaveBtn, FontCbBox, SizeCbBox, BoldBtn, ItalicBtn, UnderlineBtn });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 30);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // NewFileBtn
            // 
            NewFileBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewFileBtn.Image = (Image)resources.GetObject("NewFileBtn.Image");
            NewFileBtn.ImageTransparentColor = Color.Magenta;
            NewFileBtn.Name = "NewFileBtn";
            NewFileBtn.Size = new Size(29, 27);
            NewFileBtn.Text = "toolStripButton1";
            NewFileBtn.Click += NewMenuBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveBtn.Image = (Image)resources.GetObject("SaveBtn.Image");
            SaveBtn.ImageTransparentColor = Color.Magenta;
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(29, 27);
            SaveBtn.Text = "toolStripButton2";
            SaveBtn.Click += SaveMenuBtn_Click;
            // 
            // FontCbBox
            // 
            FontCbBox.Name = "FontCbBox";
            FontCbBox.Size = new Size(200, 30);
            FontCbBox.SelectedIndexChanged += FontCbBox_SelectedIndexChanged;
            // 
            // SizeCbBox
            // 
            SizeCbBox.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            SizeCbBox.Name = "SizeCbBox";
            SizeCbBox.Size = new Size(121, 30);
            SizeCbBox.SelectedIndexChanged += SizeCbBox_SelectedIndexChanged;
            // 
            // BoldBtn
            // 
            BoldBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BoldBtn.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoldBtn.Image = (Image)resources.GetObject("BoldBtn.Image");
            BoldBtn.ImageTransparentColor = Color.Magenta;
            BoldBtn.Margin = new Padding(5, 1, 5, 2);
            BoldBtn.Name = "BoldBtn";
            BoldBtn.Size = new Size(29, 27);
            BoldBtn.Text = "B";
            BoldBtn.Click += BoldBtn_Click;
            // 
            // ItalicBtn
            // 
            ItalicBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ItalicBtn.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ItalicBtn.Image = (Image)resources.GetObject("ItalicBtn.Image");
            ItalicBtn.ImageTransparentColor = Color.Magenta;
            ItalicBtn.Margin = new Padding(0, 1, 5, 2);
            ItalicBtn.Name = "ItalicBtn";
            ItalicBtn.Size = new Size(29, 27);
            ItalicBtn.Text = "I";
            ItalicBtn.Click += ItalicBtn_Click;
            // 
            // UnderlineBtn
            // 
            UnderlineBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            UnderlineBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            UnderlineBtn.Image = (Image)resources.GetObject("UnderlineBtn.Image");
            UnderlineBtn.ImageTransparentColor = Color.Magenta;
            UnderlineBtn.Margin = new Padding(0, 1, 5, 2);
            UnderlineBtn.Name = "UnderlineBtn";
            UnderlineBtn.Size = new Size(29, 27);
            UnderlineBtn.Text = "U";
            UnderlineBtn.Click += UnderlineBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(TextPlace);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TextPlace;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem NewMenuBtn;
        private ToolStripMenuItem OpenMenuBtn;
        private ToolStripMenuItem SaveMenuBtn;
        private ToolStripMenuItem FontDLMenu;
        private ToolStripMenuItem ExitMenuBtn;
        private ToolStrip toolStrip1;
        private ToolStripButton NewFileBtn;
        private ToolStripButton SaveBtn;
        private ToolStripComboBox FontCbBox;
        private ToolStripComboBox SizeCbBox;
        private ToolStripButton BoldBtn;
        private ToolStripButton ItalicBtn;
        private ToolStripButton UnderlineBtn;
    }
}
