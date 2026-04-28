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
    public partial class FrmOval : Form
    {
        private static FrmOval _instancia;
        public FrmOval()
        {
            InitializeComponent();
        }
        
        public static FrmOval Instancia
        {
            get
            {
                if (_instancia == null || _instancia.IsDisposed)
                {
                    _instancia = new FrmOval();
                }
                return _instancia;
            }
        }

        float hCm = 0f;   // altura
        float wCm = 0f;   // ancho
        bool dibujar = false;

        private bool ValidarHuevo(out float h, out float w)
        {
            h = 0;
            w = 0;

            string inputH = txtAltura.Text.Trim();
            string inputW = txtAnchura.Text.Trim();

            // 🔴 campos vacíos
            if (string.IsNullOrEmpty(inputH) || string.IsNullOrEmpty(inputW))
            {
                MessageBox.Show("Debe ingresar altura y anchura");
                return false;
            }

            if (!float.TryParse(inputH, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out h))
            {
                MessageBox.Show("Altura inválida (use punto para decimales)");
                return false;
            }

            if (!float.TryParse(inputW, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out w))
            {
                MessageBox.Show("Anchura inválida (use punto para decimales)");
                return false;
            }

            if (h <= 0 || w <= 0)
            {
                MessageBox.Show("Los valores deben ser mayores que 0");
                return false;
            }

            if (w >= h)
            {
                MessageBox.Show("La altura debe ser mayor que la anchura para forma de huevo");
                return false;
            }

            if (h > 50 || w > 50)
            {
                MessageBox.Show("Valores demasiado grandes (máx 50 cm recomendado)");
                return false;
            }

            return true;
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!ValidarHuevo(out hCm, out wCm))
            {
                dibujar = false;
                panelGrafico.Invalidate();
                return;
            }

            dibujar = true;

            int hPx = (int)(hCm * 58f);
            int wPx = (int)(wCm * 58f);

            panelGrafico.Width = wPx + 40;
            panelGrafico.Height = hPx + 40;

            panelGrafico.Invalidate();

        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float h = hCm * 58f;
            float w = wCm * 58f;

            float centerX = panelGrafico.Width / 2f;
            float centerY = panelGrafico.Height / 2f;
                       
            float radioCirculo = w / 2f;

            float circuloCenterY = centerY + (h / 2f) - radioCirculo;


            float elipseTop = centerY - h / 2f;
            float unionY = circuloCenterY; 
            float elipseH = (unionY - elipseTop) * 2f; 

            using (GraphicsPath path = new GraphicsPath())
            {

                path.AddArc(centerX - w / 2f, elipseTop, w, elipseH, 180, 180);
                                
                path.AddArc(centerX - radioCirculo, circuloCenterY - radioCirculo,
                            radioCirculo * 2, radioCirculo * 2, 0, 180);

                path.CloseFigure();

                
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(240, 150, 150)))
                    g.FillPath(brush, path);

               
                using (PathGradientBrush pgb = new PathGradientBrush(path))
                {
                    pgb.CenterPoint = new PointF(centerX - w * 0.1f, centerY - h * 0.1f);
                    pgb.CenterColor = Color.FromArgb(255, 255, 230, 225);
                    pgb.SurroundColors = new Color[] { Color.FromArgb(0, 200, 100, 100) };
                    g.FillPath(pgb, path);
                }

                
                using (Pen pen = new Pen(Color.FromArgb(45, 45, 65), 3))
                    g.DrawPath(pen, path);
            }

            
            float brilloX = centerX - w * 0.28f;
            float brilloY = centerY - h * 0.28f;
            using (Pen penBrillo = new Pen(Color.FromArgb(90, 255, 255, 255), 2.2f))
            {
                for (int i = 1; i <= 3; i++)
                {
                    float r = i * (w * 0.07f);
                    g.DrawArc(penBrillo, brilloX - r, brilloY - r, r * 2, r * 2, 190, 120);
                }
            }

        }
    }
}
