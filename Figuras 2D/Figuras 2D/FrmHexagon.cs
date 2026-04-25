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
    public partial class FrmHexagon : Form
    {
        private static FrmHexagon instancia;
        public FrmHexagon()
        {
            InitializeComponent();
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
    }
}
