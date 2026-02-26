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
    public partial class Neumann : Form
    {
        public Neumann()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvResultados.Columns.Clear();
            dgvResultados.Rows.Clear();

            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("Semilla", "Semilla");
            dgvResultados.Columns.Add("Cuadrado", "Cuadrado");
            dgvResultados.Columns.Add("NuevoValor", "Nuevo Valor");

            if (!int.TryParse(txtSemilla.Text, out int semilla))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            if (semilla < 1000 || semilla > 9999)
            {
                MessageBox.Show("La semilla debe ser de 4 dígitos.");
                return;
            }

            for (int i = 1; i <= 30; i++)
            {
                long cuadrado = (long)semilla * semilla;

                string cuadradoStr = cuadrado.ToString("D8");

                string centrales = cuadradoStr.Substring(2, 4);

                int nuevoValor = int.Parse(centrales);

                dgvResultados.Rows.Add(i, semilla, cuadradoStr, nuevoValor);

                semilla = nuevoValor;

                if (semilla == 0)
                {
                    MessageBox.Show("El proceso se detuvo porque llegó a 0.");
                    break;
                }
            }
        }
    }
}
