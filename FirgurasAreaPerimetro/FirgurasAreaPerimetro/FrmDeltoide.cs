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
    public partial class FrmDeltoide : Form
    {
        private static FrmDeltoide instancia;
        private Deltoide ObjDeltoide = new Deltoide();

        public FrmDeltoide()
        {
            InitializeComponent();
        }

        public static FrmDeltoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmDeltoide();
            }
            return instancia;
        }

        private void FrmDeltoide_Load(object sender, EventArgs e)
        {
            ObjDeltoide.InitializeData(txtLadoA, txtLadoB, txtLargo, txtAncho, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjDeltoide.ReadData(txtLadoA, txtLadoB, txtLargo, txtAncho);
            ObjDeltoide.PerimeterDeltoide();
            ObjDeltoide.AreaDeltoide();
            ObjDeltoide.PrintData(txtLadoA, txtLadoB, txtLargo, txtAncho, txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjDeltoide.InitializeData(txtLadoA, txtLadoB, txtLargo, txtAncho, txtPerimetro, txtArea);
        }
    }
}
