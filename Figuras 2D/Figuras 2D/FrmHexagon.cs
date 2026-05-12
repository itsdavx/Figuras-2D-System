using System;
using System.Drawing;
using System.Windows.Forms;
using Figuras_2D.Shapes;
using Figuras_2D.Transformaciones;

namespace Figuras_2D
{
    public partial class FrmHexagon : Form
    {
        private static FrmHexagon instancia;

        private Hexagon hexagon;

        // clase de traslacion
        private Traslation moverFigura;

        private FrmHexagon()
        {
            InitializeComponent();

            btnGraficar.Click += btnGraficar_Click;

            PanelGrafico.Paint += PanelGrafico_Paint;

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += FrmHexagon_KeyDown;
        }

        public static FrmHexagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmHexagon();
                }

                return instancia;
            }
        }

        // mover figura con teclado
        private void FrmHexagon_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            if (hexagon != null)
            {
                float ladoCm = float.Parse(txtLado.Text);

                int ladoPx = (int)(ladoCm * 58f);

                hexagon = new Hexagon(
                    10 + moverFigura.X,
                    10 + moverFigura.Y,
                    ladoPx,
                    new Pen(Color.Black, 2),
                    new SolidBrush(Color.Orange)
                );
            }

            PanelGrafico.Invalidate();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out float ladoCm))
                return;

            int ladoPx = (int)(ladoCm * 58f);

            PanelGrafico.Width = (ladoPx * 2) + 20;

            PanelGrafico.Height = (ladoPx * 2) + 20;

            int x = 10 + moverFigura.X;

            int y = 10 + moverFigura.Y;

            hexagon = new Hexagon(
                x,
                y,
                ladoPx,
                new Pen(Color.Black, 2),
                new SolidBrush(Color.Orange)
            );

            PanelGrafico.Invalidate();
        }

        private void PanelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (hexagon != null)
            {
                hexagon.Draw(e.Graphics);
            }
        }

        private bool Validar(out float lado)
        {
            lado = 0;

            string input = txtLado.Text.Trim();

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
                out lado))
            {
                MessageBox.Show("Ingrese un numero valido");

                return false;
            }

            // validar positivo
            if (lado <= 0)
            {
                MessageBox.Show("El valor debe ser mayor que 0");

                return false;
            }

            return true;
        }

        private void FrmHexagon_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}