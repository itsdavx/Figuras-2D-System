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
    public partial class FrmCross : Form
    {
        private static FrmCross instancia;
        public FrmCross()
        {
            InitializeComponent();
        }
        public static FrmCross Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmCross();
                }
                return instancia;
            }
        }
    }
}
