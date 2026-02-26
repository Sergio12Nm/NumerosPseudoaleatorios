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
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();

            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("Xn", "Xn");
            dgvResultados.Columns.Add("Rn", "Rn");

            try
            {
                long Xn = long.Parse(txtSemilla.Text);
                long a = long.Parse(txtA.Text);
                long m = long.Parse(txtM.Text);

                if (m <= 0)
                {
                    MessageBox.Show("El módulo debe ser mayor que 0");
                    return;
                }

                for (int i = 1; i <= 30; i++)
                {
                    Xn = (a * Xn) % m;
                    double rn = (double)Xn / m;

                    dgvResultados.Rows.Add(i, Xn, rn);
                }
            }
            catch
            {
                MessageBox.Show("Ingresa valores numéricos válidos");
            }
        }
    }
}
