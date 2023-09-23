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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int costo_docenas = int.Parse(txtCDocenas.Text);
            int docenas = int.Parse(txtDocenas.Text);

            double descuento;
            double lapiceros;

            if (docenas >= 6)
            {
                descuento = 0.15;
            }
            else
            {
                descuento = 0.10;
            }

            double subtotal = costo_docenas * docenas;
            double monto_descuento = subtotal * descuento;
            double total = subtotal - monto_descuento;

            if (docenas >= 30)
            {
                lapiceros = (docenas / 3) * 2;
            }
            else
            {
                lapiceros = 0;
            }

            
            txaRpta.AppendText("Monto de compra :" + subtotal + "\n");
            txaRpta.AppendText("Descuento :" + monto_descuento + "\n");
            txaRpta.AppendText("Total pagar :" + total);
            txaRpta.AppendText("Obsequio lapiceros :" + lapiceros + "\n");
        }
    }
}
