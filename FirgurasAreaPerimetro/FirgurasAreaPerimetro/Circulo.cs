using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FirgurasAreaPerimetro
{
    class Circulo
    {
        private float mRadio;
        private float mPerimeter;
        private float mArea;

        public void ReadData(TextBox txtRadio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRadio.Text))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtRadio.Text, out mRadio) || mRadio <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico positivo válido para el radio.", "Error de entrada");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error.", "Error");
            }
        }


        public void PerimeterCirculo()
        {
            mPerimeter = 2 * (float)Math.PI * mRadio;
        }

        public void AreaCirculo()
        {
            mArea = (float)Math.PI * mRadio * mRadio;
        }

        public void PrintData(TextBox txtRadio, TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtRadio, TextBox txtPerimetro, TextBox txtArea)
        {
            mRadio = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtRadio.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtRadio.Focus();
        }
    }
}
