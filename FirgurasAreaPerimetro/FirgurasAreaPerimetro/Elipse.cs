using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    class Elipse
    {
        private float a; // Semieje mayor
        private float b; // Semieje menor
        private float area;
        private float perimeter;

        public void ReadData(TextBox txtLargo, TextBox txtAncho)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLargo.Text) || string.IsNullOrWhiteSpace(txtAncho.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtLargo.Text, out a) || a <= 0 ||
                    !float.TryParse(txtAncho.Text, out b) || b <= 0)
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


        public void AreaElipse()
        {
            area = (float)(Math.PI * a * b);
        }

        public void PerimeterElipse()
        {
            // Fórmula de Ramanujan (aproximada)
            perimeter = (float)(Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))));
        }

        public void PrintData(TextBox txtLargo, TextBox txtAncho, TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimeter.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

        public void InitializeData(TextBox txtLargo, TextBox txtAncho, TextBox txtPerimetro, TextBox txtArea)
        {
            a = b = area = perimeter = 0.0f;

            txtLargo.Text = "";
            txtAncho.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtLargo.Focus();
        }
    }
}