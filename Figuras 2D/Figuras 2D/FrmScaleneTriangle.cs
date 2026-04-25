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
    public partial class FrmScaleneTriangle : Form
    {
        private static FrmScaleneTriangle instancia;
        public FrmScaleneTriangle()
        {
            InitializeComponent();
        }

        public static FrmScaleneTriangle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmScaleneTriangle();
                }
                return instancia;
            }
        }
    }
}
