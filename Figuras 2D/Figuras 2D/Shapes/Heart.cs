using System;
using System.Drawing;

namespace Figuras_2D.Shapes
{
    public class Heart : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Tamano { get; set; }

        public Heart(int x, int y, int tamano, Pen pen, Brush brush)
            : base(pen, brush)
        {
            X = x;
            Y = y;
            Tamano = tamano;
        }

        public override void Draw(Graphics g)
        {
            int cantidadPuntos = 200;
            Point[] puntos = new Point[cantidadPuntos];

            double escala = Tamano / 32.0;

            int centroX = X + Tamano / 2;
            int centroY = Y + Tamano / 2;

            for (int i = 0; i < cantidadPuntos; i++)
            {
                double t = i * 2 * Math.PI / cantidadPuntos;

                // Ecuación paramétrica del corazón
                double x = 16 * Math.Pow(Math.Sin(t), 3);
                double y = 13 * Math.Cos(t)
                         - 5 * Math.Cos(2 * t)
                         - 2 * Math.Cos(3 * t)
                         - Math.Cos(4 * t);

                int px = (int)(centroX + x * escala);
                int py = (int)(centroY - y * escala);

                puntos[i] = new Point(px, py);
            }

            g.FillPolygon(Brush, puntos);
            g.DrawPolygon(Pen, puntos);
        }
    }
}