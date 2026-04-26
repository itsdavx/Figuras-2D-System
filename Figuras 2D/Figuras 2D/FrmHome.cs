using System;
using System.Windows.Forms;

namespace Figuras_2D
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void miCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCircle frmCircle = FrmCircle.Instancia;
            frmCircle.MdiParent = this;
            frmCircle.Show();
        }

        private void miEllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEllipse frmEllipse = FrmEllipse.Instancia;
            frmEllipse.MdiParent = this;
            frmEllipse.Show();
        }

        private void miOvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOval frmOval = FrmOval.Instancia;
            frmOval.MdiParent = this;
            frmOval.Show();
        }

        private void miSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare frmSquare = FrmSquare.Instancia;
            frmSquare.MdiParent = this;
            frmSquare.Show();
        }

        private void miRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangle frmRectangle = FrmRectangle.Instancia;
            frmRectangle.MdiParent = this;
            frmRectangle.Show();
        }

        private void miTrapeziumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezium frmTrapezium = FrmTrapezium.Instancia;
            frmTrapezium.MdiParent = this;
            frmTrapezium.Show();

        }

        private void miParallelogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParallelogram frmParallelogram = FrmParallelogram.Instancia;
            frmParallelogram.MdiParent = this;
            frmParallelogram.Show();
        }

        private void miRhombusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRhombus frmRhombus = FrmRhombus.Instancia;
            frmRhombus.MdiParent = this;
            frmRhombus.Show();
        }

        private void miKiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKite frmKite = FrmKite.Instancia;
            frmKite.MdiParent = this;
            frmKite.Show();
        }

        private void miTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangle frmTriangle = FrmTriangle.Instancia;
            frmTriangle.MdiParent = this;
            frmTriangle.Show();
        }

        private void miRightTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRightTriangle frmRightTriangle = FrmRightTriangle.Instancia;
            frmRightTriangle.MdiParent = this;
            frmRightTriangle.Show();
        }

        private void miScaleneTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScaleneTriangle frmScaleneTriangle = FrmScaleneTriangle.Instancia;
            frmScaleneTriangle.MdiParent = this;
            frmScaleneTriangle.Show();
        }

        private void miPentagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagon frmPentagon = FrmPentagon.Instancia;
            frmPentagon.MdiParent = this;
            frmPentagon.Show();
        }

        private void miHexagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagon frmHexagon = FrmHexagon.Instancia;
            frmHexagon.MdiParent = this;
            frmHexagon.Show();
        }

        private void miHeptagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeptagon frmHeptagon = FrmHeptagon.Instancia;
            frmHeptagon.MdiParent = this;
            frmHeptagon.Show();
        }

        private void miOctagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagon frmOctagon = FrmOctagon.Instancia;
            frmOctagon.MdiParent = this;
            frmOctagon.Show();
        }

        private void miNonagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNonagon frmNonagon = FrmNonagon.Instancia;
            frmNonagon.MdiParent = this;
            frmNonagon.Show();
        }

        private void miDecagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDecagon frmDecagon = FrmDecagon.Instancia;
            frmDecagon.MdiParent = this;
            frmDecagon.Show();
        }

        private void miStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStar frmStar = FrmStar.Instancia;
            frmStar.MdiParent = this;
            frmStar.Show();
        }

        private void miHeartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeart frmHeart = FrmHeart.Instancia;
            frmHeart.MdiParent = this;
            frmHeart.Show();
        }

        private void miCrescentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrescent frmCrescent = FrmCrescent.Instancia;
            frmCrescent.MdiParent = this;
            frmCrescent.Show();
        }

        private void miCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCross frmCross = FrmCross.Instancia;
            frmCross.MdiParent = this;
            frmCross.Show();
        }

        private void miPieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPie frmPie = FrmPie.Instancia;
            frmPie.MdiParent = this;
            frmPie.Show();
        }

        private void miArrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArrow frmArrow = FrmArrow.Instancia;
            frmArrow.MdiParent = this;
            frmArrow.Show();
        }
    }
}
