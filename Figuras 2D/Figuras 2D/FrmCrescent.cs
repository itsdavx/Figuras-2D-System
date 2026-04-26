using Figuras_2D.Shapes;
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
    public partial class FrmCrescent : Form
    {
        private static FrmCrescent instancia;
        public FrmCrescent()
        {
            InitializeComponent();
        }
        public static FrmCrescent Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmCrescent();
                }
                return instancia;
            }
        }

        private bool Validar(out float tamano)
        {
            tamano = 0;

            string input = txtRadio.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacío");
                return false;
            }

            if (!float.TryParse(input, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out tamano))
            {
                MessageBox.Show("Ingrese un número válido (use punto para decimales)");
                return false;
            }

            if (tamano <= 0)
            {
                MessageBox.Show("El valor debe ser mayor que 0");
                return false;
            }

            return true;
        }

        float tamanoCm = 2f;
        bool dibujar = false;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!Validar(out tamanoCm))
            {
                dibujar = false;
                panelGrafico.Invalidate();
                return;
            }

            dibujar = true;

            int tamanoPx = (int)(tamanoCm * 58f);


            panelGrafico.Width = tamanoPx + 20;
            panelGrafico.Height = tamanoPx + 20;

            panelGrafico.Invalidate();

        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int tamanoPx = (int)(tamanoCm * 58f);

            
            int x = (panelGrafico.Width - tamanoPx) / 2;
            int y = (panelGrafico.Height - tamanoPx) / 2;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(x, y, tamanoPx, tamanoPx);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(x + tamanoPx / 3, y, tamanoPx, tamanoPx);

            Region region = new Region(path1);
            region.Exclude(path2);

            g.FillRegion(Brushes.Green, region);

            Pen pen = new Pen(Color.Black, 2);

           // Elipse exterior
            g.DrawArc(pen, x, y, tamanoPx, tamanoPx,71, 218);
            // Elipse interior
            g.DrawArc(pen, x + tamanoPx / 3, y, tamanoPx, tamanoPx, 110, 140);
        }
    }
}
