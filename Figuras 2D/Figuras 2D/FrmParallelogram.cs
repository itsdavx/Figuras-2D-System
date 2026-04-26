using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;

namespace Figuras_2D
{
    public partial class FrmParallelogram : Form
    {
        private static FrmParallelogram instancia;

        private Parallelogram paralelogramo;

        private FrmParallelogram()
        {
            InitializeComponent();
            btnGraficar.Click += btnGraficar_Click;
            PanelGrafico.Paint += PanelGrafico_Paint;
        }

        public static FrmParallelogram Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmParallelogram();
                }
                return instancia;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float baseCm, out float alturaCm, out float offsetCm))
                return;

            // Conversión cm a px
            int b = (int)(baseCm * 58f);
            int h = (int)(alturaCm * 58f);
            int o = (int)(offsetCm * 58f);

            // Ajustar tamaño del panel
            int extraIzq = o < 0 ? Math.Abs(o) : 0;
            int extraDer = o > 0 ? o : 0;

            PanelGrafico.Width = b + extraIzq + extraDer + 20;
            PanelGrafico.Height = h + 20;

            // Posición inicial compensando offset negativo
            int x = 10 + extraIzq;
            int y = 10;

            paralelogramo = new Parallelogram(x, y, b, h, o, new Pen(Color.Black, 2), new SolidBrush(Color.Orange));

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (paralelogramo != null)
            {
                paralelogramo.Draw(e.Graphics);
            }
        }

        private bool Validar(out float b, out float h, out float o)
        {
            b = h = o = 0;

            string sBase = txtBase.Text.Trim();
            string sAltura = txtAltura.Text.Trim();
            string sOffset = txtOffset.Text.Trim();

            if (string.IsNullOrEmpty(sBase) ||
                string.IsNullOrEmpty(sAltura) ||
                string.IsNullOrEmpty(sOffset))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return false;
            }

            if (!float.TryParse(sBase, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out b) ||
                !float.TryParse(sAltura, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out h) ||
                !float.TryParse(sOffset, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out o))
            {
                MessageBox.Show("Ingrese números válidos (use punto para decimales)");
                return false;
            }

            if (b <= 0 || h <= 0)
            {
                MessageBox.Show("Base y altura deben ser mayores que 0");
                return false;
            }

            // offset puede ser negativo (permite inclinación a la izquierda)
            return true;
        }
    }
}