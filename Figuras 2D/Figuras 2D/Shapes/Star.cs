using System;
using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Star : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Tamano { get; set; }

        public Star(int x, int y, int tamano, Pen pen, Brush brush)
            : base(pen, brush)
        {
            X = x;
            Y = y;
            Tamano = tamano;
        }

        public override void Draw(Graphics g)
        {
            Point[] puntos = new Point[10];

            double angulo = -Math.PI / 2;
            double incremento = Math.PI / 5; // 36 grados

            int radioExterno = Tamano;
            int radioInterno = Tamano / 2;

            int centroX = X + radioExterno;
            int centroY = Y + radioExterno;

            for (int i = 0; i < 10; i++)
            {
                int radio = (i % 2 == 0) ? radioExterno : radioInterno;

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