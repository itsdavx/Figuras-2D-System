using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_2D.Transformaciones
{
    internal class Traslation
    {
        // Posicion en la que se encuentra la figura
        public int X { get; set; }
        public int Y { get; set; }

        // pasos que se movera la figura cada vez que se pulse una tecla
        private int paso = 10;

        // Constructor
        public Traslation(int xInicial, int yInicial)
        {
            X = xInicial;
            Y = yInicial;
        }

        // Método para mover con teclado
        public void Mover(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Y -= paso;
            }

            if (e.KeyCode == Keys.Down)
            {
                Y += paso;
            }

            if (e.KeyCode == Keys.Left)
            {
                X -= paso;
            }

            if (e.KeyCode == Keys.Right)
            {
                X += paso;
            }
        }
    }
}