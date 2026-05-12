using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmEllipse : Form
    {
        private static FrmEllipse instancia;

        private Ellipse elipse;

        // clase de traslacion
        private Traslation moverFigura;

        private FrmEllipse()
        {
            InitializeComponent();

            btnGraficar.Click += btnGraficar_Click;

            PanelGrafico.Paint += PanelGrafico_Paint;

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += FrmEllipse_KeyDown;
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

        // mover figura con teclado
        private void FrmEllipse_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            if (elipse != null)
            {
                float eje1Cm = float.Parse(txtEje1.Text);

                float eje2Cm = float.Parse(txtEje2.Text);

                float eje1Px = eje1Cm * 58f;

                float eje2Px = eje2Cm * 58f;

                int ancho = (int)eje1Px;

                int alto = (int)eje2Px;

                elipse = new Ellipse(
                    10 + moverFigura.X,
                    10 + moverFigura.Y,
                    ancho,
                    alto,
                    new Pen(Color.Black, 2),
                    new SolidBrush(Color.Purple)
                );
            }

            PanelGrafico.Invalidate();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float eje1Cm, out float eje2Cm))
                return;

            // convertir cm a px
            float eje1Px = eje1Cm * 58f;

            float eje2Px = eje2Cm * 58f;

            int ancho = (int)eje1Px;

            int alto = (int)eje2Px;

            PanelGrafico.Width = ancho + 20;

            PanelGrafico.Height = alto + 20;

            elipse = new Ellipse(
                10 + moverFigura.X,
                10 + moverFigura.Y,
                ancho,
                alto,
                new Pen(Color.Black, 2),
                new SolidBrush(Color.Purple)
            );

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

            // validar vacios
            if (string.IsNullOrEmpty(input1) ||
                string.IsNullOrEmpty(input2))
            {
                MessageBox.Show("Los campos no pueden estar vacios");

                return false;
            }

            // validar numeros
            if (!float.TryParse(
                input1,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out eje1)
                ||
                !float.TryParse(
                input2,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out eje2))
            {
                MessageBox.Show("Ingrese numeros validos");

                return false;
            }

            // validar positivos
            if (eje1 <= 0 || eje2 <= 0)
            {
                MessageBox.Show("Los ejes deben ser mayores que 0");

                return false;
            }

            return true;
        }

        private void btnGraficar_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmEllipse_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}