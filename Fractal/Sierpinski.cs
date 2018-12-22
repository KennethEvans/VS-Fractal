using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractal {
    public class SierpinskiTriangle {
        private PointF p1;
        private PointF p2;
        private PointF p3;

        public SierpinskiTriangle(float x1, float y1, float x2, float y2, float x3, float y3) {
            p1 = new PointF(x1, y1);
            p2 = new PointF(x2, y2);
            p3 = new PointF(x3, y3);
        }

        public List<SierpinskiTriangle> NextTriangles() {
            const double rangle = -60 * Math.PI / 180.0;
            List<SierpinskiTriangle> newTriangles = new List<SierpinskiTriangle>();
            // Midpoints of the sides: 
            float xMa = (p2.X + p3.X) / 2, yMa = (p2.Y + p3.Y) / 2;
            float xMb = (p1.X + p3.X) / 2, yMb = (p1.Y + p3.Y) / 2;
            float xMc = (p1.X + p2.X) / 2, yMc = (P1.Y + P2.Y) / 2;



            //double length = Length / 3;
            //double a = Math.Atan2(Height, Width);
            //a = a + rangle;
            //PointF p1 = new PointF(P1.X + Width / 3,
            //    P1.Y + Height / 3);
            //PointF p2 = new PointF(P1.X + Width * 2 / 3,
            //    P1.Y + Height * 2 / 3);
            //KochSegment cutSeg = new KochSegment(p1.X, p1.Y, p2.X, p2.Y);
            //PointF p = new PointF((int)(cutSeg.P1.X + length * Math.Cos(a)),
            //    (int)(cutSeg.P1.Y + length * Math.Sin(a)));
            //newSegments.Add(new KochSegment(P1.X, P1.Y, p1.X, p1.Y));
            //newSegments.Add(new KochSegment(p1.X, p1.Y, p.X, p.Y));
            //newSegments.Add(new KochSegment(p.X, p.Y, p2.X, p2.Y));
            //newSegments.Add(new KochSegment(p2.X, p2.Y, P2.X, P2.Y));
            //return newSegments;
            return newTriangles;
        }

        protected PointF P1 { get => p1; set => p1 = value; }
        protected PointF P2 { get => p2; set => p2 = value; }
        protected PointF P3 { get => p3; set => p3 = value; }
    }

    public class Triangle {
        private Image image;

        public Triangle(Image image) {
            this.image = image;
        }

        /// <summary>
        /// Sets up the initial triangle and calls Sierpinski with given deep.
        /// </summary>
        /// <param name="width">Width of the triangle.</param>
        /// <param name="x">Offset from sides.</param>
        /// <param name="y">Offset from bottom.</param>
        /// <param name="g">Graphics to use to draw.</param>
        /// <param name="deep">Number of iterations. 0 is filled triangle.</param>
        public static void SetupSierpinski(float width, int x, int y, Graphics g, int deep) {
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
        public static void Sierpinski(float xA, float yA, float xB, float yB,
            float xC, float yC, Graphics g, int deep) {
            if (deep > 0) {
                deep--;

                // Midpoints of the sides: 
                float xMa = (xB + xC) / 2, yMa = (yB + yC) / 2;
                float xMb = (xA + xC) / 2, yMb = (yA + yC) / 2;
                float xMc = (xA + xB) / 2, yMc = (yA + yB) / 2;

                float mod = (xMa - xMb) * (xMa - xMb) + (yMa - yMb) * (yMa - yMb);
                if (mod > 1) {
                    Sierpinski(xA, yA, xMb, yMb, xMc, yMc, g, deep);
                    Sierpinski(xMc, yMc, xMa, yMa, xB, yB, g, deep);
                    Sierpinski(xMb, yMb, xMa, yMa, xC, yC, g, deep);
                } else {
                    throw new Exception("Reached pixel limit for creating new triangle");
                }
            } else {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                PointF P1 = new PointF(xA, yA);
                PointF P2 = new PointF(xB, yB);
                PointF P3 = new PointF(xC, yC);
                PointF[] Points = new PointF[] { P1, P2, P3 };
                g.FillPolygon(Brushes.Black, Points);
            }
        }

        public Image Image { get => image; set => image = value; }
    }
}
