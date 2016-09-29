using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mahjong_Tornamet_Timer
{
    public partial class MainForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int DEFAULT_MAXTIME = 7200;
        private const int DEFAULT_MINIMIZED_FONTSIZE = 240;
        private const int DEFAULT_MAXIMIZED_FONTSIZE = 360;

        private int fontSize = DEFAULT_MINIMIZED_FONTSIZE;
        private long maxTime = DEFAULT_MAXTIME;
        private long timeLeft = DEFAULT_MAXTIME;
        private int roundNum = 1;

        public MainForm()
        {
            InitializeComponent();
            lblTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
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
            numUpDown.Select(0, numUpDown.Value.ToString().Length);
            Button confirmation = new Button() { Text = "Ok", Left = 120, Width = 60, Top = 90, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(numUpDown);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? (int)numUpDown.Value : 0;
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
            btnChangeMaxTime.Visible = false;
            btnReset.Visible = false;
            btnZoomIn.Visible = false;
            btnZoomOut.Visible = false;
            btnMinimize.Visible = false;
            btnMaximize.Visible = false;
            btnExit.Visible = false;
            btnRoundUp.Visible = false;
            btnRoundDown.Visible = false;
            btnLblTimeUp.Visible = false;
            btnLblTimeRight.Visible = false;
            btnLblTimeDown.Visible = false;
            btnLblTimeLeft.Visible = false;
            btnLogoSettings.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnPause.Visible = false;
            btnPlay.Visible = true;
            btnChangeMaxTime.Visible = true;
            btnReset.Visible = true;
            btnZoomIn.Visible = true;
            btnZoomOut.Visible = true;
            btnMinimize.Visible = true;
            btnMaximize.Visible = true;
            btnExit.Visible = true;
            btnRoundUp.Visible = true;
            btnRoundDown.Visible = true;
            btnLblTimeUp.Visible = true;
            btnLblTimeRight.Visible = true;
            btnLblTimeDown.Visible = true;
            btnLblTimeLeft.Visible = true;
            btnLogoSettings.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timeLeft = maxTime;
            lblTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
            lblTime.ForeColor = Color.FromArgb(64, 64, 64);
            newProgressBarTimer.Maximum = (int)maxTime;
            newProgressBarTimer.Value = 0;
            if (btnReplay.Visible == true)
            {
                btnReplay.Visible = false;
                btnPlay.Visible = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
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
                btnChangeMaxTime.Visible = true;
                btnReset.Visible = true;
                btnZoomIn.Visible = true;
                btnZoomOut.Visible = true;
                btnMinimize.Visible = true;
                btnMaximize.Visible = true;
                btnExit.Visible = true;
                btnRoundUp.Visible = true;
                btnRoundDown.Visible = true;
                btnLblTimeUp.Visible = true;
                btnLblTimeRight.Visible = true;
                btnLblTimeDown.Visible = true;
                btnLblTimeLeft.Visible = true;
                btnLogoSettings.Visible = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnChangeMaxTime_Click(object sender, EventArgs e)
        {
            int minutos = ShowDialog("Remaining time", "Enter remaining time in minutes:", (int)(maxTime / 60));
            if (minutos <= 0) return;
            maxTime = minutos * 60;
            btnReset_Click(null, null);
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

        private void btnLblTimeUp_Click(object sender, EventArgs e)
        {
            lblTime.Location = new Point(lblTime.Location.X, lblTime.Location.Y - 1);
        }

        private void btnLblTimeRight_Click(object sender, EventArgs e)
        {
            lblTime.Location = new Point(lblTime.Location.X + 1, lblTime.Location.Y);
        }

        private void btnLblTimeDown_Click(object sender, EventArgs e)
        {
            lblTime.Location = new Point(lblTime.Location.X, lblTime.Location.Y + 1);
        }

        private void btnLblTimeLeft_Click(object sender, EventArgs e)
        {
            lblTime.Location = new Point(lblTime.Location.X - 1, lblTime.Location.Y);
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
                fontSize = DEFAULT_MAXIMIZED_FONTSIZE;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.BackgroundImage = Mahjong_Tournament_Timer.
                    Properties.Resources.icon_maximize;
                fontSize = DEFAULT_MINIMIZED_FONTSIZE;
            }
            lblTime.Font = new Font("Gang Of Three", fontSize, FontStyle.Regular);
        }

        private void btnRoundUp_Click(object sender, EventArgs e)
        {
            if (roundNum + 1 <= int.MaxValue)
            {
                roundNum++;
                lblRoundNum.Text = roundNum.ToString();
            }
        }

        private void btnRoundDown_Click(object sender, EventArgs e)
        {
            if (roundNum - 1 > 0)
            {
                roundNum--;
                lblRoundNum.Text = roundNum.ToString();
            }
        }

        private void imgMMLogo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.mahjongmadrid.com/");
            Process.Start(sInfo);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    btnMaximize.BackgroundImage = Mahjong_Tournament_Timer.
                        Properties.Resources.icon_maximize;
                    fontSize = DEFAULT_MINIMIZED_FONTSIZE;
                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogoSetting_Click(object sender, EventArgs e)
        {
            string picturePath = string.Empty;

            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select a 150 x 150px picture";
            fDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            fDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (fDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            picturePath = fDialog.FileName.ToString();
            imgMMLogo.BackgroundImage = Image.FromFile(picturePath);
        }
    }
}
