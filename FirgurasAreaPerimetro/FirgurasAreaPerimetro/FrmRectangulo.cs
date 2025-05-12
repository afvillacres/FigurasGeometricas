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
    public partial class FrmRectangulo : Form
    {
        private static FrmRectangulo instancia;
        private Rectangulo ObjRectangulo = new Rectangulo();

        public FrmRectangulo()
        {
            InitializeComponent();
        }

        public static FrmRectangulo ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRectangulo();
            }
            return instancia;
        }

        private void FrmRectangulo_Load(object sender, EventArgs e)
        {
            ObjRectangulo.InitializeData(txtLargo, txtAncho, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRectangulo.ReadData(txtLargo, txtAncho);
            ObjRectangulo.PerimeterRectangulo();
            ObjRectangulo.AreaRectangulo();
            ObjRectangulo.PrintData(txtLargo, txtAncho, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjRectangulo.InitializeData(txtLargo, txtAncho, txtPerimetro, txtArea);
        }
    }
}