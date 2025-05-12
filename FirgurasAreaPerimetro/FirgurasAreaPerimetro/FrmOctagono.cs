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
    public partial class FrmOctagono : Form
    {
        private static FrmOctagono instancia;
        private Octagono ObjOctagono = new Octagono();

        public FrmOctagono()
        {
            InitializeComponent();
        }

        public static FrmOctagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmOctagono();
            }
            return instancia;
        }

        private void FrmOctagono_Load(object sender, EventArgs e)
        {
            ObjOctagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjOctagono.ReadData(txtLado, txtApotema);
            ObjOctagono.PerimeterOctagono();
            ObjOctagono.AreaOctagono();
            ObjOctagono.PrintData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjOctagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }
    }
}