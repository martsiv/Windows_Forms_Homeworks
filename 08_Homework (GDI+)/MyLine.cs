using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lesson__GDI__
{
    internal class MyLine : IDrawable
    {
        private Point startPoint;
        private Point endPoint;
        private Color color;
        private float size;

        public MyLine(Color color, float size)
        {
            this.color = color;
            this.size = size;
        }

        public void StartDrawing(Point startPoint)
        {
            this.startPoint = startPoint;
        }

        public void ContinueDrawing(Point nextPoint)
        {
            endPoint = nextPoint;
        }

        public void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(color, size))
            {
                graphics.DrawLine(pen, startPoint, endPoint);
            }
        }
    }
}
