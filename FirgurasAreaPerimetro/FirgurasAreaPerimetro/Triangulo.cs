using System;
using System.Windows.Forms;

namespace FigurasAreaPerimetro
{
    class Triangulo
    {
        private float mLado;
        private float mAltura;
        private float mPerimeter;
        private float mArea;

        public void ReadData(TextBox txtLado, TextBox txtAltura)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLado.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLado.Text, out mLado) || mLado <= 0)
                {
                    MessageBox.Show("El valor de 'Lado' debe ser un número positivo.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtAltura.Text, out mAltura) || mAltura <= 0)
                {
                    MessageBox.Show("El valor de 'Altura' debe ser un número positivo.", "Mensaje de Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Mensaje de Error");
            }
        }


        public void PerimeterTriangle()
        {
            mPerimeter = 3 * mLado;
        }

        public void AreaTriangle()
        {
            mArea = (mLado * mAltura) / 2;
        }

        public void PrintData(TextBox txtLado, TextBox txtAltura, TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        public void InitializeData(TextBox txtLado, TextBox txtAltura, TextBox txtPerimeter, TextBox txtArea)
        {
            mLado = 0.0f;
            mAltura = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;

            txtLado.Text = "";
            txtAltura.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtLado.Focus();
        }
    }
}
