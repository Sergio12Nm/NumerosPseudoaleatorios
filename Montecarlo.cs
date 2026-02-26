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
    public partial class Montecarlo : Form
    {
        public Montecarlo()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar semilla
            if (!int.TryParse(txtSemilla.Text, out int semilla))
            {
                MessageBox.Show("Por favor ingrese una semilla válida (solo números).");
                return;
            }

            // Limpiar tabla
            dgvResultados.Columns.Clear();
            dgvResultados.Rows.Clear();

            // Crear columnas
            dgvResultados.Columns.Add("Iteracion", "Iteración");
            dgvResultados.Columns.Add("X", "X");
            dgvResultados.Columns.Add("Y", "Y");
            dgvResultados.Columns.Add("DentroCirculo", "¿Dentro del círculo?");
            dgvResultados.Columns.Add("PiEstimado", "π Estimado");

            Random random = new Random(semilla);

            int dentroCirculo = 0;
            int total = 30;

            for (int i = 1; i <= total; i++)
            {
                double x = random.NextDouble();
                double y = random.NextDouble();

                double distancia = (x * x) + (y * y);

                string dentro = "No";

                if (distancia <= 1)
                {
                    dentroCirculo++;
                    dentro = "Sí";
                }

                double piEstimado = 4.0 * dentroCirculo / i;

                dgvResultados.Rows.Add(i,
                                        x.ToString("F4"),
                                        y.ToString("F4"),
                                        dentro,
                                        piEstimado.ToString("F6"));
            }

            double piFinal = 4.0 * dentroCirculo / total;

            lblPi.Text = "π aproximado = " + piFinal.ToString("F6");
        }
    }
}
