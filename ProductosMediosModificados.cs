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
    public partial class ProductosMediosModificados : Form
    {
        public ProductosMediosModificados()
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
            dgvResultados.Columns.Add("Xn_2", "X(n-2)");
            dgvResultados.Columns.Add("Xn_1", "X(n-1)");
            dgvResultados.Columns.Add("Producto", "Producto");
            dgvResultados.Columns.Add("Central", "Número Central");

            int x0, x1, x2;

            if (!int.TryParse(txtSemilla1.Text, out x0) ||
                !int.TryParse(txtSemilla2.Text, out x1) ||
                !int.TryParse(txtSemilla3.Text, out x2))
            {
                MessageBox.Show("Ingrese semillas válidas de 4 dígitos");
                return;
            }

            for (int i = 1; i <= 30; i++)
            {
                long producto = (long)x1 * x2;

                // Convertir a 8 dígitos con ceros
                string productoStr = producto.ToString("D8");

                // Extraer 4 centrales
                string centralStr = productoStr.Substring(2, 4);

                int nuevo = int.Parse(centralStr);

                dgvResultados.Rows.Add(i, x1, x2, productoStr, centralStr);

                // Desplazamiento
                x0 = x1;
                x1 = x2;
                x2 = nuevo;

                if (x2 == 0)
                    break;
            }
        }
    }
}
