using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    class Romboide
    {
        private float mLado;
        private float mBase;
        private float mAltura;
        private float mPerimetro;
        private float mArea;

        public void ReadData(TextBox txtLado, TextBox txtBase, TextBox txtAltura)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLado.Text) || string.IsNullOrWhiteSpace(txtBase.Text) ||
                    string.IsNullOrWhiteSpace(txtAltura.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLado.Text, out mLado) || mLado <= 0 ||
                    !float.TryParse(txtBase.Text, out mBase) || mBase <= 0 ||
                    !float.TryParse(txtAltura.Text, out mAltura) || mAltura <= 0)
                {
                    MessageBox.Show("Por favor, ingresa valores numéricos positivos válidos.", "Error de entrada");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error.", "Error");
            }
        }


        public void PerimeterRomboide()
        {
            mPerimetro = 2 * (mLado + mBase);
        }

        public void AreaRomboide()
        {
            mArea = mBase * mAltura;
        }

        public void PrintData(TextBox txtLado, TextBox txtBase, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado, TextBox txtBase, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = mBase = mAltura = mPerimetro = mArea = 0.0f;

            txtLado.Text = "";
            txtBase.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLado.Focus();
        }
    }
}