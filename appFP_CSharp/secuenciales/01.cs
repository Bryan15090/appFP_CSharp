namespace appFP_CSharp.secuenciales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            int total = varones + mujeres;
            double pVarones = varones * 100.0 / total;
            double pMujeres = mujeres * 100.0 / total;

            lblPVarones.Text = pVarones.ToString("##.00 %");
            lblPMujeres.Text = pMujeres.ToString("##.00 %");

        }
    }
}
