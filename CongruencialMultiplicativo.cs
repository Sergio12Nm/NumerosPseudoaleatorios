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
    public partial class CongruencialMultiplicativo : Form
    {
        public CongruencialMultiplicativo()
        {
            InitializeComponent();
            ConfigurarTabla(dgvResultadosA3);
            ConfigurarTabla(dgvResultadosA5);
        }

        private void ConfigurarTabla(DataGridView dgv)
        {
            dgv.ColumnCount = 3;

            dgv.Columns[0].Name = "i";
            dgv.Columns[0].Width = 80;

            dgv.Columns[1].Name = "Xi";
            dgv.Columns[1].Width = 100;

            dgv.Columns[2].Name = "ri";
            dgv.Columns[2].Width = 100;

            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvResultadosA3.Rows.Clear();
            dgvResultadosA5.Rows.Clear();
            txtPeriodo1.Clear();
            txtPeriodo2.Clear();

            if (!int.TryParse(txtSemilla.Text, out int x0) ||
                !int.TryParse(txtK.Text, out int k) ||
                !int.TryParse(txtG.Text, out int g))
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
                return;
            }

            if (x0 % 2 == 0)
            {
                MessageBox.Show("La semilla X0 debe ser impar");
                return;
            }

            int m = (int)Math.Pow(2, g);

            int a1 = 3 + 8 * k;
            int a2 = 5 + 8 * k;

            int periodo1 = GenerarSecuencia(dgvResultadosA3, x0, a1, m);
            int periodo2 = GenerarSecuencia(dgvResultadosA5, x0, a2, m);

            txtPeriodo1.Text = periodo1.ToString();
            txtPeriodo2.Text = periodo2.ToString();
        }

        private int GenerarSecuencia(DataGridView dgv, int x0, int a, int m)
        {
            int xi = x0;
            int i = 0;
            int periodo = 0;

            HashSet<int> valores = new HashSet<int>();

            do
            {
                double ri = (double)xi / (m - 1);
                double riTruncado = Math.Truncate(ri * 10000) / 10000;

                dgv.Rows.Add(
                    i,
                    xi,
                    riTruncado.ToString("0.0000")
                );

                valores.Add(xi);

                xi = (a * xi) % m;

                i++;
                periodo++;

            } while (!valores.Contains(xi));

            return periodo;
        }
    }
}
