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
    public partial class FrmTriangulo : Form
    {
        private static FrmTriangulo instancia;

        private Triangulo ObjTriangulo = new Triangulo();

        public FrmTriangulo()
        {
            InitializeComponent();
        }

        public static FrmTriangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTriangulo();
            }
            return instancia;
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {
            ObjTriangulo.InitializeData(txtLado, txtAltura, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTriangulo.ReadData(txtLado, txtAltura);
            ObjTriangulo.PerimeterTriangle();
            ObjTriangulo.AreaTriangle();
            ObjTriangulo.PrintData(txtLado, txtAltura, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjTriangulo.InitializeData(txtLado, txtAltura, txtPerimetro, txtArea);
        }
    }
}
