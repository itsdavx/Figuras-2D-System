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
    public partial class FrmArrow : Form
    {
        private static FrmArrow instancia;
        float largo, ancho, lado;
        bool dibujar = false;
        public FrmArrow()
        {
            InitializeComponent();
        }
        public static FrmArrow Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmArrow();
                }
                return instancia;
            }
        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void txtLargoDelCuerpo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnchoDelCuerpo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoDelTrianguloEquilatero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                largo = float.Parse(txtLargoDelCuerpo.Text);
                ancho = float.Parse(txtAnchoDelCuerpo.Text);
                lado = float.Parse(txtLadoDelTrianguloEquilatero.Text);

                double area = (largo * ancho) + (Math.Sqrt(3) / 4) * (lado * lado);
                double perimetro = 2 * (largo + ancho) + 2 * lado;

                txtArea.Text = area.ToString("0.00");
                txtPerimetro.Text = perimetro.ToString("0.00");

                dibujar = true;
                pnlGrafico.Invalidate();
            }
            catch
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float escala = 10;
            float rectL = largo * escala; // Largo del cuerpo
            float rectA = ancho * escala; // Grosor del cuerpo
            float triL = lado * escala;  // Lado del triángulo equilátero

            // 1. Calculamos la altura real del triángulo equilátero usando la fórmula: h = (sqrt(3)/2) * lado
            float alturaTriangulo = (float)(Math.Sqrt(3) / 2 * triL);

            // 2. Centramos el dibujo en el panel
            // El ancho total es rectL + alturaTriangulo
            float xInicio = (pnlGrafico.Width - (rectL + alturaTriangulo)) / 2;
            float yCentro = pnlGrafico.Height / 2;

            // 3. Definir los puntos del cuerpo (Rectángulo)
            float rectY = yCentro - (rectA / 2);
            RectangleF cuerpo = new RectangleF(xInicio, rectY, rectL, rectA);

            // 4. Definir los puntos de la cabeza (Triángulo equilátero)
            // El punto de conexión es xInicio + rectL
            PointF p1 = new PointF(xInicio + rectL, yCentro - (triL / 2)); // Esquina superior
            PointF p2 = new PointF(xInicio + rectL + alturaTriangulo, yCentro); // Punta
            PointF p3 = new PointF(xInicio + rectL, yCentro + (triL / 2)); // Esquina inferior
            PointF[] puntosTriangulo = { p1, p2, p3 };

            // --- DIBUJAR ---
            // Colores basados en tu imagen
            Brush rellenoCuerpo = new SolidBrush(Color.FromArgb(45, 170, 225)); // Celeste
            Pen borde = new Pen(Color.FromArgb(20, 40, 80), 2); // Azul oscuro

            // Dibujar Cuerpo
            g.FillRectangle(rellenoCuerpo, cuerpo);
            g.DrawRectangle(borde, cuerpo.X, cuerpo.Y, cuerpo.Width, cuerpo.Height);

            // Dibujar Cabeza
            g.FillPolygon(rellenoCuerpo, puntosTriangulo);
            g.DrawPolygon(borde, puntosTriangulo);

            // Limpieza de recursos
            rellenoCuerpo.Dispose();
            borde.Dispose();
        }
        private void FrmArrow_Load(object sender, EventArgs e)
        {

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            txtLargoDelCuerpo.Clear();
            txtAnchoDelCuerpo.Clear();
            txtLadoDelTrianguloEquilatero.Clear();

            txtArea.Clear();
            txtPerimetro.Clear();

            dibujar = false;
            pnlGrafico.Invalidate();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
