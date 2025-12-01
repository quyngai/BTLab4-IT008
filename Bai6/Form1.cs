namespace Bai6
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void DesLinkBtn_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DesLinkBox.Text = fbd.SelectedPath;
            }
        }

        private async void CopyBtn_Click(object sender, EventArgs e)
        {
            string src = SrcLinkBox.Text;
            string des = DesLinkBox.Text;

            if (string.IsNullOrWhiteSpace(src) || !Directory.Exists(src))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!");
                return;
            }
            if (string.IsNullOrWhiteSpace(des))
            {
                MessageBox.Show("Vui lòng chọn thư mục đích!");
                return;
            }
            if (!Directory.Exists(des))
            {
                Directory.CreateDirectory(des);
            }

            try
            {
                string[] allFiles = Directory.GetFiles(src, "*.*", SearchOption.AllDirectories);

                progressBar1.Value = 0;
                progressBar1.Maximum = allFiles.Length;

                foreach (string file in allFiles)
                {
                    string relativePath = file.Substring(src.Length + 1); 
                    string desFilePath = Path.Combine(des, relativePath);

                    string desDir = Path.GetDirectoryName(desFilePath);
                    if (!Directory.Exists(desDir))
                    {
                        Directory.CreateDirectory(desDir);
                    }

                    DetailLabel.Text = "Đang sao chép: " + Path.GetFileName(file);
                    await CopyFileWithProgress(file, desFilePath);

                    progressBar1.Value++;
                }

                DetailLabel.Text = "Hoàn thành!";
                MessageBox.Show("Sao chép hoàn tất!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private async Task CopyFileWithProgress(string source, string dest)
        {
            const int bufferSize = 81920;
            byte[] buffer = new byte[bufferSize];
            int bytesRead;

            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (FileStream destStream = new FileStream(dest, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                while ((bytesRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await destStream.WriteAsync(buffer, 0, bytesRead);

                }
            }
        }

        private void SrcLinkBtn_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                SrcLinkBox.Text = fbd.SelectedPath;
            }
        }
    }
}
