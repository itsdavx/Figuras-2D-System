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
    public partial class FrmOctagon : Form
    {
        private static FrmOctagon instancia;
        public FrmOctagon()
        {
            InitializeComponent();
        }
        public static FrmOctagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmOctagon();
                }
                return instancia;
            }
        }
    }
}
