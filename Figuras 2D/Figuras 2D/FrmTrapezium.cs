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
    public partial class FrmTrapezium : Form
    {

        private static FrmTrapezium instancia;
        private double baseMayorDibujo = 0;
        private double baseMenorDibujo = 0;
        private double alturaDibujo = 0;

        public FrmTrapezium()
        {
            InitializeComponent();
        }

        public static FrmTrapezium Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmTrapezium();
                }
                return instancia;
            }
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double baseMayor, baseMenor, altura;
            double ladoIzquierdo, ladoDerecho;
            double perimetro, area;

            // Validar campos vacíos
            if (txtBaseMayor.Text.Trim() == "" ||
                txtBaseMenor.Text.Trim() == "" ||
                txtAltura.Text.Trim() == "" ||
                txtLadoIzquierdo.Text.Trim() == "" ||
                txtLadoDerecho.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.",
                                "Dato requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validar números
            if (!double.TryParse(txtBaseMayor.Text, out baseMayor) ||
                !double.TryParse(txtBaseMenor.Text, out baseMenor) ||
                !double.TryParse(txtAltura.Text, out altura) ||
                !double.TryParse(txtLadoIzquierdo.Text, out ladoIzquierdo) ||
                !double.TryParse(txtLadoDerecho.Text, out ladoDerecho))
            {
                MessageBox.Show("Ingrese solo números válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validar positivos
            if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 ||
                ladoIzquierdo <= 0 || ladoDerecho <= 0)
            {
                MessageBox.Show("Todos los valores deben ser mayores que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validar bases
            if (baseMenor >= baseMayor)
            {
                MessageBox.Show("La Base Menor debe ser menor que la Base Mayor.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtBaseMenor.Focus();
                return;
            }

            // Cálculos
            perimetro = baseMayor + baseMenor + ladoIzquierdo + ladoDerecho;
            area = ((baseMayor + baseMenor) * altura) / 2;

            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // Guardar variables globales
            baseMayorDibujo = baseMayor;
            baseMenorDibujo = baseMenor;
            alturaDibujo = altura;

            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (baseMayorDibujo > 0 && baseMenorDibujo > 0 && alturaDibujo > 0)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 3);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(100, Color.LightBlue));

                float escala = 8;

                float B = (float)baseMayorDibujo * escala;
                float b = (float)baseMenorDibujo * escala;
                float h = (float)alturaDibujo * escala;

                float x = (pnlGrafico.Width - B) / 2;
                float y = pnlGrafico.Height - 40;

                float diferencia = (B - b) / 2;

                PointF p1 = new PointF(x, y);
                PointF p2 = new PointF(x + B, y);
                PointF p3 = new PointF(x + B - diferencia, y - h);
                PointF p4 = new PointF(x + diferencia, y - h);

                PointF[] puntos = { p1, p2, p3, p4 };

                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Reiniciar variables
            baseMayorDibujo = 0;
            baseMenorDibujo = 0;
            alturaDibujo = 0;

            // Limpiar cajas
            txtBaseMayor.Clear();
            txtBaseMenor.Clear();
            txtAltura.Clear();
            txtLadoIzquierdo.Clear();
            txtLadoDerecho.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            // Limpiar panel
            pnlGrafico.Refresh();

            txtBaseMayor.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
