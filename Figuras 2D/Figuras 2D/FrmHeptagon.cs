using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_2D.Transformaciones;


namespace Figuras_2D
{
    public partial class FrmHeptagon : Form
    {
        private static FrmHeptagon instancia;

        // clase de traslacion
        private Traslation moverFigura;

        public FrmHeptagon()
        {
            InitializeComponent();

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += FrmHeptagon_KeyDown;
        }

        public static FrmHeptagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmHeptagon();
                }

                return instancia;
            }
        }

        // mover figura con teclado
        private void FrmHeptagon_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            panelGrafico.Invalidate();
        }

        private bool ValidarLado(out float lado)
        {
            lado = 0;

            // validar numero
            if (!float.TryParse(txtLado.Text, out lado))
            {
                MessageBox.Show("Ingrese un valor numerico valido");

                return false;
            }

            // validar positivo
            if (lado <= 0)
            {
                MessageBox.Show("El lado debe ser positivo");

                return false;
            }

            return true;
        }

        float ladoHeptagono;

        float tamanoPx;

        bool dibujar = false;

        int n = 7;

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!ValidarLado(out ladoHeptagono))
            {
                dibujar = false;

                panelGrafico.Invalidate();

                return;
            }

            float ladoPx = ladoHeptagono * 58f;

            float R =
                (float)(ladoPx /
                (2 * Math.Sin(Math.PI / n)));

            tamanoPx = 2 * R;

            panelGrafico.Width = (int)tamanoPx + 20;

            panelGrafico.Height = (int)tamanoPx + 20;

            dibujar = true;

            panelGrafico.Invalidate();
        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar)
                return;

            Graphics g = e.Graphics;

            float ladoPx = ladoHeptagono * 58f;

            float R =
                (float)(ladoPx /
                (2 * Math.Sin(Math.PI / n)));

            // aplicar traslacion
            float cx =
                (panelGrafico.Width / 2f) + moverFigura.X;

            float cy =
                (panelGrafico.Height / 2f) + moverFigura.Y;

            PointF[] puntos = new PointF[n];

            float anguloInicial =
                (float)(-Math.PI / 2);

            for (int i = 0; i < n; i++)
            {
                float angulo =
                    anguloInicial +
                    i * (2 * (float)Math.PI / n);

                float x =
                    cx + R * (float)Math.Cos(angulo);

                float y =
                    cy + R * (float)Math.Sin(angulo);

                puntos[i] = new PointF(x, y);
            }

            using (Pen lapiz = new Pen(Color.Black, 2))
            using (Brush brocha = new SolidBrush(Color.Green))
            {
                g.FillPolygon(brocha, puntos);

                g.DrawPolygon(lapiz, puntos);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmHeptagon_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
