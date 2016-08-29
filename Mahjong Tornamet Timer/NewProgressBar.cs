using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahjong_Tournament_Timer
{
    public class NewProgressBar : ProgressBar
    {
        public NewProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(96, 96, 96)), 0, 0, rec.Width, rec.Height);
        }
    }
}
