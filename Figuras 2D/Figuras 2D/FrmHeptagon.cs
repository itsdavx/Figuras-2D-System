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
    public partial class FrmHeptagon : Form
    {
        private static FrmHeptagon instancia;
        public FrmHeptagon()
        {
            InitializeComponent();
        }
        public static FrmHeptagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmHeptagon();
                }
                return instancia;
            }
        }

        private bool ValidarLado(out float lado)
        {
            lado = 0;

            if (!float.TryParse(txtLado.Text, out lado))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                return false;
            }

            if (lado <= 0)
            {
                MessageBox.Show("El lado debe ser positivo");
                return false;
            }

            return true;
        }

        float ladoHeptagono;
        float tamanoPx;
        bool dibujar = false;
        int n = 7;
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!ValidarLado(out ladoHeptagono))
            {
                dibujar = false;
                panelGrafico.Invalidate();
                return;
            }

            float ladoPx = ladoHeptagono * 58f;

            float R = (float)(ladoPx / (2 * Math.Sin(Math.PI / n)));

            tamanoPx = 2 * R;

            panelGrafico.Width = (int)tamanoPx + 20;
            panelGrafico.Height = (int)tamanoPx + 20;

            dibujar = true;
            panelGrafico.Invalidate();
        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;

            float ladoPx = ladoHeptagono * 58f;

            float R = (float)(ladoPx / (2 * Math.Sin(Math.PI / n)));

            float cx = panelGrafico.Width / 2f;
            float cy = panelGrafico.Height / 2f;

            PointF[] puntos = new PointF[n];

            float anguloInicial = (float)(-Math.PI / 2);

            for (int i = 0; i < n; i++)
            {
                float angulo = anguloInicial + i * (2 * (float)Math.PI / n);

                float x = cx + R * (float)Math.Cos(angulo);
                float y = cy + R * (float)Math.Sin(angulo);

                puntos[i] = new PointF(x, y);
            }

            using (Pen lapiz = new Pen(Color.Black, 2))
            using (Brush brocha = new SolidBrush(Color.Green))
            {
                g.FillPolygon(brocha, puntos);
                g.DrawPolygon(lapiz, puntos);
            }
        }
    }
}
