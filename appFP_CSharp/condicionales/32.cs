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
    public partial class _32 : Form
    {
        public _32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String categoria = txtCategoria.Text;
            int promedio = int.Parse(txtPromedio.Text);

            double pension = 0;
            double descuento = 0;
            double descuento1 = 0;
            double nueva_pension = 0;

            if (categoria.Equals("A")) pension = 550;
            else if (categoria.Equals("B")) pension = 500;
            else if (categoria.Equals("C")) pension = 450;
            else if (categoria.Equals("D")) pension = 400;


            if (promedio < 14) descuento = 0;
            else if (promedio >= 14 && promedio < 16) descuento = 0.10;
            else if (promedio >= 16 && promedio < 18) descuento = 0.12;
            else if (promedio >= 18 && promedio < 20) descuento = 0.15;

            descuento1 = pension * descuento;
            nueva_pension = pension - descuento1;


            txtPension.Text = "" + pension;
            txtDescuento.Text = "" + (descuento1);
            txtNPension.Text = "" + (nueva_pension);
        }
    }
}
