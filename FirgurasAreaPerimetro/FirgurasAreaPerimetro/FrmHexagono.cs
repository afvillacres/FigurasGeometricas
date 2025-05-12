using FigurasAreaPerimetro;
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
    public partial class FrmHexagono : Form
    {
        private static FrmHexagono instancia;

        private Hexagono ObjHexagono = new Hexagono();

        public FrmHexagono()
        {
            InitializeComponent();
        }

        public static FrmHexagono ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmHexagono();
            }
            return instancia;
        }

        private void FrmHexagono_Load(object sender, EventArgs e)
        {
            ObjHexagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjHexagono.ReadData(txtLado, txtApotema);
            ObjHexagono.PerimeterHexagono();
            ObjHexagono.AreaHexagono();
            ObjHexagono.PrintData(txtLado, txtApotema, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjHexagono.InitializeData(txtLado, txtApotema, txtPerimetro, txtArea);
        }
    }
}