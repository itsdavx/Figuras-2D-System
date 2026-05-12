using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_2D.Shapes;

namespace Figuras_2D.Transformaciones
{
    public class Rotate
    {
        private readonly Shape shape;
        private readonly Panel panel;

        public Rotate(Shape shape, Panel panel, Form form)
        {
            this.shape = shape;
            this.panel = panel;

            // Captura teclas del formulario
            form.KeyPreview = true;
            form.KeyDown += Form_KeyDown;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (shape == null)
                return;

            if (e.KeyCode == Keys.A)
            {
                shape.Rotation -= 5;
                panel.Invalidate();
            }
            else if (e.KeyCode == Keys.D)
            {
                shape.Rotation += 5;
                panel.Invalidate();
            }
        }
    }
}