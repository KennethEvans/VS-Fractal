using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal {
    public partial class Form1 : Form {
        private static readonly bool SHOW_ALL_KOCH_ITRS_DEFAULT = false;
        private List<Flake> flakes;
        int nFlakes = Constants.KOCH_ITERS_DEFAULT;
        private static readonly int KOCH_TIMER_INTERVAL = 2000;  // ms
        private bool kochPlaying = false;
        private Timer kochPlayTimer;
        private int currentKochImage = 0;

        public Form1() {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.White;
            textBoxKochItrs.Text = nFlakes.ToString();
            checkBoxKochAllIters.Checked = SHOW_ALL_KOCH_ITRS_DEFAULT;
        }

        private void startKochPlayTimer() {
            if (kochPlaying) stopKochPlayTimer();
            if (flakes == null || flakes.Count == 0) {
                Utils.Utils.errMsg("There are no items to play");
                return;
            }
            currentKochImage = 0;
            pictureBox1.Image = flakes[0].Image;
            kochPlayTimer = new Timer();
            kochPlayTimer.Interval = KOCH_TIMER_INTERVAL;
            kochPlayTimer.Tick += new EventHandler(OnKochTimerTick);
            kochPlayTimer.Start();
            kochPlaying = true;
            buttonKochPlay.Text = "Pause";
        }

        private void stopKochPlayTimer() {
            if (kochPlayTimer == null || !kochPlayTimer.Enabled || !kochPlaying) {
                if (flakes != null && flakes.Count > 0) {
                    pictureBox1.Image = flakes[flakes.Count - 1].Image;
                }
                buttonKochPlay.Text = "Play";
                kochPlaying = false;
                return;
            }
            if (kochPlayTimer != null && kochPlayTimer.Enabled) {
                kochPlayTimer.Stop();
            }
            if (flakes != null && flakes.Count > 0) {
                pictureBox1.Image = flakes[flakes.Count - 1].Image;
                pictureBox1.Image = flakes[flakes.Count - 1].Image;
            }
            buttonKochPlay.Text = "Play";
            kochPlaying = false;
        }

        private void OnKochTimerTick(object sender, EventArgs e) {
            if (++currentKochImage >= flakes.Count) currentKochImage = 0;
            pictureBox1.Image = flakes[currentKochImage].Image;
        }

        /// <summary>
        /// Sets up the initial triangle and calls Sierpinski with given deep.
        /// </summary>
        /// <param name="width">Width of the triangle.</param>
        /// <param name="x">Offset from sides.</param>
        /// <param name="y">Offset from bottom.</param>
        /// <param name="g">Graphics to use to draw.</param>
        /// <param name="deep">Number of iterations. 0 is filled triangle.</param>
        private void SetupSierpinski(float width, int x, int y, Graphics g, int deep) {
            // Height of equilateral triangle
            float height = Constants.HW_RATIO * width;
            // Bottom-left
            int xA = x, yA = y;
            // Bottom-right
            int xB = (int)(x + width), yB = y;
            // TRop-center (of equilateral triangle)
            int xC = (int)(x + width / 2.0f), yC = (int)(y + height);

            Sierpinski(xA, yA, xB, yB, xC, yC, g, deep);
        }

        /// <summary>
        /// Recursively fills the triangles.
        /// </summary>
        /// <param name="xA">Value of x at bottom left.</param>
        /// <param name="yA">Value of y at bottom left.</param>
        /// <param name="xB">Value of x at bottom right.</param>
        /// <param name="yB">Value of y at bottom right.</param>
        /// <param name="xC">Value of x at top of triangle.</param>
        /// <param name="yC">Value of x at top of triangle.</param>
        /// <param name="g">Graphics to use to draw.</param>
        /// <param name="deep">Number of iterations</param>
        private void Sierpinski(float xA, float yA, float xB, float yB,
            float xC, float yC, Graphics g, int deep) {
            if (deep > 0) {
                deep--;

                // Midpoints of the sides: 
                float xMa = (xB + xC) / 2, yMa = (yB + yC) / 2;
                float xMb = (xA + xC) / 2, yMb = (yA + yC) / 2;
                float xMc = (xA + xB) / 2, yMc = (yA + yB) / 2;

                Sierpinski(xA, yA, xMb, yMb, xMc, yMc, g, deep);
                Sierpinski(xMc, yMc, xMa, yMa, xB, yB, g, deep);
                Sierpinski(xMb, yMb, xMa, yMa, xC, yC, g, deep);
            } else {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                PointF P1 = new PointF(xA, yA);
                PointF P2 = new PointF(xB, yB);
                PointF P3 = new PointF(xC, yC);
                PointF[] Points = new PointF[] { P1, P2, P3 };
                g.FillPolygon(Brushes.Black, Points);
            }
        }

        private void OnSierpinskiClick(object sender, EventArgs e) {
            stopKochPlayTimer();
            pictureBox1.Image = null;
            int deep = 6;
            int margin = 10;
            int width = pictureBox1.Width - 2 * margin;
            int height = (int)((Math.Round((double)pictureBox1.Width) - 2 * margin) * Constants.HW_RATIO);
            Bitmap bmp = getBitmapForPictureBox(pictureBox1, margin, margin);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SetupSierpinski(width, margin, margin, g, deep);
            pictureBox1.Image = bmp;
        }

        private void OnKochClick(object sender, EventArgs e) {
            stopKochPlayTimer();
            int newNFlakes;
            if (Int32.TryParse(textBoxKochItrs.Text, out newNFlakes)) {
                nFlakes = newNFlakes;
            }
            bool showAllIters = checkBoxKochAllIters.Checked;
            flakes = new List<Flake>();
            pictureBox1.Image = null;
            int margin = 10;
            int width = pictureBox1.Width - 2 * margin;
            int height = (int)((Math.Round((double)pictureBox1.Width) - margin - margin) * Constants.HW_RATIO);
            Bitmap bmp = getBitmapForPictureBox(pictureBox1, margin, margin);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
            float scale = .75f;
            float flakeWidth = width * scale;
            float flakeHeight = 4f / 3f * flakeWidth * Constants.HW_RATIO;
            Flake oldFlake = new Flake(bmp, new Pen(Color.Black),
                flakeWidth,
                margin + .5f * (width - flakeWidth),
                margin + flakeHeight / 4f);
            flakes.Add(oldFlake);
            oldFlake.Draw(g);
            Flake newFlake = null;
            for (int i = 0; i < nFlakes; i++) {
                newFlake = new Flake(oldFlake.Pen, oldFlake.NextSegments());
                flakes.Add(newFlake);
                if (!showAllIters) {
                    bmp = getBitmapForPictureBox(pictureBox1, margin, margin);
                    g = Graphics.FromImage(bmp);
                    g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
                }
                newFlake.Image = bmp;
                newFlake.Draw(Graphics.FromImage(bmp));
                oldFlake = newFlake;
            }
            pictureBox1.Image = flakes[flakes.Count - 1].Image;
        }

        private Bitmap getBitmapForPictureBox(PictureBox pictureBox, int x0, int y0) {
            int width = pictureBox1.Width - x0 - y0;
            int height = (int)((Math.Round((double)pictureBox1.Width) - x0 - y0) * Constants.HW_RATIO);
            Bitmap bmp = new Bitmap(width + x0 + y0, height + x0 + y0,
                     System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            return bmp;
        }

        private void OnQuitClick(object sender, EventArgs e) {
            Close();
        }

        private void OnKochPlayCkick(object sender, EventArgs e) {
            if (kochPlaying) {
                stopKochPlayTimer();
            } else {
                startKochPlayTimer();
            }
        }
    }
}
