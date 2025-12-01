namespace Bai5
{
    partial class Form2
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
            MSVBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TenSVBox = new TextBox();
            label3 = new Label();
            KhoaCbBox = new ComboBox();
            label4 = new Label();
            DTBBox = new TextBox();
            AddBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // MSVBox
            // 
            MSVBox.BorderStyle = BorderStyle.FixedSingle;
            MSVBox.Location = new Point(158, 45);
            MSVBox.Name = "MSVBox";
            MSVBox.Size = new Size(365, 27);
            MSVBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 48);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 98);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sinh viên";
            // 
            // TenSVBox
            // 
            TenSVBox.BorderStyle = BorderStyle.FixedSingle;
            TenSVBox.Location = new Point(158, 95);
            TenSVBox.Name = "TenSVBox";
            TenSVBox.Size = new Size(418, 27);
            TenSVBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 144);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Khoa";
            // 
            // KhoaCbBox
            // 
            KhoaCbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            KhoaCbBox.FormattingEnabled = true;
            KhoaCbBox.Items.AddRange(new object[] { "Công nghệ thông tin", "Kỹ thuật phần mềm ", "Hệ thống thông tin", "Khoa học máy tính" });
            KhoaCbBox.Location = new Point(158, 141);
            KhoaCbBox.Name = "KhoaCbBox";
            KhoaCbBox.Size = new Size(418, 28);
            KhoaCbBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 191);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 6;
            label4.Text = "Điểm TB";
            // 
            // DTBBox
            // 
            DTBBox.BorderStyle = BorderStyle.FixedSingle;
            DTBBox.Location = new Point(158, 188);
            DTBBox.Name = "DTBBox";
            DTBBox.Size = new Size(150, 27);
            DTBBox.TabIndex = 7;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.MediumSeaGreen;
            AddBtn.Location = new Point(358, 263);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Thêm mới";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.OrangeRed;
            ExitBtn.Location = new Point(482, 263);
            ExitBtn.Margin = new Padding(0);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(94, 29);
            ExitBtn.TabIndex = 9;
            ExitBtn.Text = "Thoát";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 313);
            Controls.Add(ExitBtn);
            Controls.Add(AddBtn);
            Controls.Add(DTBBox);
            Controls.Add(label4);
            Controls.Add(KhoaCbBox);
            Controls.Add(label3);
            Controls.Add(TenSVBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MSVBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MSVBox;
        private Label label1;
        private Label label2;
        private TextBox TenSVBox;
        private Label label3;
        private ComboBox KhoaCbBox;
        private Label label4;
        private TextBox DTBBox;
        private Button AddBtn;
        private Button ExitBtn;
    }
}