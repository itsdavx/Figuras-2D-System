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
    public partial class FrmKite : Form
    {
        private static FrmKite instancia;
        public FrmKite()
        {
            InitializeComponent();
        }

        public static FrmKite Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmKite();
                }
                return instancia;
            }
        }
    }
}
