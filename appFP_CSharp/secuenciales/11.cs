using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.secuenciales
{
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            int n3 = numero % 10;
            int n2 = (numero % 100) / 10;
            int n1 = (numero - (numero % 100)) / 100;

            int nu3 = numero2 % 10;
            int nu2 = (numero2 % 100) / 10;
            int nu1 = (numero2 - (numero % 100)) / 100;

            String intercambio = nu3.ToString() + n2.ToString() + nu1.ToString() + " " + "y" + " " + n3.ToString() + nu2.ToString() + n1.ToString();

            txtIntercambio.Text=intercambio.ToString();

        }
    }
}
