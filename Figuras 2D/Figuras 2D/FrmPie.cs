using Figuras_2D.Transformaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_2D
{
    public partial class Angle : Form
    {
        private static Angle instancia;

        // clase de traslacion
        private Traslation moverFigura;

        public Angle()
        {
            InitializeComponent();

            // inicializar traslacion
            moverFigura = new Traslation(0, 0);

            // activar teclado
            this.KeyPreview = true;

            this.KeyDown += Angle_KeyDown;
        }

        public static Angle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new Angle();
                }
                return instancia;
            }
        }

        // mover figura con teclado
        private void Angle_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            pnlGrafico.Invalidate();
        }

        private void FrmPie_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        // variables globales
        private double radio = 0;
        private double angulo = 0;
        private double area = 0;
        private double perimetro = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // validar campos vacios
            if (txtRadio.Text.Trim() == "" || txtAngulo.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.",
                                "Dato requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // validar numeros
            if (!double.TryParse(txtRadio.Text, out radio) ||
                !double.TryParse(txtAngulo.Text, out angulo))
            {
                MessageBox.Show("Ingrese solo numeros validos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // validar positivos
            if (radio <= 0)
            {
                MessageBox.Show("El radio debe ser mayor que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtRadio.Focus();
                return;
            }

            // validar angulo
            if (angulo <= 0 || angulo > 360)
            {
                MessageBox.Show("El angulo debe estar entre 1 y 360 grados.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtAngulo.Focus();
                return;
            }

            // calculos
            area = (angulo / 360.0) * Math.PI * Math.Pow(radio, 2);

            double arco = (angulo / 360.0) * (2 * Math.PI * radio);

            perimetro = arco + (2 * radio);

            txtArea.Text = area.ToString("N2");
            txtPerimetro.Text = perimetro.ToString("N2");

            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (radio > 0 && angulo > 0)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen lapiz = new Pen(Color.Black, 2);
                SolidBrush brocha = new SolidBrush(Color.FromArgb(180, 160, 120));

                float diametro = (float)radio * 6f;

                // ajustar tamaño al panel
                if (diametro > pnlGrafico.Width - 20)
                    diametro = pnlGrafico.Width - 20;

                if (diametro > pnlGrafico.Height - 20)
                    diametro = pnlGrafico.Height - 20;

                // centrado total
                float x = ((pnlGrafico.Width - diametro) / 2) + moverFigura.X;
                float y = ((pnlGrafico.Height - diametro) / 2) + moverFigura.Y;

                float inicioHueco = 270f;
                float inicio = inicioHueco + (float)angulo;
                float barrido = 360f - (float)angulo;

                g.FillPie(brocha, x, y, diametro, diametro, inicio, barrido);
                g.DrawPie(lapiz, x, y, diametro, diametro, inicio, barrido);
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            radio = 0;
            angulo = 0;
            area = 0;
            perimetro = 0;

            txtRadio.Clear();
            txtAngulo.Clear();
            txtArea.Clear();
            txtPerimetro.Clear();

            pnlGrafico.Refresh();

            txtRadio.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}