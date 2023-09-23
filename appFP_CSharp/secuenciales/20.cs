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
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtCantidad.Text);

            int billetes_200 = cantidad / 200;
            cantidad = cantidad % 200;

            int billetes_100 = cantidad / 100;
            cantidad = cantidad % 100;

            int billetes_50 = cantidad / 50;
            cantidad = cantidad % 50;

            int billetes_20 = cantidad / 20;
            cantidad = cantidad % 20;

            int billetes_10 = cantidad / 10;
            cantidad = cantidad % 10;

            int monedas_5 = cantidad / 5;
            cantidad = cantidad % 5;

            int monedas_2 = cantidad / 2;
            cantidad = cantidad % 2;

            int monedas_1 = cantidad;

            txtBillete200.Text = billetes_200.ToString();
            txtBillete100.Text = billetes_100.ToString();
            txtBillete50.Text = billetes_50.ToString();
            txtBillete20.Text = billetes_20.ToString();
            txtBillete10.Text = billetes_10.ToString();
            txtMoneda5.Text = monedas_5.ToString();
            txtMoneda2.Text = monedas_2.ToString();
            txtMoneda1.Text = monedas_1.ToString();
        }
    }
}
