using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_2D.Transformaciones
{
    internal class Zoom
    {
        // Escalar λ
        public float Escalar { get; private set; }

        // Paso de crecimiento
        private float paso = 0.1f;

        // Límites
        private float max = 5.0f;
        private float min = 0.2f;

        // Constructor
        public Zoom()
        {
            Escalar = 1.0f;
        }

        // Aplicar zoom
        public void AplicarZoom(KeyEventArgs e)
        {
            // +
            if (e.KeyCode == Keys.Add ||
                e.KeyCode == Keys.Oemplus)
            {
                Escalar += paso;

                if (Escalar > max)
                {
                    Escalar = max;
                }
            }

            // -
            if (e.KeyCode == Keys.Subtract ||
                e.KeyCode == Keys.OemMinus)
            {
                Escalar -= paso;

                if (Escalar < min)
                {
                    Escalar = min;
                }
            }
        }
    }

}
