using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Diameter { get; set; }

        // Constructor
        public Circle(int x, int y, int diameter, Pen pen, Brush brush)
            : base(pen, brush)
        {
            X = x;
            Y = y;
            Diameter = diameter;
        }

        // Método que dibuja el círculo
        public override void Draw(Graphics g)
        {
            // Relleno
            g.FillEllipse(Brush, X, Y, Diameter, Diameter);

            // Borde
            g.DrawEllipse(Pen, X, Y, Diameter, Diameter);
        }
    }
}