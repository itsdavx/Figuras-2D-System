using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmCircle : Form
    {
        private static FrmCircle instancia;

        private Circle circulo;

        // OBJETO DE TRASLACIÓN
        private Traslation moverFigura;

        private FrmCircle()
        {
            InitializeComponent();

            btnGraficar.Click += btnGraficar_Click;

            PanelGrafico.Paint += PanelGrafico_Paint;

            // INICIALIZAR TRASLACIÓN
            moverFigura = new Traslation(0, 0);

            // ACTIVAR TECLADO
            this.KeyPreview = true;

            this.KeyDown += FrmCircle_KeyDown;
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

        // EVENTO DEL TECLADO
        private void FrmCircle_KeyDown(
    object sender,
    KeyEventArgs e
)
        {
            moverFigura.Mover(e);

            if (circulo != null)
            {
                // ROTACIÓN
                if (e.KeyCode == Keys.A)
                {
                    circulo.Rotation -= 5;
                }

                if (e.KeyCode == Keys.D)
                {
                    circulo.Rotation += 5;
                }

                float radioCm =
                    float.Parse(txtRadio.Text);

                float radioPx = radioCm * 58f;

                int diametroPx =
                    (int)(radioPx * 2);

                float rotacionActual = circulo.Rotation;

                circulo = new Circle(
                    10 + moverFigura.X,
                    10 + moverFigura.Y,
                    diametroPx,
                    new Pen(Color.Black, 2),
                    new SolidBrush(Color.Green)
                );

                circulo.Rotation = rotacionActual;
            }

            PanelGrafico.Invalidate();
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

            circulo = new Circle(
                10 + moverFigura.X,
                10 + moverFigura.Y,
                diametroPx,
                new Pen(Color.Black, 2),
                new SolidBrush(Color.Green)
            );

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

            // VALIDAR VACÍO
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacío");

                return false;
            }

            // VALIDAR LETRAS
            if (!float.TryParse(
                input,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out radio))
            {
                MessageBox.Show("Ingrese un número válido (use punto para decimales, ej: 2.5)");

                return false;
            }

            // VALIDAR NEGATIVOS
            if (radio <= 0)
            {
                MessageBox.Show("El radio debe ser mayor que 0");

                return false;
            }

            return true;
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}