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
    public partial class FrmHeptagon : Form
    {
        private static FrmHeptagon instancia;
        public FrmHeptagon()
        {
            InitializeComponent();
        }
        public static FrmHeptagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmHeptagon();
                }
                return instancia;
            }
        }
    }
}
