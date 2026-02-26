using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Pseudoaleatorios
{
    public partial class CuadradosMedios : Form
    {
        public CuadradosMedios()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSemilla.Text))
            {
                MessageBox.Show("Ingrese una semilla de 4 dígitos.");
                return;
            }

            string semillaActual = txtSemilla.Text;

            if (!int.TryParse(semillaActual, out _))
            {
                MessageBox.Show("La semilla debe contener solo números.");
                return;
            }
            /*
            if (semillaActual.Length != 4)
            {
                MessageBox.Show("La semilla debe tener exactamente 4 dígitos.");
                return;
            }*/

            dgvResultados.Columns.Clear();
            dgvResultados.Rows.Clear();

            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("Semilla", "Semilla");
            dgvResultados.Columns.Add("Cuadrado", "Cuadrado");
            dgvResultados.Columns.Add("NumeroCentral", "Número Central");

            for (int i = 1; i <= 30; i++)
            {
                int semillaEntera = int.Parse(semillaActual);
                int cuadradoEntero = semillaEntera * semillaEntera;

                string cuadradoTexto = cuadradoEntero.ToString();

                // 🔥 Si es impar, agregar un cero
                if (cuadradoTexto.Length % 2 != 0)
                {
                    cuadradoTexto = "0" + cuadradoTexto;
                }

                // 🔥 Si tiene menos de 4 cifras, rellenar hasta 4
                if (cuadradoTexto.Length < 4)
                {
                    cuadradoTexto = cuadradoTexto.PadLeft(4, '0');
                }

                int inicio = (cuadradoTexto.Length - 4) / 2;

                string numeroCentral = cuadradoTexto.Substring(inicio, 4);

                dgvResultados.Rows.Add(
                    i,
                    semillaActual,
                    cuadradoTexto,
                    numeroCentral
                );

                semillaActual = numeroCentral;
            }
        }
    }
}
