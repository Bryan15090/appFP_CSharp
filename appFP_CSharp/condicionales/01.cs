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
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int unidades = int.Parse(txtUnidades.Text);

            double precioUnitario;
            if (unidades >= 1 && unidades <= 25)
            {
                precioUnitario = 27;
            }
            else if (unidades >= 26 && unidades <= 50)
            {
                precioUnitario = 25;
            }
            else
            {
                precioUnitario = 23;
            }


            double importe = unidades * precioUnitario;
            double descuento;

            if (unidades > 50)
            {
                descuento = importe * 0.15;
            }
            else
            {
                descuento = importe * 0.05;
            }

            double total = importe - descuento;

            txtPrecio.Text = precioUnitario.ToString();
            txtDescuento.Text = descuento.ToString();
            txtTotal.Text = total.ToString();

        }
    }
}
