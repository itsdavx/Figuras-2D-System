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
    public partial class FrmSquare : Form
    {
        private static FrmSquare instancia;

        // TRASLACION
        private Traslation moverFigura = new Traslation(0, 0);

        public FrmSquare()
        {
            InitializeComponent();

            // ACTIVAR TECLADO
            this.KeyPreview = true;

            // EVENTO TECLADO
            this.KeyDown += FrmSquare_KeyDown;
        }

        public static FrmSquare Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmSquare();
                }
                return instancia;
            }
        }

        // MOVIMIENTO CON FLECHAS
        private void FrmSquare_KeyDown(object sender, KeyEventArgs e)
        {
            moverFigura.Mover(e);

            panelGrafico.Invalidate();
        }

        private bool Validar(out float tamano)
        {
            tamano = 0;

            string input = txtLado.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo no puede estar vacío");
                return false;
            }

            if (!float.TryParse(input, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out tamano))
            {
                MessageBox.Show("Ingrese un número válido (use punto para decimales)");
                return false;
            }

            if (tamano <= 0)
            {
                MessageBox.Show("El valor debe ser mayor que 0");
                return false;
            }

            return true;
        }

        float tamanoCm = 2f;
        int tamanoPx = 50;
        bool dibujar = false;

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!Validar(out tamanoCm))
            {
                dibujar = false;
                panelGrafico.Invalidate();
                return;
            }

            dibujar = true;

            tamanoPx = (int)(tamanoCm * 58f);

            panelGrafico.Width = tamanoPx + 20;
            panelGrafico.Height = tamanoPx + 20;

            panelGrafico.Invalidate();
        }

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (!dibujar) return;

            Graphics g = e.Graphics;

            int lado = tamanoPx;

            // CENTRADO + TRASLACION
            int x = ((panelGrafico.Width - lado) / 2) + moverFigura.X;
            int y = ((panelGrafico.Height - lado) / 2) + moverFigura.Y;

            Brush brocha = new SolidBrush(Color.LightBlue);

            Pen lapiz = new Pen(Color.Black, 2);

            g.FillRectangle(brocha, x, y, lado, lado);

            g.DrawRectangle(lapiz, x, y, lado, lado);
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}