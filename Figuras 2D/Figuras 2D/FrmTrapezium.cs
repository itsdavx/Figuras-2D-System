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
    public partial class FrmTrapezium : Form
    {
        private static FrmTrapezium instancia;
        public FrmTrapezium()
        {
            InitializeComponent();
        }

        public static FrmTrapezium Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmTrapezium();
                }
                return instancia;
            }
        }
    }
}
