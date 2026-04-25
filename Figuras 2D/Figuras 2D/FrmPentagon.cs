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
    public partial class FrmPentagon : Form
    {
        private static FrmPentagon instancia;
        public FrmPentagon()
        {
            InitializeComponent();
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
    }
}
