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
            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("Xi", "Xi");
            dgvResultados.Columns.Add("Cuadrado", "Xi²");
            dgvResultados.Columns.Add("Central", "5 Centrales");
            dgvResultados.Columns.Add("Ri", "Ri");
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.Rows.Clear();

            string semillaTexto = txtSemilla.Text.Trim();

            if (semillaTexto.Length != 10 || !long.TryParse(semillaTexto, out long Xi))
            {
                MessageBox.Show("Ingrese una semilla numérica de EXACTAMENTE 10 dígitos.");
                return;
            }

            for (int i = 1; i <= 30; i++)
            {
                long cuadrado = Xi * Xi;

                int longitudCuadrado = (i == 1) ? 20 : 10;
                string cuadradoStr = cuadrado.ToString().PadLeft(longitudCuadrado, '0');

                // ✅ CORRECCIÓN: i==1 usa 20 dígitos → inicio=8 | i>1 usa 10 dígitos → inicio=2
                int inicio = (i == 1) ? 8 : 2;
                string centrales = cuadradoStr.Substring(inicio, 5);

                double Ri = long.Parse(centrales) / 100000.0;

                dgvResultados.Rows.Add(
                    i,
                    Xi.ToString().PadLeft(i == 1 ? 10 : 5, '0'),
                    cuadradoStr,
                    centrales,
                    Ri.ToString("0.00000")
                );

                Xi = long.Parse(centrales);
            }
        }
    }
}
