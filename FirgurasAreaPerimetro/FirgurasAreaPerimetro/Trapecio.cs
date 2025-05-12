using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirgurasAreaPerimetro
{
    class Trapecio
    {
        private float ladoA, ladoB, ladoC, ladoD, altura;
        private float perimetro, area;

        public void ReadData(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtAltura)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text) ||
                    string.IsNullOrWhiteSpace(txtC.Text) || string.IsNullOrWhiteSpace(txtD.Text) ||
                    string.IsNullOrWhiteSpace(txtAltura.Text))
                {
                    MessageBox.Show("Los campos no pueden estar vacíos.", "Mensaje de Error");
                    return;
                }

                if (!float.TryParse(txtA.Text, out ladoA) || ladoA <= 0 ||
                    !float.TryParse(txtB.Text, out ladoB) || ladoB <= 0 ||
                    !float.TryParse(txtC.Text, out ladoC) || ladoC <= 0 ||
                    !float.TryParse(txtD.Text, out ladoD) || ladoD <= 0 ||
                    !float.TryParse(txtAltura.Text, out altura) || altura <= 0)
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


        public void PerimeterTrapezoide()
        {
            perimetro = ladoA + ladoB + ladoC + ladoD;
        }

        public void AreaTrapezoide()
        {
            area = ((ladoA + ladoC) * altura) / 2;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = perimetro.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

        public void InitializeData(TextBox txtA, TextBox txtB, TextBox txtC, TextBox txtD, TextBox txtAltura, TextBox txtPerimetro, TextBox txtArea)
        {
            ladoA = ladoB = ladoC = ladoD = altura = perimetro = area = 0.0f;

            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtAltura.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtA.Focus();
        }
    }
}
