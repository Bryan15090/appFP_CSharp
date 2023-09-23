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
    public partial class _24 : Form
    {
        public _24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vendido = int.Parse(txtVendido.Text);

            double sueldo;
            if (vendido >= 5000)
            {
                sueldo = vendido * 0.10;
            }
            else
            {
                sueldo = (5000 * 0.10) + ((vendido - 5000) / 500 * 25);
            }

            txtSueldo.Text = sueldo.ToString();

        }
    }
}
