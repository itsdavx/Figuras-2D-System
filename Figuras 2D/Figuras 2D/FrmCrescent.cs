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
    public partial class FrmCrescent : Form
    {
        private static FrmCrescent instancia;
        public FrmCrescent()
        {
            InitializeComponent();
        }
        public static FrmCrescent Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmCrescent();
                }
                return instancia;
            }
        }
    }
}
