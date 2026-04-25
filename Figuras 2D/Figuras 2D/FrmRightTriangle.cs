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
    public partial class FrmRightTriangle : Form
    {
        private static FrmRightTriangle instancia;
        public FrmRightTriangle()
        {
            InitializeComponent();
        }
        public static FrmRightTriangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmRightTriangle();
                }
                return instancia;
            }
        }
    }
}
