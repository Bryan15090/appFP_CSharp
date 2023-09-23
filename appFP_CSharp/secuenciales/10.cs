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
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            int n4 = numero % 10;
            int n3 = (numero % 100) / 10;
            int n2 = (numero % 1000) / 100;
            int n1 = (numero - (numero % 1000)) / 1000;

            String numReversa = n4.ToString() + n3.ToString() + n2.ToString() + n1.ToString();

            txtReversa.Text = numReversa.ToString();

        }
    }
}
