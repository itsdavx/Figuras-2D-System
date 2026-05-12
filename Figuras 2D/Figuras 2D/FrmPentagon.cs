using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmPentagon : Form
    {
        private static FrmPentagon instancia;

        private Pentagon pentagon;

        // clase de traslacion
        private Traslation moverFigura;

        private FrmPentagon()
        {
            InitializeComponent();

            btnGraficar.Click += btnGraficar_Click;

            PanelGrafico.Paint += PanelGrafico_Paint;

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += FrmPentagon_KeyDown;
        }

        public static FrmPentagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmPentagon();
                }
                return instancia;
            }
        }

        // mover figura con teclado
        private void FrmPentagon_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            if (pentagon != null)
            {
                float ladoCm = float.Parse(txtLado.Text);

                int ladoPx = (int)(ladoCm * 50f);

                pentagon = new Pentagon(
                    10 + moverFigura.X,
                    10 + moverFigura.Y,
                    ladoPx,
                    new Pen(Color.Black, 2),
                    new SolidBrush(Color.Pink)
                );
            }

            PanelGrafico.Invalidate();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float ladoCm))
                return;

            int ladoPx = (int)(ladoCm * 50f);

            PanelGrafico.Width = (ladoPx * 2) + 20;
            PanelGrafico.Height = (ladoPx * 2) + 20;

            int x = 10 + moverFigura.X;
            int y = 10 + moverFigura.Y;

            pentagon = new Pentagon(
                x,
                y,
                ladoPx,
                new Pen(Color.Black, 2),
                new SolidBrush(Color.Pink)
            );

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (pentagon != null)
            {
                pentagon.Draw(e.Graphics);
            }
        }

        private bool Validar(out float lado)
        {
            lado = 0;

            string input = txtLado.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacio");
                return false;
            }

            if (!float.TryParse(input, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out lado))
            {
                MessageBox.Show("Ingrese un numero valido");
                return false;
            }

            if (lado <= 0)
            {
                MessageBox.Show("El valor debe ser mayor que 0");
                return false;
            }

            return true;
        }

        private void FrmPentagon_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}