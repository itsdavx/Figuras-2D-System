using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmDecagon : Form
    {
        private double ladoDibujo = 0;

        private static FrmDecagon instancia;

        private Traslation moverFigura;

        public FrmDecagon()
        {
            InitializeComponent();

            moverFigura = new Traslation(0, 0);

            this.KeyPreview = true;

            this.KeyDown += FrmDecagon_KeyDown;
        }

        public static FrmDecagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmDecagon();
                }

                return instancia;
            }
        }

        private void FrmDecagon_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            pnlGrafico.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado, perimetro, area;

            // validar campo vacio
            if (txtLado.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el valor del lado.",
                                "Dato requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtLado.Focus();

                return;
            }

            // validar numero
            if (!double.TryParse(txtLado.Text, out lado))
            {
                MessageBox.Show("Ingrese solo numeros validos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtLado.Clear();

                txtLado.Focus();

                return;
            }

            // validar positivo
            if (lado <= 0)
            {
                MessageBox.Show("El lado debe ser mayor que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtLado.Focus();

                return;
            }

            // calculos
            perimetro = 10 * lado;

            area = (10 * Math.Pow(lado, 2)) /
                   (4 * Math.Tan(Math.PI / 10));

            // mostrar resultados
            txtPerimetro.Text = perimetro.ToString("N2");

            txtArea.Text = area.ToString("N2");

            // guardar para dibujo
            ladoDibujo = lado;

            // dibujar
            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (ladoDibujo > 0)
            {
                Graphics g = e.Graphics;

                g.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 2);

                SolidBrush brocha =
                    new SolidBrush(Color.FromArgb(120, Color.LightBlue));

                int lados = 10;

                PointF[] puntos = new PointF[lados];

                float margen = 20;

                float panelW = pnlGrafico.Width - 2 * margen;

                float panelH = pnlGrafico.Height - 2 * margen;

                // radio basado en el lado real
                float radioReal =
                    (float)(ladoDibujo /
                    (2 * Math.Sin(Math.PI / lados)));

                // escala para que quepa en el panel
                float escala =
                    Math.Min(panelW, panelH) / (2 * radioReal);

                // limitar escala
                escala = Math.Min(escala, 5f);

                escala *= 0.9f;

                float radio = radioReal * escala;

                float centroX =
                    (pnlGrafico.Width / 2) + moverFigura.X;

                float centroY =
                    (pnlGrafico.Height / 2) + moverFigura.Y;

                for (int i = 0; i < lados; i++)
                {
                    double angulo =
                        (2 * Math.PI * i / lados) - Math.PI / 2;

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

            // limpiar grafico
            pnlGrafico.Refresh();

            // cursor al inicio
            txtLado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDecagon_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}