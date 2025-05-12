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
    public partial class FrmTrapecio : Form
    {
        private Trapecio trapecio = new Trapecio();
        private static FrmTrapecio instancia;

        public FrmTrapecio()
        {
            InitializeComponent();
        }

        public static FrmTrapecio ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmTrapecio();
            }
            return instancia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapecio.ReadData(txtLadoA, txtLadoB, txtLadoC, txtLadoD, txtAltura);

            trapecio.PerimeterTrapezoide();
            trapecio.AreaTrapezoide();

            trapecio.PrintData(txtPerimetro, txtArea);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            trapecio.InitializeData(txtLadoA, txtLadoB, txtLadoC, txtLadoD, txtAltura, txtPerimetro, txtArea);
        }
    }
}