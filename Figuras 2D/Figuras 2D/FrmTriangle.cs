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
    public partial class FrmTriangle : Form
    {
        private static FrmTriangle instancia;
        public FrmTriangle()
        {
            InitializeComponent();
        }

        public static FrmTriangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmTriangle();
                }
                return instancia;
            }
        }
    }
}
