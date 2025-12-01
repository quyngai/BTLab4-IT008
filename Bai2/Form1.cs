namespace Bai2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        string time = "";
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            time = DateTime.Now.ToString("dddd , MMM dd , yyyy hh:mm:ss tt");
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 14 , FontStyle.Regular);
            Brush b = Brushes.Black;
            SizeF textSize = g.MeasureString(time, f);
            float x = (this.ClientSize.Width - textSize.Width) / 2;
            float y = (this.ClientSize.Height - textSize.Height) / 2;

            g.DrawString(time, f, b, x, y);
        }
    }
}
