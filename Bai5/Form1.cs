namespace Bai5
{
    public partial class Form1 : Form
    {
        private List<SinhVien> ds = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            DsSVView.Rows.Clear();

            int stt = 1;
            foreach (var sv in ds)
            {
                DsSVView.Rows.Add(
                    stt++,
                    sv.MaSV,
                    sv.TenSV,
                    sv.Khoa,
                    sv.DiemTB
                );
            }
        }

        private void AddMenuBtn_Click(object sender, EventArgs e)
        {
            Form2 AddForm = new Form2();
            if (AddForm.ShowDialog() == DialogResult.OK)
            {
                ds.Add(AddForm.svMoi);
                HienThi();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchMenuBx_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = SearchMenuBx.Text.ToLower();
            var kq = ds.Where(ten => ten.TenSV.ToLower().Contains(tukhoa)).ToList();
            DsSVView.Rows.Clear();
            int stt = 1;
            foreach (var sv in kq)
            {
                DsSVView.Rows.Add(
                    stt++,
                    sv.MaSV,
                    sv.TenSV,
                    sv.Khoa,
                    sv.DiemTB
                );
            }
        }
    }
}
