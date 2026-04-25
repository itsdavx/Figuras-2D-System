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
    public partial class FrmEllipse : Form
    {
        private static FrmEllipse instancia;
        public FrmEllipse()
        {
            InitializeComponent();
        }

        public static FrmEllipse Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmEllipse();
                }
                return instancia;
            }
        }
    }
}
