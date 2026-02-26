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
            // Limpiar tabla
            dgvResultados.Columns.Clear();
            dgvResultados.Rows.Clear();

            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("K", "K");
            dgvResultados.Columns.Add("Xn", "Xn");
            dgvResultados.Columns.Add("Producto", "K * Xn");
            dgvResultados.Columns.Add("Centro", "Centro");
            dgvResultados.Columns.Add("R", "R");

            // Quitar autoajuste para usar anchos fijos OPCIONAL
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajustar ancho manual para mejor visualización OPCIONAL
            dgvResultados.Columns["Iteracion"].Width = 85;
            dgvResultados.Columns["K"].Width = 85;
            dgvResultados.Columns["Xn"].Width = 85;
            dgvResultados.Columns["Producto"].Width = 85;
            dgvResultados.Columns["Centro"].Width = 85;
            dgvResultados.Columns["R"].Width = 85;

            // Centrar texto
            foreach (DataGridViewColumn col in dgvResultados.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Validar semilla
            if (!int.TryParse(txtSemilla.Text, out int semilla))
            {
                MessageBox.Show("Ingrese una semilla válida (solo números).");
                return;
            }

            if (txtSemilla.Text.Length != 2)
            {
                MessageBox.Show("La semilla debe tener exactamente 2 dígitos.");
                return;
            }

            // Validar K
            if (!int.TryParse(txtK.Text, out int K))
            {
                MessageBox.Show("Ingrese un valor válido para K.");
                return;
            }

            int Xn = semilla;

            for (int i = 1; i <= 30; i++)
            {
                int producto = K * Xn;

                // Convertir a 4 dígitos con ceros a la izquierda
                string productoStr = producto.ToString("D4");

                // Tomar los 2 dígitos centrales
                string centroStr = productoStr.Substring(1, 2);

                int centro = int.Parse(centroStr);

                double R = centro / 100.0;

                dgvResultados.Rows.Add(
                    i,
                    K,
                    Xn.ToString("D2"),
                    productoStr,
                    centroStr,
                    R.ToString("0.00")
                );

                // Actualizar semilla
                Xn = centro;
            }
        }
    }
}
