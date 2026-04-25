using System;
using System.Windows.Forms;

namespace Figuras_2D
{
    public partial class FrmCircle : Form
    {
        private static FrmCircle instancia;

        private FrmCircle()
        {
            InitializeComponent();
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
    }
}