namespace Bai4
{
    public partial class Form1 : Form
    {
        string curFile = "";
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                FontCbBox.Items.Add(font.Name);
            }
            FontCbBox.Text = "Arial";
            SizeCbBox.Text = "14";
            TextPlace.Font = new Font("Arial", 14);
        }

        private void NewMenuBtn_Click(object sender, EventArgs e)
        {
            TextPlace.Clear();
            FontCbBox.Text = "Arial";
            SizeCbBox.Text = "14";
            TextPlace.Font = new Font("Arial", 14);
            curFile = "";

        }

        private void OpenMenuBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text Format (*.rtf)|*.rtf|Text File (*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string file = openFile.FileName;
                if (file.EndsWith(".rtf"))
                {
                    TextPlace.LoadFile(file, RichTextBoxStreamType.RichText);
                }
                else if (file.EndsWith(".txt"))
                {
                    TextPlace.LoadFile(file, RichTextBoxStreamType.PlainText);
                }
                curFile = file;
            }
        }
        private void SaveMenuBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(curFile))
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Filter = "Rich Text Format (*.rtf)|*.rtf";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    curFile = saveDlg.FileName;
                    TextPlace.SaveFile(curFile, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Da luu thanh cong!");
                }
            }
            else
            {
                TextPlace.SaveFile(curFile, RichTextBoxStreamType.RichText);
                MessageBox.Show("Da luu thanh cong!");
            }
        }
        private void ExitMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FontDLMenu_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = TextPlace.SelectionFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                TextPlace.Font = fontDialog.Font;
                FontCbBox.Text = fontDialog.Font.Name;
                SizeCbBox.Text = fontDialog.Font.Size.ToString();
            }
        }

        private void FontCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontCbBox.Text != "" && SizeCbBox.Text != "")
            {
                TextPlace.SelectionFont = new Font(FontCbBox.Text, float.Parse(SizeCbBox.Text));
            }
        }

        private void SizeCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontCbBox.Text != "" && SizeCbBox.Text != "")
            {
                TextPlace.SelectionFont = new Font(FontCbBox.Text, float.Parse(SizeCbBox.Text));
            }
        }

        private void BoldBtn_Click(object sender, EventArgs e)
        {
            Font cur = TextPlace.SelectionFont ?? TextPlace.Font;
            FontStyle st = cur.Style ^ FontStyle.Bold;  
            TextPlace.SelectionFont = new Font(cur, st);
        }

        private void ItalicBtn_Click(object sender, EventArgs e)
        {
            Font cur = TextPlace.SelectionFont ?? TextPlace.Font;
            FontStyle st = cur.Style ^ FontStyle.Italic;
            TextPlace.SelectionFont = new Font(cur, st);
        }

        private void UnderlineBtn_Click(object sender, EventArgs e)
        {
            Font cur = TextPlace.SelectionFont ?? TextPlace.Font;
            FontStyle st = cur.Style ^ FontStyle.Underline;
            TextPlace.SelectionFont = new Font(cur, st);
        }
    }
}
