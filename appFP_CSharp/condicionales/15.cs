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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int vendido = int.Parse(txtVendido.Text);

            int sueldo = 250;
            double comision;
            double descuento;

            if (vendido <= 500)
            {
                comision = vendido * 0.05;
            }
            else if (vendido >= 5000 && vendido <= 10000)
            {
                comision = vendido * 0.08;
            }
            else if (vendido > 10000 && vendido <= 20000)
            {
                comision = vendido * 0.10;
            }
            else
            {
                comision = vendido * 0.15;
            }

            double sueldo_bruto = sueldo + comision;

            if (sueldo_bruto >= 3500)
            {
                descuento = sueldo_bruto * 0.15;
            }
            else
            {
                descuento = sueldo_bruto * 0.08;
            }

            double sueldo_neto = sueldo_bruto - descuento;

            txtbruto.Text = "" + sueldo_bruto;
            txtneto.Text = "" + sueldo_neto;
            txtdescuento.Text = "" + descuento;
            txtcomision.Text = "" + comision;
        }
    }
}
