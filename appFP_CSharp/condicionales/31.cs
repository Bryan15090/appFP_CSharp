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
    public partial class _31 : Form
    {
        public _31()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txtHoras.Text);
            String sCategoria = txtCategoria.Text;

            double tarifa = 0;
            if (sCategoria.Equals("A")) tarifa = 21;
            else if (sCategoria.Equals("B")) tarifa = 19.50;
            else if (sCategoria.Equals("C")) tarifa = 17;
            else tarifa = 15.50;

            double sbruto = horas * tarifa;
            double descuento = (sbruto > 2500 ? 0.20 : 0.15) * sbruto;


            txaRpta.AppendText("Horas        : " + horas + "\n");
            txaRpta.AppendText("Categoria    : " + sCategoria + "\n");
            txaRpta.AppendText("Sueldo Bruto : " + (sbruto) + "\n");
            txaRpta.AppendText("Descuento    : " + (descuento) + "\n");
            txaRpta.AppendText("Sueldo Neto  : " + (sbruto - descuento));


        }
    }
}
