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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNum.Text);

            int divisor = 0;
            int i = 1;
            while (numero >= i)
            {
                if (numero % i == 0)
                {
                    divisor += 1;
                }
                i += 1;
            }

            txtDivisor.Text = ("" + divisor);
        }
    }
}
