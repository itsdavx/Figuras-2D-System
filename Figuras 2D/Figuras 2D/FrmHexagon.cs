using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;

namespace Figuras_2D
{
    public partial class FrmHexagon : Form
    {
        private static FrmHexagon instancia;

        private Hexagon hexagon;

        private FrmHexagon()
        {
            InitializeComponent();
            btnGraficar.Click += btnGraficar_Click;
            PanelGrafico.Paint += PanelGrafico_Paint;
        }

        public static FrmHexagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmHexagon();
                }
                return instancia;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float ladoCm))
                return;

            int ladoPx = (int)(ladoCm * 58f);

            PanelGrafico.Width = (ladoPx * 2) + 20;
            PanelGrafico.Height = (ladoPx * 2) + 20;

            int x = 10;
            int y = 10;

            hexagon = new Hexagon(x, y, ladoPx, new Pen(Color.Black, 2), new SolidBrush(Color.Orange));

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (hexagon != null)
            {
                hexagon.Draw(e.Graphics);
            }
        }

        private bool Validar(out float lado)
        {
            lado = 0;

            string input = txtLado.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacío");
                return false;
            }

            if (!float.TryParse(input, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out lado))
            {
                MessageBox.Show("Ingrese un número válido (use punto para decimales)");
                return false;
            }

            if (lado <= 0)
            {
                MessageBox.Show("El valor debe ser mayor que 0");
                return false;
            }

            return true;
        }
    }
}