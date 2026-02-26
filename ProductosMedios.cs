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
    public partial class ProductosMedios : Form
    {
        public ProductosMedios()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.ReadOnly = true;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();

            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("Semilla1", "Semilla 1");
            dgvResultados.Columns.Add("Semilla2", "Semilla 2");
            dgvResultados.Columns.Add("Producto", "Producto");
            dgvResultados.Columns.Add("Central", "Número Central");

            int semilla1, semilla2;

            if (!int.TryParse(txtSemilla1.Text, out semilla1) ||
                !int.TryParse(txtSemilla2.Text, out semilla2))
            {
                MessageBox.Show("Ingrese semillas válidas de 4 dígitos");
                return;
            }

            for (int i = 1; i <= 30; i++)
            {
                long producto = (long)semilla1 * semilla2;

                // Convertir a string de 8 dígitos
                string productoStr = producto.ToString("D8");

                // Tomar 4 dígitos centrales
                string centralStr = productoStr.Substring(2, 4);

                int central = int.Parse(centralStr);

                dgvResultados.Rows.Add(i, semilla1, semilla2, productoStr, centralStr);

                // Actualizar semillas
                semilla1 = semilla2;
                semilla2 = central;

                if (semilla2 == 0)
                    break;
            }
        }
    }
}
