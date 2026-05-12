using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Circle : Shape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Diameter { get; set; }

        public Circle(
            int x,
            int y,
            int diameter,
            Pen pen,
            Brush brush
        ) : base(pen, brush)
        {
            X = x;

            Y = y;

            Diameter = diameter;
        }

        public override void Draw(Graphics g)
        {

            g.FillEllipse(
                Brush,
                X,
                Y,
                Diameter,
                Diameter
            );

            g.DrawEllipse(
                Pen,
                X,
                Y,
                Diameter,
                Diameter
            );
        }
    }
}