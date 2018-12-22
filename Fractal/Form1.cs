using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal {
    public partial class Form1 : Form {
        private static readonly int TIMER_INTERVAL = 2000;  // ms

        int nSierpinsky = Constants.SIERPINSKI_ITERS_DEFAULT;
        private List<Triangle> triangles;
        private bool sierpPlaying = false;
        private Timer sierpPlayTimer;
        private int currentSierpImage = 0;

        private static readonly bool SHOW_ALL_KOCH_ITRS_DEFAULT = false;
        int nFlakes = Constants.KOCH_ITERS_DEFAULT;
        private List<Flake> flakes;
        private bool kochPlaying = false;
        private Timer kochPlayTimer;
        private int currentKochImage = 0;

        public Form1() {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.White;

            textBoxSierpItrs.Text = nSierpinsky.ToString();

            textBoxKochItrs.Text = nFlakes.ToString();
            checkBoxKochAllIters.Checked = SHOW_ALL_KOCH_ITRS_DEFAULT;
        }

        private void startSierpPlayTimer() {
            if (sierpPlaying) stopSierpPlayTimer();
            if (kochPlaying) stopKochPlayTimer();
            if (triangles == null || triangles.Count == 0) {
                Utils.Utils.errMsg("There are no items to play");
                return;
            }
            pictureBox1.Image = triangles[currentSierpImage].Image;
            sierpPlayTimer = new Timer();
            sierpPlayTimer.Interval = TIMER_INTERVAL;
            sierpPlayTimer.Tick += new EventHandler(OnSierpTimerTick);
            sierpPlayTimer.Start();
            sierpPlaying = true;
            buttonSierpPlay.Text = "Pause";
        }

        private void resetSierpPlayTimer() {
            currentSierpImage = 0;
            stopSierpPlayTimer();
        }

        private void stopSierpPlayTimer() {
            if (sierpPlayTimer == null || !sierpPlayTimer.Enabled || !sierpPlaying) {
                //if (flakes != null && flakes.Count > 0) {
                //    pictureBox1.Image = flakes[flakes.Count - 1].Image;
                //}
                //buttonKochPlay.Text = "Play";
                sierpPlaying = false;
                return;
            }
            if (sierpPlayTimer != null && sierpPlayTimer.Enabled) {
                sierpPlayTimer.Stop();
            }
            //if (flakes != null && flakes.Count > 0) {
            //    pictureBox1.Image = flakes[flakes.Count - 1].Image;
            //}
            buttonSierpPlay.Text = "Play";
            sierpPlaying = false;
        }

        private void OnSierpTimerTick(object sender, EventArgs e) {
            if (++currentSierpImage >= triangles.Count) currentSierpImage = 0;
            pictureBox1.Image = triangles[currentSierpImage].Image;
        }

        private void startKochPlayTimer() {
            if (sierpPlaying) stopSierpPlayTimer();
            if (kochPlaying) stopKochPlayTimer();
            if (flakes == null || flakes.Count == 0) {
                Utils.Utils.errMsg("There are no items to play");
                return;
            }
            pictureBox1.Image = flakes[currentKochImage].Image;
            kochPlayTimer = new Timer();
            kochPlayTimer.Interval = TIMER_INTERVAL;
            kochPlayTimer.Tick += new EventHandler(OnKochTimerTick);
            kochPlayTimer.Start();
            kochPlaying = true;
            buttonKochPlay.Text = "Pause";
        }

        private void resetKochPlayTimer() {
            currentKochImage = 0;
            stopKochPlayTimer();
        }

        private void stopKochPlayTimer() {
            if (kochPlayTimer == null || !kochPlayTimer.Enabled || !kochPlaying) {
                //if (flakes != null && flakes.Count > 0) {
                //    pictureBox1.Image = flakes[flakes.Count - 1].Image;
                //}
                //buttonKochPlay.Text = "Play";
                kochPlaying = false;
                return;
            }
            if (kochPlayTimer != null && kochPlayTimer.Enabled) {
                kochPlayTimer.Stop();
            }
            //if (flakes != null && flakes.Count > 0) {
            //    pictureBox1.Image = flakes[flakes.Count - 1].Image;
            //}
            buttonKochPlay.Text = "Play";
            kochPlaying = false;
        }

        private void OnKochTimerTick(object sender, EventArgs e) {
            if (++currentKochImage >= flakes.Count) currentKochImage = 0;
            pictureBox1.Image = flakes[currentKochImage].Image;
        }

        private void OnSierpinskiClick(object sender, EventArgs e) {
            resetSierpPlayTimer();
            resetKochPlayTimer();
            int newNTriangles;
            if (Int32.TryParse(textBoxSierpItrs.Text, out newNTriangles)) {
                nSierpinsky = newNTriangles;
            }
            triangles = new List<Triangle>();
            bool showAllIters = checkBoxKochAllIters.Checked;
            pictureBox1.Image = null;
            int deep = nSierpinsky;
            int margin = 10;
            int width = pictureBox1.Width - 2 * margin;
            int height = (int)((Math.Round((double)pictureBox1.Width) - 2 * margin) * Constants.HW_RATIO);

            // Generate all the iterations
            for (int i = 0; i < nSierpinsky; i++) {
                Bitmap bmp = getBitmapForPictureBox(pictureBox1, margin, margin);
                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
                Triangle.SetupSierpinski(width, margin, margin, g, i);
                triangles.Add(new Triangle(bmp));
            }
            pictureBox1.Image = triangles[triangles.Count - 1].Image;
        }

        private void OnKochClick(object sender, EventArgs e) {
            resetSierpPlayTimer();
            resetKochPlayTimer();
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

        private void OnSierpPlayCkick(object sender, EventArgs e) {
            if (sierpPlaying) {
                stopSierpPlayTimer();
            } else {
                startSierpPlayTimer();
            }
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
