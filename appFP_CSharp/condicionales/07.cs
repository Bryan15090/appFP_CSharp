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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int num3 = int.Parse(txtnum3.Text);

            int intermedio;

            if ((num1 > num2 && num1 < num3) || (num1 < num2 && num1 > num3))
            {
                intermedio = num1;
            }
            else if ((num2 > num1 && num2 < num3) || (num2 < num1 && num2 > num3))
            {
                intermedio = num2;
            }
            else
            {
                intermedio = num3;
            }

            txtRpta.Text = intermedio.ToString();
        }
    }
}
