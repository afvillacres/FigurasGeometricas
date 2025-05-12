using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    class Rombo
    {
        private float mLado;
        private float mLargo; // Diagonal mayor
        private float mAncho; // Diagonal menor
        private float mPerimetro;
        private float mArea;

        public void ReadData(TextBox txtLado, TextBox txtLargo, TextBox txtAncho)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLado.Text) || string.IsNullOrWhiteSpace(txtLargo.Text) ||
                    string.IsNullOrWhiteSpace(txtAncho.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLado.Text, out mLado) || mLado <= 0 ||
                    !float.TryParse(txtLargo.Text, out mLargo) || mLargo <= 0 ||
                    !float.TryParse(txtAncho.Text, out mAncho) || mAncho <= 0)
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


        public void PerimeterRombo()
        {
            mPerimetro = 4 * mLado;
        }

        public void AreaRombo()
        {
            mArea = (mLargo * mAncho) / 2;
        }

        public void PrintData(TextBox txtLado, TextBox txtLargo, TextBox txtAncho, TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado, TextBox txtLargo, TextBox txtAncho, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = mLargo = mAncho = mPerimetro = mArea = 0.0f;

            txtLado.Text = "";
            txtLargo.Text = "";
            txtAncho.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLado.Focus();
        }
    }
}