namespace Bai5
{
    public partial class Form2 : Form
    {
        public SinhVien svMoi { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            svMoi = new SinhVien()
            {
                MaSV = MSVBox.Text,
                TenSV = TenSVBox.Text,
                Khoa = KhoaCbBox.Text,
                DiemTB = double.Parse(DTBBox.Text)
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
