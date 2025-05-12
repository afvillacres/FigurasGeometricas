using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    class TrapecioIsoceles
    {
        private float mLado;
        private float mAltura;
        private float mBaseA; // base mayor
        private float mBaseB; // base menor
        private float mPerimetro;
        private float mArea;

        public void ReadData(TextBox txtLado, TextBox txtAltura, TextBox txtBaseA, TextBox txtBaseB)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLado.Text) || string.IsNullOrWhiteSpace(txtAltura.Text) ||
                    string.IsNullOrWhiteSpace(txtBaseA.Text) || string.IsNullOrWhiteSpace(txtBaseB.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLado.Text, out mLado) || mLado <= 0 ||
                    !float.TryParse(txtAltura.Text, out mAltura) || mAltura <= 0 ||
                    !float.TryParse(txtBaseA.Text, out mBaseA) || mBaseA <= 0 ||
                    !float.TryParse(txtBaseB.Text, out mBaseB) || mBaseB <= 0)
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos positivos válidos.", "Error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error.", "Error");
            }
        }


        public void PerimeterTrapecio()
        {
            mPerimetro = mBaseA + mBaseB + 2 * mLado;
        }

        public void AreaTrapecio()
        {
            mArea = ((mBaseA + mBaseB) * mAltura) / 2;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado, TextBox txtAltura, TextBox txtBaseA, TextBox txtBaseB, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = mAltura = mBaseA = mBaseB = mPerimetro = mArea = 0.0f;

            txtLado.Text = "";
            txtAltura.Text = "";
            txtBaseA.Text = "";
            txtBaseB.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLado.Focus();
        }
    }
}