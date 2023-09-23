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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);


            if (numero == 0) txtRpta.Text = ("Cero");
            else if (numero > 0) txtRpta.Text = ("Positivo");
            else txtRpta.Text = ("Negativo");
        }
    }
}
