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
    public partial class Angle : Form
    {
        private static Angle instancia;
        public Angle()
        {
            InitializeComponent();
        }
        public static Angle Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new Angle();
                }
                return instancia;
            }
        }

        private void FrmPie_Load(object sender, EventArgs e)
        {

        }
    }
}
