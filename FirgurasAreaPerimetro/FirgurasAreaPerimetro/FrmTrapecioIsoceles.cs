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
    public partial class FrmTrapecioIsoceles : Form
    {
        private static FrmTrapecioIsoceles instancia;
        private TrapecioIsoceles ObjTrapecio = new TrapecioIsoceles();

        public FrmTrapecioIsoceles()
        {
            InitializeComponent();
        }

        public static FrmTrapecioIsoceles ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTrapecioIsoceles();
            }
            return instancia;
        }

        private void FrmTrapecioIsoceles_Load(object sender, EventArgs e)
        {
            ObjTrapecio.InitializeData(txtLado, txtAltura, txtBaseA, txtBaseB, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTrapecio.ReadData(txtLado, txtAltura, txtBaseA, txtBaseB);
            ObjTrapecio.PerimeterTrapecio();
            ObjTrapecio.AreaTrapecio();
            ObjTrapecio.PrintData(txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjTrapecio.InitializeData(txtLado, txtAltura, txtBaseA, txtBaseB, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

        }
    }
}
