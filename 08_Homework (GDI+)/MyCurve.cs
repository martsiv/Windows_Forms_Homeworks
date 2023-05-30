using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lesson__GDI__
{
    internal class MyCurve : IDrawable
    {
        private List<Point> points;
        private Color color;
        private float size;

        public MyCurve(Color color, float size)
        {
            points = new List<Point>();
            this.color = color;
            this.size = size;
        }

        public void StartDrawing(Point startPoint)
        {
            points.Clear();
            points.Add(startPoint);
        }

        public void ContinueDrawing(Point nextPoint)
        {
            points.Add(nextPoint);
        }

        public void Draw(Graphics graphics)
        {
            if (points.Count > 1)
            {
                using (Pen pen = new Pen(color, size))
                {
                    graphics.DrawCurve(pen, points.ToArray());
                }
            }
        }
    }
}
