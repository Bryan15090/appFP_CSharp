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
    public partial class _22 : Form
    {
        public _22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadA = int.Parse(txtCantidadA.Text);
            int cantidadB = int.Parse(txtCantidadB.Text);

            int unidadA = 25;
            int unidadB = 30;

            int ImportebrutoA = unidadA * cantidadA;
            int ImportebrutoB = unidadB * cantidadB;

            double descuentoA = 0;
            double descuentoB = 0;

            if (cantidadA >= 50)
            {
                descuentoA = ImportebrutoA * 0.15;
            }
            else
            {
                descuentoA = 0;
            }
            if (cantidadB >= 60)
            {
                descuentoB = ImportebrutoB * 0.10;
            }

            double total_pagar = ImportebrutoA - descuentoA + ImportebrutoB - descuentoB;

            txaRpta.AppendText("Importe bruto A: " + ImportebrutoA + "\n");
            txaRpta.AppendText("Importe bruto B: " + ImportebrutoB + "\n");
            txaRpta.AppendText("Descuento A: " + descuentoA + "\n");
            txaRpta.AppendText("Descuento B: " + descuentoB + "\n");
            txaRpta.AppendText("Total a pagar: " + total_pagar + "\n");
        }
    }
}
