using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmRhombus : Form
    {
        private static FrmRhombus instancia;

        private Rhombus rhombus;

        // clase de traslacion
        private Traslation moverFigura;

        private FrmRhombus()
        {
            InitializeComponent();

            btnGraficar.Click += btnGraficar_Click;

            PanelGrafico.Paint += PanelGrafico_Paint;

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += FrmRhombus_KeyDown;
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

        // mover figura con teclado
        private void FrmRhombus_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            if (rhombus != null)
            {
                float diagonal1Cm =
                    float.Parse(txtDiagonal1.Text);

                float diagonal2Cm =
                    float.Parse(txtDiagonal2.Text);

                int d1 = (int)(diagonal1Cm * 58f);

                int d2 = (int)(diagonal2Cm * 58f);

                rhombus = new Rhombus(
                    10 + moverFigura.X,
                    10 + moverFigura.Y,
                    d1,
                    d2,
                    new Pen(Color.Black, 2),
                    new SolidBrush(Color.Blue)
                );
            }

            PanelGrafico.Invalidate();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float diagonal1Cm,
                         out float diagonal2Cm))
                return;

            int d1 = (int)(diagonal1Cm * 58f);

            int d2 = (int)(diagonal2Cm * 58f);

            PanelGrafico.Width = d1 + 20;

            PanelGrafico.Height = d2 + 20;

            int x = 10 + moverFigura.X;

            int y = 10 + moverFigura.Y;

            rhombus = new Rhombus(
                x,
                y,
                d1,
                d2,
                new Pen(Color.Black, 2),
                new SolidBrush(Color.Blue)
            );

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

            if (string.IsNullOrEmpty(sD1) ||
                string.IsNullOrEmpty(sD2))
            {
                MessageBox.Show("Todos los campos son obligatorios");

                return false;
            }

            if (!float.TryParse(
                    sD1,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out d1)
                ||
                !float.TryParse(
                    sD2,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out d2))
            {
                MessageBox.Show("Ingrese numeros validos");

                return false;
            }

            if (d1 <= 0 || d2 <= 0)
            {
                MessageBox.Show("Las diagonales deben ser mayores que 0");

                return false;
            }

            return true;
        }

        private void FrmRhombus_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}