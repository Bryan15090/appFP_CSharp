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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);

            for (int x = 1; x <= 12; x++)
            {
                txaRpta.AppendText(num + "x" + x + " = " + (num * x) + "\n");

            }
        }
    }
}
