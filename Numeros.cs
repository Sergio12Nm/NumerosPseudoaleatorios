namespace Numeros_Pseudoaleatorios
{
    public partial class Numeros : Form
    {
        public Numeros()
        {
            InitializeComponent();
        }

        private void btnCuadradosMedios_Click(object sender, EventArgs e)
        {
            CuadradosMedios cuadradosMedios = new CuadradosMedios();
            cuadradosMedios.Show();
        }

        private void btnProductosMedios_Click(object sender, EventArgs e)
        {
            ProductosMedios productosMedios = new ProductosMedios();
            productosMedios.Show();
        }

        private void btnProductosMediosModificados_Click(object sender, EventArgs e)
        {
            ProductosMediosModificados productosMediosModificados = new ProductosMediosModificados();
            productosMediosModificados.Show();
        }

        private void btnNeumann_Click(object sender, EventArgs e)
        {
            Neumann neumann = new Neumann();
            neumann.Show();
        }

        private void btnCongruencial_Click(object sender, EventArgs e)
        {
            Congruencial congruencial = new Congruencial();
            congruencial.Show();
        }

        private void btnCongruencialAditivo_Click(object sender, EventArgs e)
        {
            CongruencialAditivo congruencialAditivo = new CongruencialAditivo();
            congruencialAditivo.Show();
        }

        private void btnCongruencialMultiplicativo_Click(object sender, EventArgs e)
        {
            CongruencialMultiplicativo congruencialMultiplicativo = new CongruencialMultiplicativo();
            congruencialMultiplicativo.Show();
        }

        private void btnMontecarlo_Click(object sender, EventArgs e)
        {
            Montecarlo montecarlo = new Montecarlo();
            montecarlo.Show();
        }
    }
}
