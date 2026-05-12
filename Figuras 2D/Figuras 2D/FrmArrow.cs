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
    public partial class FrmArrow : Form
    {
        private static FrmArrow instancia;

        float largo, ancho, lado;

        bool dibujar = false;

        // OBJETO DE TRASLACIÓN
        Traslation moverFigura;

        public FrmArrow()
        {
            InitializeComponent();

            // POSICIÓN INICIAL
            moverFigura = new Traslation(0, 0);

            // ACTIVAR TECLADO
            this.KeyPreview = true;
            this.KeyDown += FrmArrow_KeyDown;
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

        // EVENTO DEL TECLADO
        private void FrmArrow_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            pnlGrafico.Invalidate();
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

                // VALIDACIÓN
                if (largo <= 0 || ancho <= 0 || lado <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser mayores a cero",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                if (lado <= Math.Max(largo, ancho))
                {
                    MessageBox.Show("El lado del triángulo debe ser mayor que el largo y el ancho del cuerpo.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // CÁLCULOS
                double area = (largo * ancho) + (Math.Sqrt(3) / 4) * (lado * lado);
                double perimetro = 2 * (largo + ancho) + 2 * lado;

                txtArea.Text = area.ToString("0.00");
                txtPerimetro.Text = perimetro.ToString("0.00");

                dibujar = true;

                pnlGrafico.Invalidate();
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float margen = 20;

            float panelW = pnlGrafico.Width - 2 * margen;
            float panelH = pnlGrafico.Height - 2 * margen;

            // MEDIDAS
            float rectL = largo;
            float rectA = ancho;
            float triL = lado;

            float alturaTriangulo = (float)(Math.Sqrt(3) / 2 * triL);

            float totalW = rectL + alturaTriangulo;
            float totalH = triL;

            // ESCALA
            float escala = Math.Min(panelW / totalW, panelH / totalH);

            escala *= 0.9f;

            rectL *= escala;
            rectA *= escala;
            triL *= escala;
            alturaTriangulo *= escala;

            float centroX = pnlGrafico.Width / 2;
            float centroY = pnlGrafico.Height / 2;

            float xInicio = centroX - (rectL + alturaTriangulo) / 2;
            float yCentro = centroY;

            float yTop = yCentro - rectA / 2;
            float yBottom = yCentro + rectA / 2;

            float yTriTop = yCentro - triL / 2;
            float yTriBottom = yCentro + triL / 2;

            // FLECHA CON TRASLACIÓN
            PointF[] puntos = new PointF[]
            {
                new PointF(xInicio + moverFigura.X,
                           yTop + moverFigura.Y),

                new PointF(xInicio + rectL + moverFigura.X,
                           yTop + moverFigura.Y),

                new PointF(xInicio + rectL + moverFigura.X,
                           yTriTop + moverFigura.Y),

                new PointF(xInicio + rectL + alturaTriangulo + moverFigura.X,
                           yCentro + moverFigura.Y),

                new PointF(xInicio + rectL + moverFigura.X,
                           yTriBottom + moverFigura.Y),

                new PointF(xInicio + rectL + moverFigura.X,
                           yBottom + moverFigura.Y),

                new PointF(xInicio + moverFigura.X,
                           yBottom + moverFigura.Y)
            };

            Brush relleno = new SolidBrush(Color.FromArgb(45, 170, 225));

            Pen borde = new Pen(Color.FromArgb(20, 40, 80), 2);

            g.FillPolygon(relleno, puntos);

            g.DrawPolygon(borde, puntos);

            relleno.Dispose();
            borde.Dispose();
        }

        private void FrmArrow_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void lblEntradas_Click(object sender, EventArgs e)
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