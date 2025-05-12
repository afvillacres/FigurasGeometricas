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
    public partial class FrmDecagono : Form
    {
        private static FrmDecagono instancia;
        private Decagono ObjDecagono = new Decagono();

        public FrmDecagono()
        {
            InitializeComponent();
        }

        public static FrmDecagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmDecagono();
            }
            return instancia;
        }

        private void FrmDecagono_Load(object sender, EventArgs e)
        {
            ObjDecagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjDecagono.ReadData(txtLado, txtApotema);
            ObjDecagono.PerimeterDecagono();
            ObjDecagono.AreaDecagono();
            ObjDecagono.PrintData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjDecagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

    }
}
