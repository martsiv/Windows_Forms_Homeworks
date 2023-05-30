using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lesson__GDI__
{
    internal class MyPoint : IDrawable
    {
        private Point point;
        private Color color;
        private float size;

        public MyPoint(Color color, float size)
        {
            this.color = color;
            this.size = size;
        }

        public void StartDrawing(Point startPoint)
        {
            point = startPoint;
        }

        public void ContinueDrawing(Point nextPoint)
        {
            // Не використовується для MyPoint
        }

        public void Draw(Graphics graphics)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                graphics.FillEllipse(brush, point.X - size / 2, point.Y - size / 2, size, size);
            }
        }
    }
}
