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
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sueldo = 500;
            double vendido = Double.Parse(txtVendido.Text);
            double comision = vendido * 0.09;
            double sueldo_bruto = sueldo + comision;
            double descuento = sueldo_bruto * 0.11;
            double sueldo_neto = sueldo_bruto - descuento;

            txtComision.Text = comision.ToString("##.00");
            txtBruto.Text = sueldo_bruto.ToString("##.00");
            txtDescuento.Text = descuento.ToString("##.00");
            txtNeto.Text = sueldo_neto.ToString("##.00");
        }
    }
}
