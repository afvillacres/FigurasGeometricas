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
    public partial class FrmHeptagono : Form
    {
        private static FrmHeptagono instancia;
        private Heptagono ObjHeptagono = new Heptagono();

        public FrmHeptagono()
        {
            InitializeComponent();
        }

        public static FrmHeptagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmHeptagono();
            }
            return instancia;
        }

        private void FrmHeptagono_Load(object sender, EventArgs e)
        {
            ObjHeptagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjHeptagono.ReadData(txtLado, txtApotema);
            ObjHeptagono.PerimeterHeptagono();
            ObjHeptagono.AreaHeptagono();
            ObjHeptagono.PrintData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjHeptagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }
    }
}

