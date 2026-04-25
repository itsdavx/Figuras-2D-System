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
    public partial class FrmArrow : Form
    {
        private static FrmArrow instancia;
        public FrmArrow()
        {
            InitializeComponent();
        }
        public static FrmArrow Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmArrow();
                }
                return instancia;
            }
        }
    }
}
