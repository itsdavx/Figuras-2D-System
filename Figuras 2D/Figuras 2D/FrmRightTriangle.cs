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
    public partial class FrmRightTriangle : Form
    {
        // VARIABLES GLOBALES PARA EL DIBUJO
        private double baseDibujo = 0;
        private double alturaDibujo = 0;
        private static FrmRightTriangle instancia;
        public FrmRightTriangle()
        {
            InitializeComponent();
        }
        public static FrmRightTriangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmRightTriangle();
                }
                return instancia;
            }
        }

        private void lblLargo_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variables
            double baseTriangulo, altura, hipotenusa, perimetro, area;

            // Validar Base
            if (!double.TryParse(txtBase.Text, out baseTriangulo) || baseTriangulo <= 0)
            {
                MessageBox.Show("Ingrese una Base válida y mayor que cero.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtBase.Focus();
                return;
            }

            // Validar Altura
            if (!double.TryParse(txtAltura.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("Ingrese una Altura válida y mayor que cero.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtAltura.Focus();
                return;
            }

            // Cálculos
            hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2));
            perimetro = baseTriangulo + altura + hipotenusa;
            area = (baseTriangulo * altura) / 2;

            // Mostrar resultados
            txtHipotenusa.Text = hipotenusa.ToString("N2");
            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

            // Guardar valores para dibujar
            baseDibujo = baseTriangulo;
            alturaDibujo = altura;

            // Redibujar panel
            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (baseDibujo > 0 && alturaDibujo > 0)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Blue, 3);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(100, Color.LightBlue));

                float escala = 10;

                float b = (float)baseDibujo * escala;
                float h = (float)alturaDibujo * escala;

                float x = (pnlGrafico.Width - b) / 2;
                float y = (pnlGrafico.Height + h) / 2;

                // TRIÁNGULO HACIA LA DERECHA
                PointF p1 = new PointF(x, y);
                PointF p2 = new PointF(x + b, y);
                PointF p3 = new PointF(x + b, y - h);

                PointF[] puntos = { p1, p2, p3 };

                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            // Reiniciar variables globales
            baseDibujo = 0;
            alturaDibujo = 0;

            // Limpiar cajas de texto
            txtBase.Clear();
            txtAltura.Clear();
            txtHipotenusa.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            // Limpiar panel gráfico
            pnlGrafico.Refresh();

            // Enviar cursor al primer campo
            txtBase.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHipotenusa_Click(object sender, EventArgs e)
        {

        }

        private void lblGrafico_Click(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void lblSalida_Click(object sender, EventArgs e)
        {

        }

        private void txtHipotenusa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProceso_Click(object sender, EventArgs e)
        {

        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void lblEntradas_Click(object sender, EventArgs e)
        {

        }
    }
}
