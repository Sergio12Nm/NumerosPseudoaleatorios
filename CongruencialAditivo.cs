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
            dgvResultados.Rows.Clear();

            dgvResultados.Columns.Add("colXi", "Xi");
            dgvResultados.Columns.Add("colValor", "Valor Xi");
            dgvResultados.Columns.Add("colRi", "ri");

            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int n = 5;               // Cantidad de semillas
            int cantidadGenerar = 30; // Cantidad de números a generar

            List<int> lista = new List<int>();

            // Validar semillas
            if (!int.TryParse(txtSemilla1.Text, out int x1) ||
                !int.TryParse(txtSemilla2.Text, out int x2) ||
                !int.TryParse(txtSemilla3.Text, out int x3) ||
                !int.TryParse(txtSemilla4.Text, out int x4) ||
                !int.TryParse(txtSemilla5.Text, out int x5))
            {
                MessageBox.Show("Ingrese correctamente las 5 semillas.");
                return;
            }

            // Validar módulo
            if (!int.TryParse(txtModulo.Text, out int m) || m <= 1)
            {
                MessageBox.Show("Ingrese un módulo válido (mayor que 1).");
                return;
            }

            // Agregar semillas iniciales
            lista.Add(x1);
            lista.Add(x2);
            lista.Add(x3);
            lista.Add(x4);
            lista.Add(x5);

            // Generar números
            for (int i = n; i < n + cantidadGenerar; i++)
            {
                int xi_1 = lista[i - 1];
                int xi_n = lista[i - n];

                int nuevo = (xi_1 + xi_n) % m;

                lista.Add(nuevo);

                // double ri = (double)nuevo / (m - 1);
                double riExacto = (double)nuevo / (m - 1);
                double riTruncado = Math.Truncate(riExacto * 10000) / 10000;

                dgvResultados.Rows.Add(
                    "X" + (i + 1),
                    nuevo.ToString("D2"),
                    riTruncado.ToString("0.0000")
                );
            }
        }
    }
}
