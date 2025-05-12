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
    class Cuadrado
    {
        private float mLado;
        private float mPerimeter;
        private float mArea;

        public void ReadData(TextBox txtLado)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLado.Text))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLado.Text, out mLado) || mLado <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico positivo válido.", "Error de entrada");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error.", "Error");
            }
        }


        public void PerimeterCuadrado()
        {
            mPerimeter = 4 * mLado;
        }

        public void AreaCuadrado()
        {
            mArea = mLado * mLado;
        }

        public void PrintData(TextBox txtLado, TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado, TextBox txtPerimetro, TextBox txtArea)
        {
            mLado = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtLado.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLado.Focus();
        }
    }
}
