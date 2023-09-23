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
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnumero1.Text);
            int num2 = int.Parse(txtnumero2.Text);
            int num3 = int.Parse(txtnumero3.Text);

            if (num1 < num2 && num2 < num3) txtrpta.Text = ("Ascendente");
            else if (num1 > num2 && num2 > num3) txtrpta.Text = ("Descendente");
            else txtrpta.Text = ("Desorden");
        }
    }
}
