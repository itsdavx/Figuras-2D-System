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
    public partial class FrmNonagon : Form
    {
        private static FrmNonagon instancia;
        public FrmNonagon()
        {
            InitializeComponent();
        }
        public static FrmNonagon Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmNonagon();
                }
                return instancia;
            }
        }
    }
}
