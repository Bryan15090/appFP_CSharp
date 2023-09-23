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
    public partial class _30 : Form
    {
        public _30()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cuota = int.Parse(txtCuota.Text);
            int dia = int.Parse(txtDia.Text);

            double descuento = 0;
            if (dia <= 10) descuento = -Math.Max(5, 0.02 * cuota);
            else if (dia >= 20) descuento = Math.Max(10, 0.03 * cuota);

            txtPago.Text = "" + cuota + descuento;
        }
    }
}
