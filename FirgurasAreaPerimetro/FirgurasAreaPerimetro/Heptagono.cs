using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    class Heptagono
    {
        private float mLado;
        private float mApotema;
        private float mPerimetro;
        private float mArea;

        public void ReadData(TextBox txtLado, TextBox txtApotema)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLado.Text) || string.IsNullOrWhiteSpace(txtApotema.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLado.Text, out mLado) || mLado <= 0 ||
                    !float.TryParse(txtApotema.Text, out mApotema) || mApotema <= 0)
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


        public void PerimeterHeptagono()
        {
            mPerimetro = 7 * mLado;
        }

        public void AreaHeptagono()
        {
            mArea = (mPerimetro * mApotema) / 2;
        }

        public void PrintData(TextBox txtLado, TextBox txtApotema, TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado, TextBox txtApotema, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = mApotema = mPerimetro = mArea = 0.0f;

            txtLado.Text = "";
            txtApotema.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLado.Focus();
        }
    }
}
