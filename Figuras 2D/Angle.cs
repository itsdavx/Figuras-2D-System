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
        public Angle()
        {
            InitializeComponent();
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

        private void FrmPie_Load(object sender, EventArgs e)
        {

        }

        // VARIABLES GLOBALES (declararlas arriba de la clase)
        private double radio = 0;
        private double angulo = 0;
        private double area = 0;
        private double perimetro = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (txtRadio.Text.Trim() == "" || txtAngulo.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.",
                                "Dato requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Validar números
            if (!double.TryParse(txtRadio.Text, out radio) ||
                !double.TryParse(txtAngulo.Text, out angulo))
            {
                MessageBox.Show("Ingrese solo números válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validar positivos
            if (radio <= 0)
            {
                MessageBox.Show("El radio debe ser mayor que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtRadio.Focus();
                return;
            }

            // Validar ángulo
            if (angulo <= 0 || angulo > 360)
            {
                MessageBox.Show("El ángulo debe estar entre 1 y 360 grados.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtAngulo.Focus();
                return;
            }

            // Cálculos
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

                Pen lapiz = new Pen(Color.Blue, 3);
                SolidBrush brocha = new SolidBrush(Color.LightBlue);

                float diametro = (float)radio * 6f;

                // Ajustar al panel
                if (diametro > pnlGrafico.Width - 30)
                    diametro = pnlGrafico.Width - 30;

                if (diametro > pnlGrafico.Height - 30)
                    diametro = pnlGrafico.Height - 30;

                // CENTRADO ARRIBA
                float x = (pnlGrafico.Width - diametro) / 2;
                float y = 20;

                // Abertura centrada al lado derecho
                float inicio = (float)(angulo / 2.0);
                float barrido = 360f - (float)angulo;

                g.FillPie(brocha, x, y, diametro, diametro, inicio, barrido);
                g.DrawPie(lapiz, x, y, diametro, diametro, inicio, barrido);

                // Dibujar arco exterior completo visible
                g.DrawArc(lapiz, x, y, diametro, diametro, inicio, barrido);
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