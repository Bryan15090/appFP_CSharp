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
    public partial class _27 : Form
    {
        public _27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int montoVendido = int.Parse(txtvendido.Text);

            double sueldoBasico = 600;
            double comision = 0.15;
            double sueldoBruto = sueldoBasico + (comision * montoVendido);
            double descuento;
            int numeroPolos;

            if (sueldoBruto > 1800)
            {
                descuento = 0.1;
            }
            else
            {
                descuento = 0.05;
            }

            double sueldoNeto = sueldoBruto - (descuento * sueldoBruto);

            if (montoVendido > 1000)
            {
                numeroPolos = 3;
            }
            else
            {
                numeroPolos = 1;
            }

            txaRpta.AppendText("Sueldo bruto: " + sueldoBruto + "\n");
            txaRpta.AppendText("Descuento: " + (descuento * 100) + "%\n");
            txaRpta.AppendText("Sueldo neto: " + sueldoNeto + "\n");
            txaRpta.AppendText("Polos obsequiados: " + numeroPolos + "\n");
        }
    }
}
