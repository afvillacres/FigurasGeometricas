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
    public partial class FrmRomboide : Form
    {
        private static FrmRomboide instancia;
        private Romboide ObjRomboide = new Romboide();

        public FrmRomboide()
        {
            InitializeComponent();
        }

        public static FrmRomboide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRomboide();
            }
            return instancia;
        }

        private void FrmRomboide_Load(object sender, EventArgs e)
        {
            ObjRomboide.InitializeData(txtLado, txtBase, txtAltura, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjRomboide.ReadData(txtLado, txtBase, txtAltura);
            ObjRomboide.PerimeterRomboide();
            ObjRomboide.AreaRomboide();
            ObjRomboide.PrintData(txtLado, txtBase, txtAltura, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjRomboide.InitializeData(txtLado, txtBase, txtAltura, txtPerimetro, txtArea);
        }
    }
}