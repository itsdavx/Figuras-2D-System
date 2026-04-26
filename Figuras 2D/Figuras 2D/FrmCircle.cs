using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;

namespace Figuras_2D
{
    public partial class FrmCircle : Form
    {
        private static FrmCircle instancia;

        private Circle circulo;

        private FrmCircle()
        {
            InitializeComponent();
            btnGraficar.Click += btnGraficar_Click;
            PanelGrafico.Paint += PanelGrafico_Paint;
        }

        public static FrmCircle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmCircle();
                }
                return instancia;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float radioCm))
                return;

            // Convertir cm a px
            float radioPx = radioCm * 58f;
            int diametroPx = (int)(radioPx * 2);

            PanelGrafico.Width = diametroPx + 20;
            PanelGrafico.Height = diametroPx + 20;

            circulo = new Circle(10, 10, diametroPx, new Pen(Color.Black, 2), new SolidBrush(Color.Green));

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (circulo != null)
            {
                circulo.Draw(e.Graphics);
            }
        }        
        private bool Validar(out float radio)
        {
            radio = 0;

            string input = txtRadio.Text.Trim();

            // Validar vacío
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacío");
                return false;
            }

            // Validar Letras
            if (!float.TryParse(input, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out radio))
            {
                MessageBox.Show("Ingrese un número válido (use punto para decimales, ej: 2.5)");
                return false;
            }

            // Validar Cero o Negativos
            if (radio <= 0)
            {
                MessageBox.Show("El radio debe ser mayor que 0");
                return false;
            }

            return true;
        }
    }
}