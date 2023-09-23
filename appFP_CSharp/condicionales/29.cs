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
    public partial class _29 : Form
    {
        public _29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int horasTrabajadas = int.Parse(txtHorasT.Text);
            int pagoPorHora = int.Parse(txtpagoH.Text);

            double sueldoBruto = 0;
            double descuento = 0;

            if (horasTrabajadas <= 48)
            {
                sueldoBruto = horasTrabajadas * pagoPorHora;
            }
            else
            {
                sueldoBruto = (48 * pagoPorHora) + ((horasTrabajadas - 48) * pagoPorHora * 1.2);
            }

            if (sueldoBruto > 1500)
            {
                descuento = sueldoBruto * 0.11;
            }

            double totalPagar = sueldoBruto - descuento;


            txaRpta.AppendText("Horas trabajadas: " + horasTrabajadas + "\n");
            txaRpta.AppendText("Pago por hora: " + pagoPorHora + "\n");
            txaRpta.AppendText("Sueldo bruto: " + sueldoBruto + "\n");
            txaRpta.AppendText("Descuento: " + descuento + "\n");
            txaRpta.AppendText("Total a pagar: " + totalPagar + "\n");
        }
    }
}
