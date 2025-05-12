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
    public partial class FrmCuadrado : Form
    {
        private static FrmCuadrado instancia;
        private Cuadrado ObjCuadrado = new Cuadrado();

        public FrmCuadrado()
        {
            InitializeComponent();
        }

        public static FrmCuadrado ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmCuadrado();
            }
            return instancia;
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            ObjCuadrado.InitializeData(txtLado, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCuadrado.ReadData(txtLado);
            ObjCuadrado.PerimeterCuadrado();
            ObjCuadrado.AreaCuadrado();
            ObjCuadrado.PrintData(txtLado, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjCuadrado.InitializeData(txtLado, txtPerimetro, txtArea);
        }
    }
}
