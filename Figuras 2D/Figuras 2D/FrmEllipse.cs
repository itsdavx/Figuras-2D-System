using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;

namespace Figuras_2D
{
    public partial class FrmEllipse : Form
    {
        private static FrmEllipse instancia;

        private Ellipse elipse;

        private FrmEllipse()
        {
            InitializeComponent();
            btnGraficar.Click += btnGraficar_Click;
            PanelGrafico.Paint += PanelGrafico_Paint;
        }

        public static FrmEllipse Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmEllipse();
                }
                return instancia;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float eje1Cm, out float eje2Cm))
                return;

            // Convertir cm a px
            float eje1Px = eje1Cm * 58f;
            float eje2Px = eje2Cm * 58f;

            int ancho = (int)eje1Px;
            int alto = (int)eje2Px;

            PanelGrafico.Width = ancho + 20;
            PanelGrafico.Height = alto + 20;

            elipse = new Ellipse(10, 10, ancho, alto, new Pen(Color.Black, 2), new SolidBrush(Color.Blue));
            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (elipse != null)
            {
                elipse.Draw(e.Graphics);
            }
        }

        private bool Validar(out float eje1, out float eje2)
        {
            eje1 = 0;
            eje2 = 0;

            string input1 = txtEje1.Text.Trim();
            string input2 = txtEje2.Text.Trim();

            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return false;
            }

            if (!float.TryParse(input1, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out eje1) ||
                !float.TryParse(input2, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out eje2))
            {
                MessageBox.Show("Ingrese números válidos (use punto para decimales)");
                return false;
            }

            if (eje1 <= 0 || eje2 <= 0)
            {
                MessageBox.Show("Los ejes deben ser mayores que 0");
                return false;
            }

            return true;
        }
    }
}