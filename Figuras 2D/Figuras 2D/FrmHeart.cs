using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmHeart : Form
    {
        private static FrmHeart instancia;

        private Heart heart;

        // clase de traslacion
        private Traslation moverFigura;

        private FrmHeart()
        {
            InitializeComponent();

            btnGraficar.Click += btnGraficar_Click;

            PanelGrafico.Paint += PanelGrafico_Paint;

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += FrmHeart_KeyDown;
        }

        public static FrmHeart Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmHeart();
                }

                return instancia;
            }
        }

        // mover figura con teclado
        private void FrmHeart_KeyDown(object sender, KeyEventArgs e)
        {
            // MOVER
            moverFigura.Mover(e);

            if (heart != null)
            {
                // GUARDAR ROTACIÓN
                float rotacionActual =
                    heart.Rotation;

                // ROTAR IZQUIERDA
                if (e.KeyCode == Keys.A)
                {
                    rotacionActual -= 5;
                }

                // ROTAR DERECHA
                if (e.KeyCode == Keys.D)
                {
                    rotacionActual += 5;
                }

                float tamanoCm =
                    float.Parse(txtTamano.Text);

                int tamanoPx =
                    (int)(tamanoCm * 58f);

                heart = new Heart(
                    10 + moverFigura.X,
                    10 + moverFigura.Y,
                    tamanoPx,
                    new Pen(Color.Black, 2),
                    new SolidBrush(Color.Red)
                );

                // RECUPERAR ROTACIÓN
                heart.Rotation =
                    rotacionActual;
            }

            PanelGrafico.Invalidate();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float tamanoCm))
                return;

            int tamanoPx = (int)(tamanoCm * 58f);

            PanelGrafico.Width = tamanoPx + 20;

            PanelGrafico.Height = tamanoPx + 20;

            int x = 10 + moverFigura.X;

            int y = 10 + moverFigura.Y;

            heart = new Heart(
                x,
                y,
                tamanoPx,
                new Pen(Color.Black, 2),
                new SolidBrush(Color.Red)
            );

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (heart != null)
            {
                heart.Draw(e.Graphics);
            }
        }

        private bool Validar(out float tamano)
        {
            tamano = 0;

            string input = txtTamano.Text.Trim();

            // validar vacio
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacio");

                return false;
            }

            // validar numero
            if (!float.TryParse(
                input,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out tamano))
            {
                MessageBox.Show("Ingrese un numero valido");

                return false;
            }

            // validar positivo
            if (tamano <= 0)
            {
                MessageBox.Show("El valor debe ser mayor que 0");

                return false;
            }

            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmHeart_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}