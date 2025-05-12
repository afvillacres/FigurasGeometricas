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
    public partial class FrmElipse : Form
    {
        private static FrmElipse instancia;
        private Elipse ObjElipse = new Elipse();

        public FrmElipse()
        {
            InitializeComponent();
        }

        public static FrmElipse ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmElipse();
            }
            return instancia;
        }

        private void FrmElipse_Load(object sender, EventArgs e)
        {
            ObjElipse.InitializeData(txtLargo, txtAncho, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjElipse.ReadData(txtLargo, txtAncho);
            ObjElipse.PerimeterElipse();
            ObjElipse.AreaElipse();
            ObjElipse.PrintData(txtLargo, txtAncho, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjElipse.InitializeData(txtLargo, txtAncho, txtPerimetro, txtArea);
        }
    }
}