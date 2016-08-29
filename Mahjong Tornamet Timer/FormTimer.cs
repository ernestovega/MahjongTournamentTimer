using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahjong_Tornamet_Timer
{
    public partial class formTimer : Form
    {
        private long maxTime;
        private long timeLeft;

        public formTimer()
        {
            InitializeComponent();
            labelTime.Font = new Font("Gang Of Three", 240, FontStyle.Regular);
            lblRound.Font = new Font("Gang Of Three", 50, FontStyle.Regular);
            txtbxRound.Font = new Font("Gang Of Three", 50, FontStyle.Regular);
            maxTime = 7200;
            timeLeft = maxTime;
            labelTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
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
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnPause.Visible = false;
            btnPlay.Visible = true;
            btnSettings.Visible = true;
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timeLeft = 7200;
            labelTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
            newProgressBarTimer.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            labelTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
            newProgressBarTimer.Value = (int)(maxTime - timeLeft);
            if (timeLeft == 0)
                timer.Stop();
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
            if (minutos == 1440) maxTime--;
            timeLeft = maxTime;
            newProgressBarTimer.Maximum = (int)maxTime;
            newProgressBarTimer.Value = 0;
            labelTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
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
    }
}
