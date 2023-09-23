using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.repetitivos
{
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNum.Text);

            int factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            txtFactorial.Text = ("" + factorial);
        }
    }
}
