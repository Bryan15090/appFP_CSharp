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
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad = Double.Parse(txtCantidad.Text);
            double precio = Double.Parse(txtPrecio.Text);

            double importe = cantidad * precio;
            double descuento1 = importe * 0.15;
            double primer_descuento = importe - descuento1;
            double descuento2 = primer_descuento * 0.15;
            double pagar = primer_descuento - descuento2;

            double descuento3 = descuento1 + descuento2;


            txtImporte.Text = importe.ToString();
            txtDescuento.Text = descuento3.ToString();
            txtPagar.Text = pagar.ToString();
        }
    }
}
