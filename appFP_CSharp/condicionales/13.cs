using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.condicionales
{
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            double n3 = numero % 10;
            double n2 = (numero / 10) % 10;
            double n1 = numero / 100;

            if ((n1 == n2 - 1 && n2 == n3 - 1) || (n1 == n2 + 1 && n2 == n3 + 1))
            {
                txtRpta.Text = ("Consecutivo");

            }
            else
            {
                txtRpta.Text = ("No consecutivo");
            }
        }
    }
}
