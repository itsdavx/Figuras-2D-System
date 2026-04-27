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
    public partial class FrmCross : Form
    {
        private static FrmCross instancia;
        public FrmCross()
        {
            InitializeComponent();
        }
        public static FrmCross Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmCross();
                }
                return instancia;
            }
        }

        private bool Validar(out float tamano)
        {
            tamano = 0;

            string input = txtTamano.Text.Trim();

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
        int tamanoPx = 50;
        bool dibujar = false;

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out tamanoCm))
            {
                dibujar = false;
                panelGrafico.Invalidate();
                return;
            }

            dibujar = true;

            tamanoPx = (int)(tamanoCm * 58f);
            int size = tamanoPx * 3;

            panelGrafico.Width = size + 20;
            panelGrafico.Height = size + 20;

            panelGrafico.Invalidate();
        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int baseSize = tamanoPx;   // tamano base
            int size = baseSize * 3;   // cuadrado grande

            
            int x = (panelGrafico.Width - size) / 2;
            int y = (panelGrafico.Height - size) / 2;

            
            Region region = new Region(new Rectangle(x, y, size, size));

            int cut = baseSize;

            // recortar esquinas
            region.Exclude(new Rectangle(x, y, cut, cut)); // sup izq
            region.Exclude(new Rectangle(x + size - cut, y, cut, cut)); // sup der
            region.Exclude(new Rectangle(x, y + size - cut, cut, cut)); // inf izq
            region.Exclude(new Rectangle(x + size - cut, y + size - cut, cut, cut)); // inf der

            
            g.FillRegion(Brushes.DeepSkyBlue, region);

            using (Pen pen = new Pen(Color.Black, 2))
            {
                pen.LineJoin = LineJoin.Round;

                Point[] puntos = new Point[]
                {
                    new Point(x + cut, y),
                    new Point(x + 2*cut, y),

                    new Point(x + 2*cut, y + cut),
                    new Point(x + size, y + cut),

                    new Point(x + size, y + 2*cut),
                    new Point(x + 2*cut, y + 2*cut),

                    new Point(x + 2*cut, y + size),
                    new Point(x + cut, y + size),

                    new Point(x + cut, y + 2*cut),
                    new Point(x, y + 2*cut),

                    new Point(x, y + cut),
                    new Point(x + cut, y + cut)
                };

                g.DrawPolygon(pen, puntos);
            }

        }
    }
}
