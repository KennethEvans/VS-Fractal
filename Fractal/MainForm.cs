﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal {
    public partial class MainForm : Form {
        int nSierpinsky = Constants.SIERPINSKI_ITERS_DEFAULT;
        private List<Triangle> triangles;

        private static readonly bool SHOW_ALL_KOCH_ITRS_DEFAULT = false;
        int nFlakes = Constants.KOCH_ITERS_DEFAULT;
        private List<Flake> flakes;

        public MainForm() {
            InitializeComponent();

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.White;

            textBoxSierpItrs.Text = nSierpinsky.ToString();

            textBoxKochItrs.Text = nFlakes.ToString();
            checkBoxKochAllIters.Checked = SHOW_ALL_KOCH_ITRS_DEFAULT;
        }

        private void OnSierpinskiClick(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            if (Triangle.Timer != null) {
                Triangle.Timer.resetTimer();
            }
            if (Flake.Timer != null) {
                Flake.Timer.resetTimer();
            }
            int newNTriangles;
            if (Int32.TryParse(textBoxSierpItrs.Text, out newNTriangles)) {
                nSierpinsky = newNTriangles;
            }
            triangles = new List<Triangle>();
            Triangle.Timer = new FractalTimer<Triangle>(triangles, pictureBox, buttonSierpPlay);
            bool showAllIters = checkBoxKochAllIters.Checked;
            pictureBox.Image = null;
            int deep = nSierpinsky;
            int margin = 10;
            int width = pictureBox.Width - 2 * margin;
            int height = (int)((Math.Round((double)pictureBox.Width) - 2 * margin) * Constants.HW_RATIO);

            // Generate all the iterations
            for (int i = 0; i <= nSierpinsky; i++) {
                Bitmap bmp = getBitmapForPictureBox(pictureBox, margin, margin);
                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
                try {
                    Triangle.SetupSierpinski(width, margin, margin, g, i);
                } catch (Exception ex) {
                    Utils.Utils.warnMsg("Iteration " + i + ":\n" +
                        ex.Message);
                    break;
                }
                triangles.Add(new Triangle(bmp));
            }
            pictureBox.Image = triangles[triangles.Count - 1].Image;
            Cursor.Current = Cursors.Default;
        }

        private void OnKochClick(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            if (Triangle.Timer != null) {
                Triangle.Timer.resetTimer();
            }
            if (Flake.Timer != null) {
                Flake.Timer.resetTimer();
            }
            int newNFlakes;
            if (Int32.TryParse(textBoxKochItrs.Text, out newNFlakes)) {
                nFlakes = newNFlakes;
            }
            // Start Calculation
            bool showAllIters = checkBoxKochAllIters.Checked;
            flakes = new List<Flake>();
            Flake.Timer = new FractalTimer<Flake>(flakes, pictureBox, buttonKochPlay);
            int margin = 10;
            int width = pictureBox.Width - 2 * margin;
            int height = (int)((Math.Round((double)pictureBox.Width) - margin - margin) * Constants.HW_RATIO);
            Bitmap bmp = getBitmapForPictureBox(pictureBox, margin, margin);
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
                    bmp = getBitmapForPictureBox(pictureBox, margin, margin);
                    g = Graphics.FromImage(bmp);
                    g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
                }
                newFlake.Image = bmp;
                newFlake.Draw(Graphics.FromImage(bmp));
                oldFlake = newFlake;
            }
            pictureBox.Image = flakes[flakes.Count - 1].Image;
            Cursor.Current = Cursors.Default;
        }

        private Bitmap getBitmapForPictureBox(PictureBox pictureBox, int x0, int y0) {
            int width = this.pictureBox.Width - x0 - y0;
            int height = (int)((Math.Round((double)this.pictureBox.Width) - x0 - y0) * Constants.HW_RATIO);
            Bitmap bmp = new Bitmap(width + x0 + y0, height + x0 + y0,
                     System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            return bmp;
        }

        private void OnQuitClick(object sender, EventArgs e) {
            Close();
        }

        private void OnSierpPlayCkick(object sender, EventArgs e) {
            if (Flake.Timer.Playing) {
                Flake.Timer.stopTimer();
            }
            if (Triangle.Timer.Playing) {
                Triangle.Timer.stopTimer();
            } else {
                Triangle.Timer.startTimer();
            }
        }

        private void OnKochPlayCkick(object sender, EventArgs e) {
            if (Triangle.Timer.Playing) {
                Triangle.Timer.stopTimer();
            }
            if (Flake.Timer.Playing) {
                Flake.Timer.stopTimer();
            } else {
                Flake.Timer.startTimer();
            }
        }
    }
}
