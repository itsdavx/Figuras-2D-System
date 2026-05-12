using Figuras_2D.Transformaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_2D
{
    public partial class FrmKite : Form
    {
        private static FrmKite instancia;

        // clase de traslacion
        Traslation moverFigura = new Traslation(0, 0);

        public FrmKite()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += FrmKite_KeyDown;
        }

        public static FrmKite Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmKite();
                }
                return instancia;
            }
        }

        // Evento del teclado
        private void FrmKite_KeyDown(object sender, KeyEventArgs e)
        {
            if (!dibujar)
                return;

            zoom.AplicarZoom(e);

            // mover con flechas
            moverFigura.Mover(e);

            panelGrafico.Invalidate();
        }

        float d1Cm, d2Cm;
        bool dibujar = false;

        Zoom zoom = new Zoom();

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int d1Px = (int)(d1Cm * 58f);
            int d2Px = (int)(d2Cm * 58f);

            float alpha = 0.3f;

            int arriba = (int)(d1Px * alpha);
            int abajo = d1Px - arriba;
            int alturaTotal = arriba + abajo;

            int x = (panelGrafico.Width - d2Px) / 2;
            int y = (panelGrafico.Height - alturaTotal) / 2;

            PointF[] puntos = new PointF[]
            {
                new PointF(x + d2Px / 2 + moverFigura.X, y + moverFigura.Y),

                new PointF(x + d2Px + moverFigura.X, y + arriba + moverFigura.Y),

                new PointF(x + d2Px / 2 + moverFigura.X, y + alturaTotal + moverFigura.Y),

                new PointF(x + moverFigura.X, y + arriba + moverFigura.Y)
            };

            PointF centro = new PointF(
                x + d2Px / 2 + moverFigura.X,
                y + alturaTotal / 2 + moverFigura.Y
            );

            PointF[] escalados =
                new PointF[puntos.Length];

            for (int i = 0; i < puntos.Length; i++)
            {
                float nuevoX =
                    centro.X +
                    (puntos[i].X - centro.X)
                    * zoom.Escalar;

                float nuevoY =
                    centro.Y +
                    (puntos[i].Y - centro.Y)
                    * zoom.Escalar;

                escalados[i] =
                    new PointF(nuevoX, nuevoY);
            }

            g.FillPolygon(
              Brushes.MediumPurple,
              escalados);

            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawPolygon(pen, escalados);
            }

        }

        private bool ValidarKite(out float d1, out float d2)
        {
            d1 = 0;
            d2 = 0;

            string input1 = txtDiagonalMayor.Text.Trim();
            string input2 = txtDiagonalMenor.Text.Trim();

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                MessageBox.Show("Ambos campos son obligatorios");
                return false;
            }

            if (!float.TryParse(input1, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out d1))
            {
                MessageBox.Show("Diagonal mayor inválida (use punto para decimales)");
                return false;
            }

            if (!float.TryParse(input2, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out d2))
            {
                MessageBox.Show("Diagonal menor inválida (use punto para decimales)");
                return false;
            }

            if (d1 <= 0 || d2 <= 0)
            {
                MessageBox.Show("Los valores deben ser mayores que 0");
                return false;
            }

            if (d2 >= d1)
            {
                MessageBox.Show("La diagonal menor debe ser menor que la mayor");
                return false;
            }

            if (d1 > 50 || d2 > 50)
            {
                MessageBox.Show("Valores demasiado grandes (máx 50 cm recomendado)");
                return false;
            }

            return true;
        }

        private void FrmKite_KeyDown_1(object sender, KeyEventArgs e)
        {
            zoom.AplicarZoom(e);

            moverFigura.Mover(e);

            panelGrafico.Invalidate();
        }

        private void FrmKite_Load(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!ValidarKite(out d1Cm, out d2Cm))
            {
                dibujar = false;
                panelGrafico.Invalidate();
                return;
            }

            dibujar = true;

            int d1Px = (int)(d1Cm * 58f);
            int d2Px = (int)(d2Cm * 58f);

            panelGrafico.Width = d2Px + 40;
            panelGrafico.Height = d1Px + 40;

            panelGrafico.Invalidate();
        }
    }
}