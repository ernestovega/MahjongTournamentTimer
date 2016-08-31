using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mahjong_Tornamet_Timer
{
    public partial class formTimer : Form
    {
        private int fontSize;
        private long maxTime;
        private long timeLeft;

        public formTimer()
        {
            InitializeComponent();
            fontSize = 240;
            lblTime.Font = new Font("Gang Of Three", fontSize, FontStyle.Regular);
            lblRound.Font = new Font("Gang Of Three", 50, FontStyle.Regular);
            txtbxRound.Font = new Font("Gang Of Three", 50, FontStyle.Regular);
            maxTime = 7200;
            timeLeft = maxTime;
            lblTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
            newProgressBarTimer.Maximum = (int)maxTime;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelTime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnPlay.Visible = false;
            btnPause.Visible = true;
            btnSettings.Visible = false;
            btnReset.Visible = false;
            btnZoomIn.Visible = false;
            btnZoomOut.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnPause.Visible = false;
            btnPlay.Visible = true;
            btnSettings.Visible = true;
            btnReset.Visible = true;
            btnZoomIn.Visible = true;
            btnZoomOut.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timeLeft = maxTime;
            lblTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
            lblTime.ForeColor = Color.FromArgb(64, 64, 64);
            newProgressBarTimer.Value = 0;
            if (btnReplay.Visible == true)
            {
                btnReplay.Visible = false;
                btnPlay.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
            newProgressBarTimer.Value = (int)(maxTime - timeLeft);
            if(timeLeft == 900 && maxTime >= 3600)
            {
                lblTime.ForeColor = Color.Red;
                
            }
            if (timeLeft <= 0)
            {
                timer.Stop();
                btnPause.Visible = false;
                btnPlay.Visible = true;
                btnReplay.Visible = true;
                btnSettings.Visible = true;
                btnReset.Visible = true;
                btnZoomIn.Visible = true;
                btnZoomOut.Visible = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            int minutos = ShowDialog("Remaining time", "Enter remaining time in minutes:", (int)(maxTime / 60));
            if (minutos <= 0) return;
            maxTime = minutos * 60;
            btnReset_Click(null, null);
        }

        public static int ShowDialog(string title, string message, int value)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 170,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                BackColor = Color.White,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 25, Top = 43, Width = 180, Text = message };
            NumericUpDown numUpDown = new NumericUpDown() { Left = 190, Top = 40, Width = 60 };
            numUpDown.Maximum = 1440;
            numUpDown.Minimum = 1;
            numUpDown.Value = value;
            Button confirmation = new Button() { Text = "Ok", Left = 120, Width = 60, Top = 90, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(numUpDown);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? (int)numUpDown.Value : 0;
        }

        private void txtbxRound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//If Enter pressed, hide caret
            {
                txtbxRound.Enabled = false;
                txtbxRound.Enabled = true;
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            fontSize = fontSize < 395 ? fontSize + 5 : fontSize;
            lblTime.Font = new Font("Gang Of Three", fontSize, FontStyle.Regular);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {

            fontSize = fontSize > 5 ? fontSize - 5 : fontSize;
            lblTime.Font = new Font("Gang Of Three", fontSize, FontStyle.Regular);
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            btnReset_Click(null, null);
            btnPlay_Click(null, null);
            btnReplay.Visible = false;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.BackgroundImage = Mahjong_Tournament_Timer.
                    Properties.Resources.icon_normalize;
                fontSize = 360;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.BackgroundImage = Mahjong_Tournament_Timer.
                    Properties.Resources.icon_maximize;
                fontSize = 240;
            }
            lblTime.Font = new Font("Gang Of Three", fontSize, FontStyle.Regular);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
