using System;
using System.Drawing;

namespace Figuras_2D.Transformaciones
{
    public static class Rotate
    {
        public static Point Rotar(
            Point punto,
            Point centro,
            float angulo
        )
        {
            // GRADOS A RADIANES
            double theta = angulo * Math.PI / 180.0;

            // TRASLADAR AL ORIGEN
            double x = punto.X - centro.X;

            double y = punto.Y - centro.Y;

            // ROTACIÓN ANTIHORARIA
            double xr =
                (x * Math.Cos(theta))
                - (y * Math.Sin(theta));

            double yr =
                (x * Math.Sin(theta))
                + (y * Math.Cos(theta));

            // REGRESAR A POSICIÓN ORIGINAL
            int xFinal = (int)(xr + centro.X);

            int yFinal = (int)(yr + centro.Y);

            return new Point(xFinal, yFinal);
        }
    }
}