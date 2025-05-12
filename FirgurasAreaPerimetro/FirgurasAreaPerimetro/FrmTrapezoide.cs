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
    public partial class FrmTrapezoide : Form
    {
        private static FrmTrapezoide instancia;
        private Trapezoide ObjTrapezoide = new Trapezoide();

        public FrmTrapezoide()
        {
            InitializeComponent();
        }

        public static FrmTrapezoide ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTrapezoide();
            }
            return instancia;
        }

        private void FrmTrapezoide_Load(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtLadoA, txtLadoB, txtLadoC, txtLadoD, txtAltura, txtPerimetro, txtArea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.ReadData(txtLadoA, txtLadoB, txtLadoC, txtLadoD, txtAltura);
            ObjTrapezoide.PerimeterTrapezoide();
            ObjTrapezoide.AreaTrapezoide();
            ObjTrapezoide.PrintData(txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtLadoA, txtLadoB, txtLadoC, txtLadoD, txtAltura, txtPerimetro, txtArea);
        }
    }
}