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
    public partial class FrmHeart : Form
    {
        private static FrmHeart instancia;
        public FrmHeart()
        {
            InitializeComponent();
        }
        public static FrmHeart Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new FrmHeart();
                }
                return instancia;
            }
        }
    }
}