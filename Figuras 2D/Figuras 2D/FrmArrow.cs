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

            float rectL = largo * escala;
            float rectA = ancho * escala;
            float triL = lado * escala;

            int x = pnlGrafico.Width / 2 - (int)(rectL / 2);
            int y = pnlGrafico.Height / 2 - (int)(rectA / 2);

            // Rectángulo (cuerpo)
            Rectangle cuerpo = new Rectangle(x, y, (int)rectL, (int)rectA);
            g.FillRectangle(Brushes.SteelBlue, cuerpo);

            // Triángulo sobresaliendo hacia la derecha
            PointF p1 = new PointF(x + rectL, y);                      // esquina superior del rectángulo
            PointF p2 = new PointF(x + rectL + triL, y + rectA / 2);  // punta del triángulo
            PointF p3 = new PointF(x + rectL, y + rectA);              // esquina inferior del rectángulo

            g.FillPolygon(Brushes.Orange, new PointF[] { p1, p2, p3 });
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
