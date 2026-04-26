using System;
using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Hexagon : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Lado { get; set; }

        public Hexagon(int x, int y, int lado, Pen pen, Brush brush)
            : base(pen, brush)
        {
            X = x;
            Y = y;
            Lado = lado;
        }

        public override void Draw(Graphics g)
        {
            Point[] puntos = new Point[6];

            double angulo = -Math.PI / 2; // inicia arriba
            double incremento = 2 * Math.PI / 6;

            int radio = Lado;

            int centroX = X + radio;
            int centroY = Y + radio;

            for (int i = 0; i < 6; i++)
            {
                int px = (int)(centroX + radio * Math.Cos(angulo));
                int py = (int)(centroY + radio * Math.Sin(angulo));

                puntos[i] = new Point(px, py);
                angulo += incremento;
            }

            g.FillPolygon(Brush, puntos);
            g.DrawPolygon(Pen, puntos);
        }
    }
}