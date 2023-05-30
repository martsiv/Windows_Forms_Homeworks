using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lesson__GDI__
{
    internal class MyEllipse : IDrawable
    {
        private Rectangle ellipse;
        private Color color;
        private float size;

        public MyEllipse(Color color, float size)
        {
            this.color = color;
            this.size = size;
        }

        public void StartDrawing(Point startPoint)
        {
            ellipse.Location = startPoint;
            ellipse.Size = Size.Empty;
        }

        public void ContinueDrawing(Point nextPoint)
        {
            ellipse.Size = new Size(nextPoint.X - ellipse.Left, nextPoint.Y - ellipse.Top);
        }

        public void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(color, size))
            {
                graphics.DrawEllipse(pen, ellipse);
            }
        }
    }
}
