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
    public partial class FrmEneagono : Form
    {
        private static FrmEneagono instancia;
        private Eneagono ObjEneagono = new Eneagono();

        public FrmEneagono()
        {
            InitializeComponent();
        }

        public static FrmEneagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmEneagono();
            }
            return instancia;
        }

        private void FrmEneagono_Load(object sender, EventArgs e)
        {
            ObjEneagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjEneagono.ReadData(txtLado, txtApotema);
            ObjEneagono.PerimeterEneagono();
            ObjEneagono.AreaEneagono();
            ObjEneagono.PrintData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjEneagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }
    }
}