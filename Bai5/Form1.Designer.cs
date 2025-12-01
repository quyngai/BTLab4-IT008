namespace Bai5
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
            toolStrip1 = new ToolStrip();
            AddMenuBtn = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            SearchMenuBx = new ToolStripTextBox();
            DsSVView = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MSV = new DataGridViewTextBoxColumn();
            TSV = new DataGridViewTextBoxColumn();
            KhoaCol = new DataGridViewTextBoxColumn();
            DTB = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DsSVView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.GradientInactiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddMenuBtn, toolStripLabel1, toolStripLabel2, SearchMenuBx });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(839, 45);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddMenuBtn
            // 
            AddMenuBtn.AutoSize = false;
            AddMenuBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AddMenuBtn.Image = (Image)resources.GetObject("AddMenuBtn.Image");
            AddMenuBtn.ImageTransparentColor = Color.Magenta;
            AddMenuBtn.Name = "AddMenuBtn";
            AddMenuBtn.Size = new Size(40, 42);
            AddMenuBtn.Text = "toolStripButton1";
            AddMenuBtn.Click += AddMenuBtn_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Margin = new Padding(0, 1, 60, 2);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(76, 42);
            toolStripLabel1.Text = "Thêm mới";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Margin = new Padding(0, 1, 5, 2);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(129, 42);
            toolStripLabel2.Text = "Tìm kiếm theo tên";
            // 
            // SearchMenuBx
            // 
            SearchMenuBx.AutoSize = false;
            SearchMenuBx.BorderStyle = BorderStyle.FixedSingle;
            SearchMenuBx.Name = "SearchMenuBx";
            SearchMenuBx.Size = new Size(300, 27);
            SearchMenuBx.TextChanged += SearchMenuBx_TextChanged;
            // 
            // DsSVView
            // 
            DsSVView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DsSVView.Columns.AddRange(new DataGridViewColumn[] { STT, MSV, TSV, KhoaCol, DTB });
            DsSVView.Dock = DockStyle.Fill;
            DsSVView.Location = new Point(0, 73);
            DsSVView.Name = "DsSVView";
            DsSVView.RowHeadersWidth = 51;
            DsSVView.Size = new Size(839, 465);
            DsSVView.TabIndex = 3;
            // 
            // STT
            // 
            STT.HeaderText = "Số TT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 125;
            // 
            // MSV
            // 
            MSV.HeaderText = "Mã Số SV";
            MSV.MinimumWidth = 6;
            MSV.Name = "MSV";
            MSV.Width = 125;
            // 
            // TSV
            // 
            TSV.HeaderText = "Tên Sinh Viên";
            TSV.MinimumWidth = 6;
            TSV.Name = "TSV";
            TSV.Width = 200;
            // 
            // KhoaCol
            // 
            KhoaCol.HeaderText = "Khoa";
            KhoaCol.MinimumWidth = 6;
            KhoaCol.Name = "KhoaCol";
            KhoaCol.Width = 200;
            // 
            // DTB
            // 
            DTB.HeaderText = "Điểm TB";
            DTB.MinimumWidth = 6;
            DTB.Name = "DTB";
            DTB.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(839, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            thêmMớiToolStripMenuItem.Size = new Size(224, 26);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            thêmMớiToolStripMenuItem.Click += AddMenuBtn_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 538);
            Controls.Add(DsSVView);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DsSVView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton AddMenuBtn;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox SearchMenuBx;
        private DataGridView DsSVView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MSV;
        private DataGridViewTextBoxColumn TSV;
        private DataGridViewTextBoxColumn KhoaCol;
        private DataGridViewTextBoxColumn DTB;
    }
}
