using Figuras_2D.Transformaciones;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_2D
{
    public partial class FrmRectangle : Form
    {
        private static FrmRectangle instancia;

        private double anchoDibujo, largoDibujo;

        // clase de traslacion
        private Traslation moverFigura;

        public FrmRectangle()
        {
            InitializeComponent();

            pnlGrafico.Paint += pnlGrafico_Paint;
            pnlGrafico.Resize += pnlGrafico_Resize;

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += FrmRectangle_KeyDown;
        }

        public static FrmRectangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmRectangle();
                }
                return instancia;
            }
        }

        // mover figura con teclado
        private void FrmRectangle_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            pnlGrafico.Invalidate();
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ancho, largo, perimetro, area;

            // validacion ancho
            if (!double.TryParse(txtAncho.Text, out ancho) || ancho <= 0)
            {
                MessageBox.Show("Ingrese un valor valido y positivo para el ancho");
                txtAncho.Focus();
                return;
            }

            // validacion largo
            if (!double.TryParse(txtLargo.Text, out largo) || largo <= 0)
            {
                MessageBox.Show("Ingrese un valor valido y positivo para el largo");
                txtLargo.Focus();
                return;
            }

            // calculos
            perimetro = 2 * (ancho + largo);
            area = ancho * largo;

            // mostrar resultados
            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // guardar para dibujo
            anchoDibujo = ancho;
            largoDibujo = largo;

            // redibujar
            pnlGrafico.Invalidate();
        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DibujarRectangulo(double ancho, double largo)
        {
            anchoDibujo = ancho;
            largoDibujo = largo;

            if (pnlGrafico != null)
                pnlGrafico.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            anchoDibujo = 0;
            largoDibujo = 0;

            txtAncho.Clear();
            txtLargo.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            pnlGrafico.Refresh();

            txtAncho.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (anchoDibujo > 0 && largoDibujo > 0)
            {
                Graphics g = e.Graphics;

                g.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 2);

                SolidBrush brocha =
                    new SolidBrush(
                        Color.FromArgb(120, Color.LightBlue));

                float margen = 20;

                float panelW =
                    pnlGrafico.Width - 2 * margen;

                float panelH =
                    pnlGrafico.Height - 2 * margen;

                float wReal = (float)anchoDibujo;

                float hReal = (float)largoDibujo;

                // escala base
                float escala =
                    Math.Min(panelW / wReal,
                             panelH / hReal);

                // control de escala
                float escalaMax = 5f;

                escala = Math.Min(escala, escalaMax);

                escala *= 0.8f;

                // aplicar escala
                float w = wReal * escala;

                float h = hReal * escala;

                // centrado con traslacion
                float x =
                    ((pnlGrafico.Width - w) / 2)
                    + moverFigura.X;

                float y =
                    ((pnlGrafico.Height - h) / 2)
                    + moverFigura.Y;

                // dibujar
                g.FillRectangle(brocha, x, y, w, h);

                g.DrawRectangle(lapiz, x, y, w, h);

                lapiz.Dispose();

                brocha.Dispose();
            }
        }

        private void pnlGrafico_Resize(object sender, EventArgs e)
        {
            pnlGrafico.Invalidate();
        }
    }
}