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
    public partial class FrmScaleneTriangle : Form
    {
        private double ladoADibujo = 0;
        private double ladoBDibujo = 0;
        private double ladoCDibujo = 0;
        private static FrmScaleneTriangle instancia;
        public FrmScaleneTriangle()
        {
            InitializeComponent();
        }

        public static FrmScaleneTriangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmScaleneTriangle();
                }
                return instancia;
            }
        }

        private void lblLadoB_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;
            double perimetro, area, s;

            // Validar campos vacíos
            if (txtLadoA.Text.Trim() == "" ||
                txtLadoB.Text.Trim() == "" ||
                txtLadoC.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los tres lados.",
                                "Dato requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validar números
            if (!double.TryParse(txtLadoA.Text, out ladoA) ||
                !double.TryParse(txtLadoB.Text, out ladoB) ||
                !double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("Ingrese solo números válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validar positivos
            if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
            {
                MessageBox.Show("Los lados deben ser mayores que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validar que sean diferentes (Escaleno)
            if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                MessageBox.Show("En un triángulo escaleno los tres lados deben ser diferentes.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validar existencia del triángulo
            if (ladoA + ladoB <= ladoC ||
                ladoA + ladoC <= ladoB ||
                ladoB + ladoC <= ladoA)
            {
                MessageBox.Show("Los valores ingresados no forman un triángulo válido.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Cálculos
            perimetro = ladoA + ladoB + ladoC;

            s = perimetro / 2;

            area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // Guardar para dibujo
            ladoADibujo = ladoA;
            ladoBDibujo = ladoB;
            ladoCDibujo = ladoC;

            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (ladoADibujo > 0 && ladoBDibujo > 0 && ladoCDibujo > 0)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 3);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(100, Color.LightBlue));

                // Escala moderada
                float escala = 12;

                float a = (float)ladoADibujo * escala; // base
                float b = (float)ladoBDibujo * escala;
                float c = (float)ladoCDibujo * escala;

                // Base hacia la derecha
                float inicioX = 50;
                float baseY = pnlGrafico.Height - 40;

                PointF p1 = new PointF(inicioX, baseY);
                PointF p2 = new PointF(inicioX + a, baseY);

                // Coordenada real del tercer vértice
                float x3 = (b * b - c * c + a * a) / (2 * a);
                float y3 = (float)Math.Sqrt((b * b) - (x3 * x3));

                // Punto arriba (escaleno real)
                PointF p3 = new PointF(inicioX + x3, baseY - y3);

                PointF[] puntos = { p1, p2, p3 };

                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Reiniciar variables
            ladoADibujo = 0;
            ladoBDibujo = 0;
            ladoCDibujo = 0;

            // Limpiar cajas
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            // Limpiar gráfico
            pnlGrafico.Refresh();

            txtLadoA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmScaleneTriangle_Load(object sender, EventArgs e)
        {

        }
    }
}
