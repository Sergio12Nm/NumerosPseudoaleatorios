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
    public partial class Congruencial : Form
    {
        public Congruencial()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Limpiar tabla completamente
            dgvResultados.Columns.Clear();
            dgvResultados.Rows.Clear();

            // Crear columnas dinámicamente
            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("Xn", "Xn");
            dgvResultados.Columns.Add("Rn", "rn");

            int X, a, c, m;

            // Validar Semilla
            if (!int.TryParse(txtSemilla.Text, out X))
            {
                MessageBox.Show("Ingrese una semilla válida (solo números).");
                txtSemilla.Focus();
                return;
            }

            // Validar multiplicador
            if (!int.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Ingrese un multiplicador válido (a).");
                txtA.Focus();
                return;
            }

            // Validar incremento
            if (!int.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("Ingrese un incremento válido (c).");
                txtC.Focus();
                return;
            }

            // Validar módulo
            if (!int.TryParse(txtM.Text, out m) || m <= 0)
            {
                MessageBox.Show("Ingrese un módulo válido mayor que 0.");
                txtM.Focus();
                return;
            }

            // Generar 30 iteraciones
            for (int i = 1; i <= 30; i++)
            {
                X = (a * X + c) % m;
                double r = (double)X / m;

                dgvResultados.Rows.Add(i, X, r.ToString("F4"));
            }
        }
    }
}
