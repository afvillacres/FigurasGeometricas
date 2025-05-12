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
    public partial class FrmCirculo : Form
    {
        private static FrmCirculo instancia;
        private Circulo ObjCirculo = new Circulo();

        public FrmCirculo()
        {
            InitializeComponent();
        }

        public static FrmCirculo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmCirculo();
            }
            return instancia;
        }

        private void FrmCirculo_Load(object sender, EventArgs e)
        {
            ObjCirculo.InitializeData(txtRadio, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjCirculo.ReadData(txtRadio);
            ObjCirculo.PerimeterCirculo();
            ObjCirculo.AreaCirculo();
            ObjCirculo.PrintData(txtRadio, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjCirculo.InitializeData(txtRadio, txtPerimetro, txtArea);
        }
    }
}