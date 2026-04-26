using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Rhombus : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Diagonal1 { get; set; } // horizontal
        public int Diagonal2 { get; set; } // vertical

        public Rhombus(int x, int y, int diagonal1, int diagonal2, Pen pen, Brush brush)
            : base(pen, brush)
        {
            X = x;
            Y = y;
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override void Draw(Graphics g)
        {
            int mitadD1 = Diagonal1 / 2;
            int mitadD2 = Diagonal2 / 2;

            Point[] puntos = new Point[]
            {
                new Point(X + mitadD1, Y),                  // arriba
                new Point(X + Diagonal1, Y + mitadD2),      // derecha
                new Point(X + mitadD1, Y + Diagonal2),      // abajo
                new Point(X, Y + mitadD2)                   // izquierda
            };

            g.FillPolygon(Brush, puntos);
            g.DrawPolygon(Pen, puntos);
        }
    }
}