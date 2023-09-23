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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(txtNumero.Text);
            String[] aDias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            //if (numero >= 1 && numero <=7) txtDia.setText(aDias[numero-1]);
            //else txtDia.setText("Error");

            txtDia.Text = (numero >= 1 && numero <= 7 ? aDias[numero - 1] : "Error");
        }
    }
}
