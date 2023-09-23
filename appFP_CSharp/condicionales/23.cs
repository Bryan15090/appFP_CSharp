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
    public partial class _23 : Form
    {
        public _23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int notam = int.Parse(txtNotam.Text);
            int notaf = int.Parse(txtNotaF.Text);

            int regalo = (notam + notaf) / 2;
            int propinam = 0;
            double propinaf = 0;
            String regalo1 = ("");

            if (notam >= 17)
            {
                propinam = 3;
            }
            else
            {
                propinam = 1;
            }
            if (notaf >= 15)
            {
                propinaf = 2;
            }
            else
            {
                propinaf = 0.05;
            }
            double propinaT = propinam + propinaf;

            if (regalo >= 16)
            {
                regalo1 = "obsequio reloj";
            }
            else
            {
                regalo1 = "sin obsequio";
            }
            txtPropina.Text = "" + propinaT;
            txtRegalo.Text = "" + regalo1;
        }
    }
}
