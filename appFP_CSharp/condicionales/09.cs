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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            double precio_unitario = 0;
            double descuento = 0;

            if (codigo == 101)
            {
                precio_unitario = 17;
            }
            else if (codigo == 102)
            {
                precio_unitario = 25;
            }
            else if (codigo == 103)
            {
                precio_unitario = 16;
            }


            if (cantidad <= 10)
            {
                descuento = 0.05;
            }
            else if (cantidad > 10 && cantidad <= 20)
            {
                descuento = 0.08;
            }
            else if (cantidad > 20 && cantidad <= 30)
            {
                descuento = 0.10;
            }
            else
            {
                descuento = 0.13;
            }

            double importe = precio_unitario * cantidad;
            double descuento_total = importe * descuento;
            double total = importe - descuento_total;


            txtImporte.Text = importe.ToString();
            txtDescuento.Text = descuento_total.ToString();
            txtTotal.Text = total.ToString();
        }
    }
}
