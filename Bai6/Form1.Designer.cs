namespace Bai6
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
            label1 = new Label();
            label2 = new Label();
            SrcLinkBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            DesLinkBox = new TextBox();
            SrcLinkBtn = new Button();
            DesLinkBtn = new Button();
            CopyBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            progressBar1 = new ProgressBar();
            statusStrip1 = new StatusStrip();
            DetailLabel = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(16, 42);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(768, 206);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(42, 33);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Sao chép tập tin";
            // 
            // SrcLinkBox
            // 
            SrcLinkBox.Location = new Point(236, 77);
            SrcLinkBox.Name = "SrcLinkBox";
            SrcLinkBox.Size = new Size(452, 27);
            SrcLinkBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 80);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 3;
            label3.Text = "Đường dẫn thư mục nguồn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 135);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 4;
            label4.Text = "Đường dẫn thư mục đích";
            // 
            // DesLinkBox
            // 
            DesLinkBox.Location = new Point(236, 132);
            DesLinkBox.Name = "DesLinkBox";
            DesLinkBox.Size = new Size(452, 27);
            DesLinkBox.TabIndex = 5;
            // 
            // SrcLinkBtn
            // 
            SrcLinkBtn.BackColor = SystemColors.ControlLight;
            SrcLinkBtn.BackgroundImageLayout = ImageLayout.Center;
            SrcLinkBtn.Location = new Point(707, 75);
            SrcLinkBtn.Name = "SrcLinkBtn";
            SrcLinkBtn.Size = new Size(57, 29);
            SrcLinkBtn.TabIndex = 6;
            SrcLinkBtn.Text = "...";
            SrcLinkBtn.UseVisualStyleBackColor = false;
            SrcLinkBtn.Click += SrcLinkBtn_Click;
            // 
            // DesLinkBtn
            // 
            DesLinkBtn.BackColor = SystemColors.ControlLight;
            DesLinkBtn.Location = new Point(707, 132);
            DesLinkBtn.Name = "DesLinkBtn";
            DesLinkBtn.Size = new Size(57, 29);
            DesLinkBtn.TabIndex = 7;
            DesLinkBtn.Text = "...";
            DesLinkBtn.UseVisualStyleBackColor = false;
            DesLinkBtn.Click += DesLinkBtn_Click;
            // 
            // CopyBtn
            // 
            CopyBtn.BackColor = SystemColors.ControlLight;
            CopyBtn.FlatAppearance.BorderColor = Color.Silver;
            CopyBtn.FlatStyle = FlatStyle.Flat;
            CopyBtn.Location = new Point(236, 194);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(259, 29);
            CopyBtn.TabIndex = 8;
            CopyBtn.Text = "Sao chép";
            CopyBtn.UseVisualStyleBackColor = false;
            CopyBtn.Click += CopyBtn_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(16, 272);
            label5.Name = "label5";
            label5.Size = new Size(768, 86);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(42, 263);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 10;
            label6.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(66, 301);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(698, 29);
            progressBar1.TabIndex = 11;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { DetailLabel });
            statusStrip1.Location = new Point(0, 398);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // DetailLabel
            // 
            DetailLabel.Name = "DetailLabel";
            DetailLabel.Size = new Size(0, 18);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 422);
            Controls.Add(statusStrip1);
            Controls.Add(progressBar1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CopyBtn);
            Controls.Add(DesLinkBtn);
            Controls.Add(SrcLinkBtn);
            Controls.Add(DesLinkBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SrcLinkBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox SrcLinkBox;
        private Label label3;
        private Label label4;
        private TextBox DesLinkBox;
        private Button SrcLinkBtn;
        private Button DesLinkBtn;
        private Button CopyBtn;
        private Label label5;
        private Label label6;
        private ProgressBar progressBar1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel DetailLabel;
    }
}
