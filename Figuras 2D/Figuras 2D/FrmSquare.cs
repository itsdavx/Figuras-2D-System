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
        public FrmSquare()
        {
            InitializeComponent();
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
    }
}
