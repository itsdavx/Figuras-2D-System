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
    public partial class FrmScaleneTriangle : Form
    {
        private double ladoADibujo = 0;
        private double ladoBDibujo = 0;
        private double ladoCDibujo = 0;

        // TRASLACION
        private Traslation moverFigura = new Traslation(0, 0);

        private static FrmScaleneTriangle instancia;

        public FrmScaleneTriangle()
        {
            InitializeComponent();

            // ACTIVAR TECLADO
            this.KeyPreview = true;

            // EVENTO TECLADO
            this.KeyDown += FrmScaleneTriangle_KeyDown;
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

        // MOVIMIENTO CON TECLAS
        private void FrmScaleneTriangle_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            pnlGrafico.Invalidate();
        }

        private void lblLadoB_Click(object sender, EventArgs e)
        {
            // Se mantiene aunque no haga nada
        }

        private void FrmScaleneTriangle_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;
            double perimetro, area, s;

            if (txtLadoA.Text.Trim() == "" ||
                txtLadoB.Text.Trim() == "" ||
                txtLadoC.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los tres lados.", "Dato requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtLadoA.Text, out ladoA) ||
                !double.TryParse(txtLadoB.Text, out ladoB) ||
                !double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("Ingrese solo números válidos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
            {
                MessageBox.Show("Los lados deben ser mayores que cero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                MessageBox.Show("En un triángulo escaleno los lados deben ser diferentes.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ladoA + ladoB <= ladoC ||
                ladoA + ladoC <= ladoB ||
                ladoB + ladoC <= ladoA)
            {
                MessageBox.Show("Los valores no forman un triángulo válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            perimetro = ladoA + ladoB + ladoC;
            s = perimetro / 2;
            area = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

            txtPerimetro.Text = perimetro.ToString("N2");
            txtArea.Text = area.ToString("N2");

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

                Pen lapiz = new Pen(Color.DarkBlue, 2);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(150, Color.SkyBlue));

                float margen = 20;
                float panelW = pnlGrafico.Width - 2 * margen;
                float panelH = pnlGrafico.Height - 2 * margen;

                // Ordenar lados
                double[] lados = { ladoADibujo, ladoBDibujo, ladoCDibujo };
                Array.Sort(lados);

                float c = (float)lados[0];
                float b = (float)lados[1];
                float a = (float)lados[2];

                float x1 = 0, y1 = 0;
                float x2 = a, y2 = 0;

                float x3 = (b * b - c * c + a * a) / (2 * a);

                float temp = (b * b) - (x3 * x3);

                if (temp < 0)
                {
                    return;
                }

                float y3 = (float)Math.Sqrt(temp);

                // Centroide
                float cx = (x1 + x2 + x3) / 3;
                float cy = (y1 + y2 + y3) / 3;

                x1 -= cx; y1 -= cy;
                x2 -= cx; y2 -= cy;
                x3 -= cx; y3 -= cy;

                float maxX = Math.Max(Math.Abs(x1), Math.Max(Math.Abs(x2), Math.Abs(x3)));
                float maxY = Math.Max(Math.Abs(y1), Math.Max(Math.Abs(y2), Math.Abs(y3)));

                float escala = Math.Min(panelW / (2 * maxX), panelH / (2 * maxY));
                escala = Math.Min(escala, 5f);
                escala *= 0.8f;

                x1 *= escala; y1 *= escala;
                x2 *= escala; y2 *= escala;
                x3 *= escala; y3 *= escala;

                // CENTRO + TRASLACION
                float centroX = (pnlGrafico.Width / 2) + moverFigura.X;
                float centroY = (pnlGrafico.Height / 2) + moverFigura.Y;

                PointF p1 = new PointF(centroX + x1, centroY - y1);
                PointF p2 = new PointF(centroX + x2, centroY - y2);
                PointF p3 = new PointF(centroX + x3, centroY - y3);

                PointF[] puntos = { p1, p2, p3 };

                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);

                lapiz.Dispose();
                brocha.Dispose();
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ladoADibujo = 0;
            ladoBDibujo = 0;
            ladoCDibujo = 0;

            // REINICIAR TRASLACION
            moverFigura = new Traslation(0, 0);

            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtPerimetro.Clear();
            txtArea.Clear();

            pnlGrafico.Refresh();
            txtLadoA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}