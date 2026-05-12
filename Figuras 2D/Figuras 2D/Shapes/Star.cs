using System;
using System.Drawing;
using Figuras_2D.Transformaciones;

namespace Figuras_2D.Shapes
{
    public class Star : Shape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Tamano { get; set; }

        public Star(
            int x,
            int y,
            int tamano,
            Pen pen,
            Brush brush
        ) : base(pen, brush)
        {
            X = x;

            Y = y;

            Tamano = tamano;
        }

        public override void Draw(Graphics g)
        {
            Point[] puntos = new Point[10];

            double angulo = -Math.PI / 2;

            double incremento = Math.PI / 5;

            int radioExterno = Tamano;

            int radioInterno = Tamano / 2;

            int centroX = X + radioExterno;

            int centroY = Y + radioExterno;

            Point centro = new Point(
                centroX,
                centroY
            );

            for (int i = 0; i < 10; i++)
            {
                int radio =
                    (i % 2 == 0)
                    ? radioExterno
                    : radioInterno;

                int px =
                    (int)(
                        centroX
                        + radio * Math.Cos(angulo)
                    );

                int py =
                    (int)(
                        centroY
                        + radio * Math.Sin(angulo)
                    );

                Point puntoOriginal = new Point(px, py);

                // ROTAR PUNTO
                puntos[i] = Rotate.Rotar(
                    puntoOriginal,
                    centro,
                    Rotation
                );

                angulo += incremento;
            }

            g.FillPolygon(Brush, puntos);

            g.DrawPolygon(Pen, puntos);
        }
    }
}