using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Lesson__GDI__
{
    internal interface IDrawable
    {
        void Draw(Graphics graphics);
        void StartDrawing(Point startPoint);
        void ContinueDrawing(Point nextPoint);
    }
}
