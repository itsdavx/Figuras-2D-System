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
    public partial class FrmDecagon : Form

    {
        private double ladoDibujo = 0; // Variable para almacenar el lado para el dibujo
        private static FrmDecagon instancia;
        public FrmDecagon()
        {
            InitializeComponent();
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado, perimetro, area;

            // Validar campo vacío
            if (txtLado.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el valor del lado.",
                                "Dato requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtLado.Focus();
                return;
            }

            // Validar número
            if (!double.TryParse(txtLado.Text, out lado))
            {
                MessageBox.Show("Ingrese solo números válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLado.Clear();
                txtLado.Focus();
                return;
            }

            // Validar positivo
            if (lado <= 0)
            {
                MessageBox.Show("El lado debe ser mayor que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtLado.Focus();
                return;
            }

            // Cálculos
            perimetro = 10 * lado;
            area = (10 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 10));

            // Mostrar resultados
            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // Guardar para dibujo
            ladoDibujo = lado;

            // Dibujar
            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (ladoDibujo > 0)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 3);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(100, Color.LightBlue));

                int lados = 10;
                PointF[] puntos = new PointF[lados];

                float margen = 20;

                // Radio automático según tamaño del panel
                float radio = Math.Min(pnlGrafico.Width, pnlGrafico.Height) / 2 - margen;

                float centroX = pnlGrafico.Width / 2;
                float centroY = pnlGrafico.Height / 2;

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
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Reiniciar variable global
            ladoDibujo = 0;

            // Limpiar cajas
            txtLado.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            // Limpiar gráfico
            pnlGrafico.Refresh();

            // Cursor al inicio
            txtLado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDecagon_Load(object sender, EventArgs e)
        {

        }
    }
}
