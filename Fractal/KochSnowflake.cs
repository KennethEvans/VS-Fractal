using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fractal {
    public class KochSegment {
        protected PointF p1;
        protected PointF p2;

        public KochSegment(float x1, float y1, float x2, float y2) {
            p1 = new PointF(x1, y1);
            p2 = new PointF(x2, y2);
        }

        public List<KochSegment> NextSegments() {
            const double rangle = -60 * Math.PI / 180.0;
            List<KochSegment> newSegments = new List<KochSegment>();
            double length = Length / 3;
            double a = Math.Atan2(Height, Width);
            a = a + rangle;
            PointF p1 = new PointF(P1.X + Width / 3,
                P1.Y + Height / 3);
            PointF p2 = new PointF(P1.X + Width * 2 / 3,
                P1.Y + Height * 2 / 3);
            KochSegment cutSeg = new KochSegment(p1.X, p1.Y, p2.X, p2.Y);
            PointF p = new PointF((int)(cutSeg.P1.X + length * Math.Cos(a)),
                (int)(cutSeg.P1.Y + length * Math.Sin(a)));
            newSegments.Add(new KochSegment(P1.X, P1.Y, p1.X, p1.Y));
            newSegments.Add(new KochSegment(p1.X, p1.Y, p.X, p.Y));
            newSegments.Add(new KochSegment(p.X, p.Y, p2.X, p2.Y));
            newSegments.Add(new KochSegment(p2.X, p2.Y, P2.X, P2.Y));
            return newSegments;
        }

        public PointF P1 { get { return p1; } set { p1 = value; } }

        public PointF P2 { get { return p2; } set { p2 = value; } }

        public float Height { get { return p2.Y - p1.Y; } }

        public float Width { get { return p2.X - p1.X; } }

        public double Length { get { return Math.Sqrt(Height * Height + Width * Width); } }
    }

    public class Flake : IImage {
        private static FractalTimer<Flake> timer = new FractalTimer<Flake>();
        private const double rangle = -60 * Math.PI / 180.0;
        private Pen pen;
        private Image image;
        private List<KochSegment> segments;

        public Image Image { get => image; set => image = value; }
        public Pen Pen { get => pen; set => pen = value; }
        public List<KochSegment> Segments { get => segments; set => segments = value; }
        internal static FractalTimer<Flake> Timer { get => timer; set => timer = value; }

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
            segments = new List<KochSegment>();
            // Go clockwise
            segments.Add(new KochSegment(x0, y0, x0 + side, y0));
            segments.Add(new KochSegment(x0 + side, y0, x0 + mid, y0 + height));
            segments.Add(new KochSegment(x0 + mid, y0 + height, x0, y0));
        }

        public Flake(Pen pen, List<KochSegment> segments) {
            this.pen = pen;
            this.segments = segments;
        }

        public void Draw(Graphics gr) {
            foreach (KochSegment seg in segments) {
                gr.DrawLine(pen, seg.P1, seg.P2);
            }
        }

        public List<KochSegment> NextSegments() {
            List<KochSegment> newSegments = new List<KochSegment>();
            foreach (KochSegment seg in segments) {
                newSegments.AddRange(seg.NextSegments());
            }
            return newSegments;
        }
    }
}
