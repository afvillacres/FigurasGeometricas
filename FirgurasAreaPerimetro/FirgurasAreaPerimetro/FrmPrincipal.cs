using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuadrado = FrmCuadrado.ObtenerInstancia();
            frmCuadrado.MdiParent = this;
            if (!frmCuadrado.Visible)
            {
                frmCuadrado.Show();
            }
            else
            {
                frmCuadrado.BringToFront();
            }
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeltoide frmDeltoide = FrmDeltoide.ObtenerInstancia();
            frmDeltoide.MdiParent = this;
            if (!frmDeltoide.Visible)
            {
                frmDeltoide.Show();
            }
            else
            {
                frmDeltoide.BringToFront();
            }
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frmRectangulo = FrmRectangulo.ObtenerInstancia();
            frmRectangulo.MdiParent = this;
            if (!frmRectangulo.Visible)
            {
                frmRectangulo.Show();
            }
            else
            {
                frmRectangulo.BringToFront();
            }
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRombo = FrmRombo.ObtenerInstancia();
            frmRombo.MdiParent = this;
            if (!frmRombo.Visible)
            {
                frmRombo.Show();
            }
            else
            {
                frmRombo.BringToFront();
            }
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frmTriangulo = FrmTriangulo.ObtenerInstancia();
            frmTriangulo.MdiParent = this;
            if (!frmTriangulo.Visible)
            {
                frmTriangulo.Show();
            }
            else
            {
                frmTriangulo.BringToFront();
            }
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRomboide frmRomboide = FrmRomboide.ObtenerInstancia();
            frmRomboide.MdiParent = this;
            if (!frmRomboide.Visible)
            {
                frmRomboide.Show();
            }
            else
            {
                frmRomboide.BringToFront();
            }
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecio frmTrapecio = FrmTrapecio.ObtenerInstancia();
            frmTrapecio.MdiParent = this;
            if (!frmTrapecio.Visible)
            {
                frmTrapecio.Show();
            }
            else
            {
                frmTrapecio.BringToFront();
            }
        }

        private void trapecioIsocelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapecioIsoceles frmTrapecioIsoceles = FrmTrapecioIsoceles.ObtenerInstancia();
            frmTrapecioIsoceles.MdiParent = this;
            if (!frmTrapecioIsoceles.Visible)
            {
                frmTrapecioIsoceles.Show();
            }
            else
            {
                frmTrapecioIsoceles.BringToFront();
            }
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoide frmTrapezoide = FrmTrapezoide.ObtenerInstancia();
            frmTrapezoide.MdiParent = this;
            if (!frmTrapezoide.Visible)
            {
                frmTrapezoide.Show();
            }
            else
            {
                frmTrapezoide.BringToFront();
            }
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagono frmPentagono = FrmPentagono.ObtenerInstancia();
            frmPentagono.MdiParent = this;
            if (!frmPentagono.Visible)
            {
                frmPentagono.Show();
            }
            else
            {
                frmPentagono.BringToFront();
            }
        }

        private void hexágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagono frmHexagono = FrmHexagono.ObtenerInstancia();
            frmHexagono.MdiParent = this;
            if (!frmHexagono.Visible)
            {
                frmHexagono.Show();
            }
            else
            {
                frmHexagono.BringToFront();
            }
        }

        private void heptágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeptagono frmHeptagono = FrmHeptagono.ObtenerInstancia();
            frmHeptagono.MdiParent = this;
            if (!frmHeptagono.Visible)
            {
                frmHeptagono.Show();
            }
            else
            {
                frmHeptagono.BringToFront();
            }
        }

        private void octágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagono frmOctagono = FrmOctagono.ObtenerInstancia();
            frmOctagono.MdiParent = this;
            if (!frmOctagono.Visible)
            {
                frmOctagono.Show();
            }
            else
            {
                frmOctagono.BringToFront();
            }
        }

        private void eneágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEneagono frmEneagono = FrmEneagono.ObtenerInstancia();
            frmEneagono.MdiParent = this;
            if (!frmEneagono.Visible)
            {
                frmEneagono.Show();
            }
            else
            {
                frmEneagono.BringToFront();
            }
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frmCirculo = FrmCirculo.ObtenerInstancia();
            frmCirculo.MdiParent = this;
            if (!frmCirculo.Visible)
            {
                frmCirculo.Show();
            }
            else
            {
                frmCirculo.BringToFront();
            }
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElipse frmElipse = FrmElipse.ObtenerInstancia();
            frmElipse.MdiParent = this;
            if (!frmElipse.Visible)
            {
                frmElipse.Show();
            }
            else
            {
                frmElipse.BringToFront();
            }
        }
    }
}