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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tarjeta = int.Parse(txttarjeta.Text);
            int compra = int.Parse(txtcompra.Text);

            double descuento;
            if (tarjeta % 2 == 0 && tarjeta >= 100)
            {
                descuento = compra * 0.15;
            }
            else
            {
                descuento = compra * 0.05;
            }

            txtdescuento.Text= "" + descuento;
        }
    }
}
