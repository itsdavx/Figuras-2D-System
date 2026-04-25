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
    public partial class FrmOval : Form
    {
        private static FrmOval _instancia;
        public FrmOval()
        {
            InitializeComponent();
        }
        
        public static FrmOval Instancia
        {
            get
            {
                if (_instancia == null || _instancia.IsDisposed)
                {
                    _instancia = new FrmOval();
                }
                return _instancia;
            }
        }
    }
}
