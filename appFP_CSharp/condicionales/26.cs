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
    public partial class _26 : Form
    {
        public _26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int montoCompra = int.Parse(txtcompra.Text);

            double prestamo;
            double propioDinero;

            if (montoCompra > 5000)
            {
                prestamo = montoCompra * 0.3;
            }
            else
            {
                prestamo = montoCompra * 0.2;
            }


            double interes = prestamo * 0.1;
            propioDinero = montoCompra - prestamo - interes;

            txtpago.Text = "" + propioDinero;
        }
    }
}
