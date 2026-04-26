using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuras_2D.Shapes
{
    public abstract class Shape
    {
        public Pen Pen { get; set; }
        public Brush Brush { get; set; }

        // Constructor
        protected Shape(Pen pen, Brush brush)
        {
            Pen = pen;
            Brush = brush;
        }

        // Método abstracto para que cada figura implemente su forma de dibujarse
        public abstract void Draw(Graphics g);
    }
}