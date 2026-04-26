using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Ellipse : Shape

    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Eje1 { get; set; }
        public int Eje2 { get; set; }

        // Constructor
        public Ellipse(int x, int y, int eje1, int eje2, Pen pen, Brush brush)
            : base(pen, brush)
        {
            X = x;
            Y = y;
            Eje1 = eje1;
            Eje2 = eje2;
        }
        public override void Draw(Graphics g)
        {
            // Relleno
            g.FillEllipse(Brush, X, Y, Eje1, Eje2);

            // Borde
            g.DrawEllipse(Pen, X, Y, Eje1, Eje2);
        }
    }
}
