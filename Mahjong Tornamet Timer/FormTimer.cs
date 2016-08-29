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
        private static long MAX_TIME = 7200;
        private long timeLeft = MAX_TIME;

        public formTimer()
        {
            InitializeComponent();
            labelTime.Font = new Font("Gang Of Three", 240, FontStyle.Regular);
            labelTime.Text = TimeSpan.FromSeconds(timeLeft).ToString();
            newProgressBarTimer.Maximum = (int)MAX_TIME;
        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnPause.Visible = false;
            btnPlay.Visible = true;
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
            newProgressBarTimer.Value = (int)(MAX_TIME - timeLeft);
            if (timeLeft == 0)
                timer.Stop();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
