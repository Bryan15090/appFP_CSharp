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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int unidades = int.Parse(txtUnidades.Text);

            int compra = unidades * 20;
            double descuento = (compra <= 500 ? 0.12 : compra >= 700 ? 0.16 : 0.14) * compra;
            double obsequio = unidades <= 50 ? 5 : unidades > 100 ? 15 : 10;

            double total = compra - descuento;

            txtCompra.Text = compra.ToString("##.00");
            txtDescuento.Text = descuento.ToString("##.00");
            txtTotal.Text = total.ToString("##.00");
            txtCaramelos.Text = obsequio.ToString("##.00");
        }
    }
}
