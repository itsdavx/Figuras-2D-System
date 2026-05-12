using Figuras_2D.Transformaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_2D
{
    public partial class FrmNonagon : Form
    {
        private double ladoDibujo = 0;

        private static FrmNonagon instancia;

        // clase de traslacion
        Traslation moverFigura = new Traslation(0, 0);

        public FrmNonagon()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += FrmNonagon_KeyDown;
        }

        public static FrmNonagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmNonagon();
                }
                return instancia;
            }
        }

        // mover figura con teclado
        private void FrmNonagon_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            pnlGrafico.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado, perimetro, area;

            if (!double.TryParse(txtLado.Text, out lado) || lado <= 0)
            {
                MessageBox.Show("Ingrese un valor válido y positivo para el lado.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLado.Focus();
                return;
            }

            // formulas
            perimetro = 9 * lado;
            area = (9 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 9));

            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // guardar para dibujo
            ladoDibujo = lado;

            pnlGrafico.Invalidate();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (ladoDibujo > 0)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 2);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(120, Color.LightBlue));

                int lados = 9;
                PointF[] puntos = new PointF[lados];

                float margen = 20;

                float panelW = pnlGrafico.Width - 2 * margen;
                float panelH = pnlGrafico.Height - 2 * margen;

                float ladoReal = (float)ladoDibujo;

                // calcular radio base
                float radioBase = ladoReal / (2 * (float)Math.Sin(Math.PI / lados));

                // escala automatica
                float escala = Math.Min(panelW / (2 * radioBase), panelH / (2 * radioBase));

                // control de escala
                float escalaMax = 5f;
                escala = Math.Min(escala, escalaMax);

                escala *= 0.8f;

                float radio = radioBase * escala;

                float centroX = pnlGrafico.Width / 2 + moverFigura.X;
                float centroY = pnlGrafico.Height / 2 + moverFigura.Y;

                for (int i = 0; i < lados; i++)
                {
                    double angulo = (2 * Math.PI * i / lados) - Math.PI / 2;

                    puntos[i] = new PointF(
                        centroX + radio * (float)Math.Cos(angulo),
                        centroY + radio * (float)Math.Sin(angulo)
                    );
                }

                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);

                lapiz.Dispose();
                brocha.Dispose();
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // reiniciar variable
            ladoDibujo = 0;

            // limpiar cajas
            txtLado.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            // limpiar panel
            pnlGrafico.Refresh();

            // regresar posicion
            moverFigura = new Traslation(0, 0);

            txtLado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNonagon_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}