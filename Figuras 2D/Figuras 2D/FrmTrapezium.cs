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
    public partial class FrmTrapezium : Form
    {

        private static FrmTrapezium instancia;
        private double baseMayorDibujo = 0;
        private double baseMenorDibujo = 0;
        private double alturaDibujo = 0;

        // Clase de traslación
        Traslation moverFigura = new Traslation(0, 0);

        public FrmTrapezium()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += FrmTrapezium_KeyDown;
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

        private void FrmTrapezium_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            pnlGrafico.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double baseMayor, baseMenor, altura;
            double perimetro, area;

            // Validar campos vacíos
            if (txtBaseMayor.Text.Trim() == "" ||
                txtBaseMenor.Text.Trim() == "" ||
                txtAltura.Text.Trim() == "")
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
                !double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Ingrese solo números válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validar positivos
            if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0)
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
            perimetro = baseMayor + baseMenor;
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

                Pen lapiz = new Pen(Color.Blue, 2);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(120, Color.LightBlue));

                // Márgenes para que no toque los bordes
                float margen = 20;

                float panelW = pnlGrafico.Width - 2 * margen;
                float panelH = pnlGrafico.Height - 2 * margen;

                float B = (float)baseMayorDibujo;
                float b = (float)baseMenorDibujo;
                float h = (float)alturaDibujo;

                // ESCALA DINÁMICA
                float escalaX = panelW / B;
                float escalaY = panelH / h;
                float escala = Math.Min(escalaX, escalaY);

                // Aplicar escala
                float Besc = B * escala;
                float besc = b * escala;
                float hesc = h * escala;

                // CENTRADO
                float x = ((pnlGrafico.Width - Besc) / 2) + moverFigura.X;
                float y = ((pnlGrafico.Height + hesc) / 2) + moverFigura.Y;

                float diferencia = (Besc - besc) / 2;

                PointF p1 = new PointF(x, y);
                PointF p2 = new PointF(x + Besc, y);
                PointF p3 = new PointF(x + Besc - diferencia, y - hesc);
                PointF p4 = new PointF(x + diferencia, y - hesc);

                PointF[] puntos = { p1, p2, p3, p4 };

                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);

                lapiz.Dispose();
                brocha.Dispose();
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

        private void FrmTrapezium_Load(object sender, EventArgs e)
        {

        }
    }
}