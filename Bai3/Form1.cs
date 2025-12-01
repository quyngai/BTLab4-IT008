namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TimeCheck.Interval = 1000;
            TimeCheck.Tick += TimeCheck_Tick;
            TimeCheck.Start();

            toolStripStatusLabel1.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            UpdateTimeLabel();
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Media Files|*.avi;*.mpeg;*.mp4;*.wav;*.mp3;*.midi;*.wma;*.mkv|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
                axWindowsMediaPlayer1.uiMode = "full";
                axWindowsMediaPlayer1.settings.autoStart = true;
            }
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimeCheck_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            toolStripStatusLabel1.Text = $"Hôm nay là ngày {DateTime.Now:dd/MM/yyyy} - Bây giờ là {DateTime.Now:HH:mm:ss}";
        }
    }
}