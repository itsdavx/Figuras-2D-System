using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Parallelogram : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
        public int Offset { get; set; } // inclinación

        public Parallelogram(int x, int y, int baseLen, int height, int offset, Pen pen, Brush brush) : base(pen, brush)
        {
            X = x;
            Y = y;
            Base = baseLen;
            Height = height;
            Offset = offset;
        }

        public override void Draw(Graphics g)
        {
            Point[] puntos = new Point[]
            {
                new Point(X + Offset, Y),              // arriba izquierda
                new Point(X + Base + Offset, Y),       // arriba derecha
                new Point(X + Base, Y + Height),       // abajo derecha
                new Point(X, Y + Height)               // abajo izquierda
            };

            g.FillPolygon(Brush, puntos);
            g.DrawPolygon(Pen, puntos);
        }
    }
}