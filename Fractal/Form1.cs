using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal {
    public partial class Form1 : Form {
        private static float HW_RATIO = (float)(Math.Sqrt(3.0)) / 2.0f;

        public Form1() {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.White;
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
            float height = HW_RATIO * width;
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
            int deep = 6;
            int margin = 10;
            int width = pictureBox1.Width - 2 * margin;
            int height = (int)((Math.Round((double)pictureBox1.Width) - 2 * margin) * HW_RATIO);
            Bitmap bmp = new Bitmap(width + 2 * margin, height + 2 * margin,
                      System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SetupSierpinski(width, margin, margin, g, deep);
            pictureBox1.Image = bmp;
        }

        private void OnQuitClick(object sender, EventArgs e) {
            Close();
        }
    }
}
