using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;

namespace Figuras_2D
{
    public partial class FrmStar : Form
    {
        private static FrmStar instancia;

        private Star star;

        private FrmStar()
        {
            InitializeComponent();
            btnGraficar.Click += btnGraficar_Click;
            PanelGrafico.Paint += PanelGrafico_Paint;
        }

        public static FrmStar Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmStar();
                }
                return instancia;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float tamanoCm))
                return;

            int tamanoPx = (int)(tamanoCm * 58f);

            PanelGrafico.Width = (tamanoPx * 2) + 20;
            PanelGrafico.Height = (tamanoPx * 2) + 20;

            int x = 10;
            int y = 10;

            star = new Star( x, y, tamanoPx, new Pen(Color.Black, 2), new SolidBrush(Color.Cyan));

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (star != null)
            {
                star.Draw(e.Graphics);
            }
        }

        private bool Validar(out float tamano)
        {
            tamano = 0;

            string input = txtTamano.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacío");
                return false;
            }

            if (!float.TryParse(input, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out tamano))
            {
                MessageBox.Show("Ingrese un número válido (use punto para decimales)");
                return false;
            }

            if (tamano <= 0)
            {
                MessageBox.Show("El valor debe ser mayor que 0");
                return false;
            }

            return true;
        }
    }
}