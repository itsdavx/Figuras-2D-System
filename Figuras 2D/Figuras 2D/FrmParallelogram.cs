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
    public partial class FrmParallelogram : Form  
    {
        private static FrmParallelogram instancia;
        public FrmParallelogram()
        {
            InitializeComponent();
        }
        public static FrmParallelogram Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmParallelogram();
                }
                return instancia;
            }
        }
    }
}
