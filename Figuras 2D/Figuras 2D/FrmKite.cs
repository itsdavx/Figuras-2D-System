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
        public FrmKite()
        {
            InitializeComponent();
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


        float d1Cm, d2Cm;
        bool dibujar = false;

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

            Point[] puntos = new Point[]
            {
        new Point(x + d2Px / 2, y),
        new Point(x + d2Px, y + arriba),
        new Point(x + d2Px / 2, y + alturaTotal),
        new Point(x, y + arriba)
            };

            g.FillPolygon(Brushes.MediumPurple, puntos);

            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawPolygon(pen, puntos);
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
