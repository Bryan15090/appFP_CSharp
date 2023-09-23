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
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = int.Parse(txtDividendo.Text);
            int divisor = int.Parse(txtDivisor.Text);

            int cociente = 1;
            for (; (dividendo -= divisor) >= divisor; cociente++) ;

            txtCociente.Text = ("" + cociente);
            txtResiduo.Text = ("" + dividendo);
        }
    }
}
