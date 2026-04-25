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
    public partial class FrmPie : Form
    {
        private static FrmPie instancia;
        public FrmPie()
        {
            InitializeComponent();
        }
        public static FrmPie Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmPie();
                }
                return instancia;
            }
        }
    }
}
