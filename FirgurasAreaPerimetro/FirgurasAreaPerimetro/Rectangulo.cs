using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    class Rectangulo
    {
        private float mLargo;
        private float mAncho;
        private float mPerimetro;
        private float mArea;

        public void ReadData(TextBox txtLargo, TextBox txtAncho)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLargo.Text) || string.IsNullOrWhiteSpace(txtAncho.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLargo.Text, out mLargo) || mLargo <= 0 ||
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

        public void PerimeterRectangulo()
        {
            mPerimetro = 2 * (mLargo + mAncho);
        }

        public void AreaRectangulo()
        {
            mArea = mLargo * mAncho;
        }

        public void PrintData(TextBox txtLargo, TextBox txtAncho, TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLargo, TextBox txtAncho, TextBox txtPerimetro, TextBox txtArea)
        {
            mLargo = mAncho = mPerimetro = mArea = 0.0f;

            txtLargo.Text = "";
            txtAncho.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLargo.Focus();
        }
    }
}