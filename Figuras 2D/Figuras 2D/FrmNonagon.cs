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
        private double ladoDibujo = 0; // Variable para almacenar el lado para el dibujo
        private static FrmNonagon instancia;
        public FrmNonagon()
        {
            InitializeComponent();
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

            // Fórmulas
            perimetro = 9 * lado;
            area = (9 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 9));

            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // Guardar para dibujo
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

                Pen lapiz = new Pen(Color.Blue, 3);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(100, Color.LightBlue));

                int lados = 9;
                PointF[] puntos = new PointF[lados];

                float radio = (float)ladoDibujo * 5;

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

            // Limpiar cajas de texto
            txtLado.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            // Limpiar panel gráfico
            pnlGrafico.Refresh();

            // Colocar cursor en el primer campo
            txtLado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNonagon_Load(object sender, EventArgs e)
        {

        }
    }
}
