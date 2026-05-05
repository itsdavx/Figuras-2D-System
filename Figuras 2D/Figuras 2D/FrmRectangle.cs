using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras_2D
{
    public partial class FrmRectangle : Form
    {
        private static FrmRectangle instancia;
        private double anchoDibujo, largoDibujo; // Añadido para almacenar dimensiones de dibujo
        public FrmRectangle()
        {
            InitializeComponent();

            pnlGrafico.Paint += pnlGrafico_Paint;
            pnlGrafico.Resize += pnlGrafico_Resize;
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

        private void FrmRectangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ancho, largo, perimetro, area;

            // Validación ancho
            if (!double.TryParse(txtAncho.Text, out ancho) || ancho <= 0)
            {
                MessageBox.Show("Ingrese un valor válido y positivo para el Ancho");
                txtAncho.Focus();
                return;
            }

            // Validación largo
            if (!double.TryParse(txtLargo.Text, out largo) || largo <= 0)
            {
                MessageBox.Show("Ingrese un valor válido y positivo para el Largo");
                txtLargo.Focus();
                return;
            }

            // Cálculos
            perimetro = 2 * (ancho + largo);
            area = ancho * largo;

            // Mostrar resultados
            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // Guardar para dibujo
            anchoDibujo = ancho;
            largoDibujo = largo;

            // Redibujar
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

        // Añadido: Implementación del método que faltaba
        private void DibujarRectangulo(double ancho, double largo)
        {
            // Guardar las dimensiones para que el Paint las use
            anchoDibujo = ancho;
            largoDibujo = largo;

            // Forzar repintado del panel
            if (pnlGrafico != null)
                pnlGrafico.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Limpiar variables del dibujo
            anchoDibujo = 0;
            largoDibujo = 0;

            // Limpiar cajas de texto
            txtAncho.Clear();
            txtLargo.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            // Limpiar panel gráfico
            pnlGrafico.Refresh();

            // Regresar cursor al inicio
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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 2);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(120, Color.LightBlue));

                float margen = 20;

                float panelW = pnlGrafico.Width - 2 * margen;
                float panelH = pnlGrafico.Height - 2 * margen;

                float wReal = (float)anchoDibujo;
                float hReal = (float)largoDibujo;

                // ESCALA BASE
                float escala = Math.Min(panelW / wReal, panelH / hReal);

                // CONTROL PARA QUE SE NOTE EL TAMAÑO
                float escalaMax = 5f;   // evita que todo se vea gigante
                escala = Math.Min(escala, escalaMax);

                // ajuste visual (opcional pero recomendado)
                escala *= 0.8f;

                // Aplicar escala
                float w = wReal * escala;
                float h = hReal * escala;

                // CENTRADO
                float x = (pnlGrafico.Width - w) / 2;
                float y = (pnlGrafico.Height - h) / 2;

                // Dibujar
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

