using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractal {
    public class Segment {
        protected PointF p1;
        protected PointF p2;

        public Segment(float x1, float y1, float x2, float y2) {
            p1 = new PointF(x1, y1);
            p2 = new PointF(x2, y2);
        }

        public PointF P1 { get { return p1; } set { p1 = value; } }

        public PointF P2 { get { return p2; } set { p2 = value; } }

        public float Height { get { return p2.Y - p1.Y; } }

        public float Width { get { return p2.X - p1.X; } }

        public double Length { get { return Math.Sqrt(Height * Height + Width * Width); } }
    }

    public class Flake {
        private const double rangle = -60 * Math.PI / 180.0;
        private Pen pen;
        private Image image;
        private List<Segment> segments;

        public Image Image { get => image; set => image = value; }
        public Pen Pen { get => pen; set => pen = value; }
        public List<Segment> Segments { get => segments; set => segments = value; }

        /// <summary>
        /// Constructor that generates a triangle flake.
        /// </summary>
        /// <param name="pen"></param>
        /// <param name="side">Length of a side</param>
        public Flake(Image image, Pen pen, float side, float x0, float y0) {
            this.image = image;
            this.pen = pen;
            float mid = side / 2f;
            float height = Constants.HW_RATIO * side;
            segments = new List<Segment>();
            // Go clockwise
            segments.Add(new Segment(x0, y0, x0 + side, y0));
            segments.Add(new Segment(x0 + side, y0, x0 + mid, y0 + height));
            segments.Add(new Segment(x0 + mid, y0 + height, x0, y0));
        }

        public Flake(Pen pen, List<Segment> segments) {
            this.pen = pen;
            this.segments = segments;
        }

        public void Draw(Graphics gr) {
            foreach (Segment seg in segments) {
                gr.DrawLine(pen, seg.P1, seg.P2);
            }
        }

        public List<Segment> NextSegments() {
            List<Segment> newSegments = new List<Segment>();

            foreach (Segment seg in segments) {
                double length = seg.Length / 3;
                double a = Math.Atan2(seg.Height, seg.Width);
                a = a + rangle;
                PointF p1 = new PointF(seg.P1.X + seg.Width / 3,
                    seg.P1.Y + seg.Height / 3);
                PointF p2 = new PointF(seg.P1.X + seg.Width * 2 / 3,
                    seg.P1.Y + seg.Height * 2 / 3);
                Segment cutSeg = new Segment(p1.X, p1.Y, p2.X, p2.Y);
                PointF p = new PointF((int)(cutSeg.P1.X + length * Math.Cos(a)),
                    (int)(cutSeg.P1.Y + length * Math.Sin(a)));
                newSegments.Add(new Segment(seg.P1.X, seg.P1.Y, p1.X, p1.Y));
                newSegments.Add(new Segment(p1.X, p1.Y, p.X, p.Y));
                newSegments.Add(new Segment(p.X, p.Y, p2.X, p2.Y));
                newSegments.Add(new Segment(p2.X, p2.Y, seg.P2.X, seg.P2.Y));
            }
            return newSegments;
        }
    }
}
