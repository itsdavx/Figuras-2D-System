using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;

namespace Figuras_2D
{
    public partial class FrmRhombus : Form
    {
        private static FrmRhombus instancia;

        private Rhombus rhombus;

        private FrmRhombus()
        {
            InitializeComponent();
            btnGraficar.Click += btnGraficar_Click;
            PanelGrafico.Paint += PanelGrafico_Paint;
        }

        public static FrmRhombus Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmRhombus();
                }
                return instancia;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float diagonal1Cm, out float diagonal2Cm))
                return;

            int d1 = (int)(diagonal1Cm * 58f);
            int d2 = (int)(diagonal2Cm * 58f);

            PanelGrafico.Width = d1 + 20;
            PanelGrafico.Height = d2 + 20;

            int x = 10;
            int y = 10;

            rhombus = new Rhombus( x, y, d1, d2, new Pen(Color.Black, 2), new SolidBrush(Color.Blue));

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (rhombus != null)
            {
                rhombus.Draw(e.Graphics);
            }
        }

        private bool Validar(out float d1, out float d2)
        {
            d1 = d2 = 0;

            string sD1 = txtDiagonal1.Text.Trim();
            string sD2 = txtDiagonal2.Text.Trim();

            if (string.IsNullOrEmpty(sD1) || string.IsNullOrEmpty(sD2))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return false;
            }

            if (!float.TryParse(sD1, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out d1) ||
                !float.TryParse(sD2, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out d2))
            {
                MessageBox.Show("Ingrese números válidos (use punto para decimales)");
                return false;
            }

            if (d1 <= 0 || d2 <= 0)
            {
                MessageBox.Show("Las diagonales deben ser mayores que 0");
                return false;
            }

            return true;
        }
    }
}