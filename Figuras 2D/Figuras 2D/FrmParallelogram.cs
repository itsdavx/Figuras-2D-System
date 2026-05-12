using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmParallelogram : Form
    {
        private static FrmParallelogram instancia;

        private Parallelogram paralelogramo;

        // clase de traslacion
        Traslation moverFigura = new Traslation(0, 0);

        private FrmParallelogram()
        {
            InitializeComponent();

            btnGraficar.Click += btnGraficar_Click;

            PanelGrafico.Paint += PanelGrafico_Paint;

            this.KeyPreview = true;

            this.KeyDown += FrmParallelogram_KeyDown;
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

        // mover figura con teclado
        private void FrmParallelogram_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            if (paralelogramo != null)
            {
                float baseCm = float.Parse(txtBase.Text);

                float alturaCm = float.Parse(txtAltura.Text);

                float offsetCm = float.Parse(txtOffset.Text);

                int b = (int)(baseCm * 58f);

                int h = (int)(alturaCm * 58f);

                int o = (int)(offsetCm * 58f);

                int extraIzq = o < 0 ? Math.Abs(o) : 0;

                int x = 10 + extraIzq + moverFigura.X;

                int y = 10 + moverFigura.Y;

                paralelogramo = new Parallelogram(
                    x,
                    y,
                    b,
                    h,
                    o,
                    new Pen(Color.Black, 2),
                    new SolidBrush(Color.Orange)
                );
            }

            PanelGrafico.Invalidate();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float baseCm, out float alturaCm, out float offsetCm))
                return;

            // conversion cm a px
            int b = (int)(baseCm * 58f);

            int h = (int)(alturaCm * 58f);

            int o = (int)(offsetCm * 58f);

            // ajustar panel
            int extraIzq = o < 0 ? Math.Abs(o) : 0;

            int extraDer = o > 0 ? o : 0;

            PanelGrafico.Width = b + extraIzq + extraDer + 20;

            PanelGrafico.Height = h + 20;

            // posicion inicial
            int x = 10 + extraIzq + moverFigura.X;

            int y = 10 + moverFigura.Y;

            paralelogramo = new Parallelogram(
                x,
                y,
                b,
                h,
                o,
                new Pen(Color.Black, 2),
                new SolidBrush(Color.Orange)
            );

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

            if (!float.TryParse(
                    sBase,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out b)
                ||
                !float.TryParse(
                    sAltura,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out h)
                ||
                !float.TryParse(
                    sOffset,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out o))
            {
                MessageBox.Show("Ingrese números válidos (use punto para decimales)");

                return false;
            }

            if (b <= 0 || h <= 0)
            {
                MessageBox.Show("Base y altura deben ser mayores que 0");

                return false;
            }

            return true;
        }

        private void FrmParallelogram_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}