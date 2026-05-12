using System;
using System.Drawing;
using Figuras_2D.Transformaciones;

namespace Figuras_2D.Shapes
{
    public class Ellipse : Shape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Eje1 { get; set; }

        public int Eje2 { get; set; }

        public Ellipse(
            int x,
            int y,
            int eje1,
            int eje2,
            Pen pen,
            Brush brush
        ) : base(pen, brush)
        {
            X = x;

            Y = y;

            Eje1 = eje1;

            Eje2 = eje2;
        }

        public override void Draw(Graphics g)
        {
            Point[] puntos = new Point[360];

            int centroX = X + (Eje1 / 2);

            int centroY = Y + (Eje2 / 2);

            Point centro = new Point(
                centroX,
                centroY
            );

            for (int i = 0; i < 360; i++)
            {
                double rad =
                    i * Math.PI / 180;

                int px =
                    (int)(
                        centroX
                        + (Eje1 / 2)
                        * Math.Cos(rad)
                    );

                int py =
                    (int)(
                        centroY
                        + (Eje2 / 2)
                        * Math.Sin(rad)
                    );

                Point original =
                    new Point(px, py);

                puntos[i] = Rotate.Rotar(
                    original,
                    centro,
                    Rotation
                );
            }

            g.FillPolygon(
                Brush,
                puntos
            );

            g.DrawPolygon(
                Pen,
                puntos
            );
        }
    }
}