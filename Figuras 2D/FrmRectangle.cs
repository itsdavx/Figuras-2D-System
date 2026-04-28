using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figuras_2D
{
    public partial class FrmRectangle : Form
    {
        private static FrmRectangle instancia;
        // Añadidos: variables para el dibujo
        private double anchoDibujo = 0;
        private double largoDibujo = 0;

        public FrmRectangle()
        {
            InitializeComponent();
        }

        public static FrmRectangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmRectangle();
                }
                return instancia;
            }
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Declaración de variables
            double ancho, largo, perimetro, area;

            // 2. Validación y Conversión
            // TryParse intenta convertir el texto a número. Si falla o es negativo, entra al error.
            if (!double.TryParse(txtAncho.Text, out ancho) || ancho <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido y positivo para el Ancho.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAncho.Focus();
                return; // Detiene la ejecución
            }

            if (!double.TryParse(txtLargo.Text, out largo) || largo <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido y positivo para el Largo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLargo.Focus();
                return;
            }

            // 3. Procesamiento (Cálculos)
            perimetro = 2 * (ancho + largo);
            area = ancho * largo;

            // 4. Salida de resultados (usar los controles correctos)
            txtPerimeter.Text = perimetro.ToString("N2"); // Perímetro con 2 decimales
            txtArea.Text = area.ToString("N2");           // Área con 2 decimales

            // Usar los mismos textboxes de entrada para el dibujo (txtAncho / txtLargo)
            if (double.TryParse(txtAncho.Text, out anchoDibujo) && double.TryParse(txtLargo.Text, out largoDibujo))
            {
                // Actualizar textos si se quiere mostrar valores sin formato
                txtPerimeter.Text = (2 * (anchoDibujo + largoDibujo)).ToString("N2");
                txtArea.Text = (anchoDibujo * largoDibujo).ToString("N2");

                // FORZAR AL PANEL A DIBUJAR
                pnlGrafico.Invalidate();
            }

            // 5. Llamada al método para dibujar (Opcional si ya lo tienes)
            DibujarRectangulo(ancho, largo);
        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            if (anchoDibujo > 0 && largoDibujo > 0)
            {
                Graphics g = e.Graphics;
                Pen lapiz = new Pen(Color.Blue, 3); // Rectángulo azul con grosor 3

                // Factor de escala para que se vea bien (ajusta el 10 según necesites)
                float escala = 10;
                float w = (float)anchoDibujo * escala;
                float h = (float)largoDibujo * escala;

                // Centrar el dibujo en el panel
                float x = (pnlGrafico.Width - w) / 2;
                float y = (pnlGrafico.Height - h) / 2;

                g.DrawRectangle(lapiz, x, y, w, h);

                // Opcional: Rellenar con un color suave
                SolidBrush brocha = new SolidBrush(Color.FromArgb(100, Color.LightBlue));
                g.FillRectangle(brocha, x, y, w, h);
            }
        }

        // Método auxiliar (si existe en tu clase original)
        private void DibujarRectangulo(double ancho, double largo)
        {
            // Si quieres usar este método para actualizar anchoDibujo/largoDibujo, hazlo aquí.
            // Ejemplo básico:
            anchoDibujo = ancho;
            largoDibujo = largo;
            pnlGrafico.Invalidate();
        }
    }
}