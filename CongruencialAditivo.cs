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
    public partial class CongruencialAditivo : Form
    {
        public CongruencialAditivo()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvResultados.ColumnCount = 3;

            dgvResultados.Columns[0].Name = "Iteración";
            dgvResultados.Columns[1].Name = "Xn";
            dgvResultados.Columns[2].Name = "Ri";

            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.ReadOnly = true;

            dgvResultados.Rows.Clear();

            bool semilla1Valida = int.TryParse(txtSemilla1.Text, out int x0);
            bool semilla2Valida = int.TryParse(txtSemilla2.Text, out int x1);
            bool moduloValido = int.TryParse(txtModulo.Text, out int m);

            if (!semilla1Valida || !semilla2Valida || !moduloValido)
            {
                MessageBox.Show("Ingrese solo valores numéricos enteros.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (m <= 0)
            {
                MessageBox.Show("El módulo debe ser mayor que 0.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            List<int> numeros = new List<int>();

            numeros.Add(x0);
            numeros.Add(x1);

            // Mostrar semillas iniciales
            dgvResultados.Rows.Add(0, x0, ((double)x0 / m).ToString("F4"));
            dgvResultados.Rows.Add(1, x1, ((double)x1 / m).ToString("F4"));

            for (int i = 2; i < 30; i++)
            {
                int xn = (numeros[i - 1] + numeros[i - 2]) % m;
                numeros.Add(xn);

                double ri = (double)xn / m;

                dgvResultados.Rows.Add(i, xn, ri.ToString("F4"));
            }
        }
    }
}
