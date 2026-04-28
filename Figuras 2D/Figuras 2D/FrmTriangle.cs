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
    public partial class FrmTriangle : Form
    {
        private static FrmTriangle instancia;
        public FrmTriangle()
        {
            InitializeComponent();
        }

        public static FrmTriangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmTriangle();
                }
                return instancia;
            }
        }

        private bool ValidarTriangulo(out float a, out float b, out float c)
        {
            a = b = c = 0;

            // Validar que sean números
            if (!float.TryParse(txtLado1.Text, out a) ||
                !float.TryParse(txtLado2.Text, out b) ||
                !float.TryParse(txtLado3.Text, out c))
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
                return false;
            }

            // Validar positivos
            if (a <= 0 || b <= 0 || c <= 0)
            {
                MessageBox.Show("Los lados deben ser positivos");
                return false;
            }

            // Validar desigualdad triangular
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Los valores no forman un triángulo válido");
                return false;
            }

            return true;
        }

        
        bool dibujar = false;
        private float lado1, lado2, lado3;

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!ValidarTriangulo(out lado1, out lado2, out lado3))
            {
                dibujar = false;
                panelGrafico.Invalidate();
                return;
            }

            dibujar = true;
            panelGrafico.Invalidate();
        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;

            float a = lado1;
            float b = lado2;
            float c = lado3;

            float margen = 20f;

            float anchoDisponible = panelGrafico.Width - 2 * margen;
            float altoDisponible = panelGrafico.Height - 2 * margen;

            float maxLado = Math.Max(a, Math.Max(b, c));
            float escala = Math.Min(anchoDisponible, altoDisponible) / maxLado;

            a *= escala;
            b *= escala;
            c *= escala;

            PointF A = new PointF(margen, panelGrafico.Height - margen);

            PointF B = new PointF(A.X + c, A.Y);

            float xC = (b * b + c * c - a * a) / (2 * c);
            float yC = (float)Math.Sqrt(Math.Max(0, b * b - xC * xC));

            PointF C = new PointF(A.X + xC, A.Y - yC);

            float minX = Math.Min(A.X, Math.Min(B.X, C.X));
            float maxX = Math.Max(A.X, Math.Max(B.X, C.X));
            float offsetX = (panelGrafico.Width - (maxX - minX)) / 2 - minX;

            A.X += offsetX;
            B.X += offsetX;
            C.X += offsetX;

            Pen lapiz = new Pen(Color.Black, 2);
            Brush brocha = new SolidBrush(Color.Pink);

            PointF[] puntos = { A, B, C };

            g.FillPolygon(brocha, puntos);
            g.DrawPolygon(lapiz, puntos);
        }
    }
}
