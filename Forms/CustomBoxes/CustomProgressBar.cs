using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_0._0.Forms.CustomBoxes
{
    public partial class CustomProgressBar : ProgressBar
    {
        private Color progressBarColor = Color.Green;

        [Category("Appearance")]
        [Description("Sets the color of the progress bar.")]
        public Color ProgressBarColor
        {
            get { return progressBarColor; }
            set
            {
                progressBarColor = value;
                Invalidate();
            }
        }

        public CustomProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;

            // Draw the background
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                g.FillRectangle(brush, rect);
            }

            // Draw the progress bar
            float fraction = (float)Value / Maximum;
            int width = (int)(rect.Width * fraction);

            using (SolidBrush brush = new SolidBrush(progressBarColor))
            {
                g.FillRectangle(brush, 0, 0, width, rect.Height);
            }
        }
    }
}
