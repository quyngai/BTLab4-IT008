namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show($"Ban vua click chuot trai tai : ({x} , {y})");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show($"Ban vua click chuot phai tai : ({x} , {y})");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show($"Thong tin nut vua bam:\n" +
                $"Keycode: {e.KeyChar}\n" +
                $"Ma ASCII: {(int)e.KeyChar}");
        }
    }
}
