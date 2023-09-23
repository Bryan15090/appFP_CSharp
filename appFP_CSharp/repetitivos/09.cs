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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNum.Text);

            if (n >= 0 && n <= 50)
            {
                for (int i = 0; i < n; i++)
                {
                    txaRpta.AppendText("*");
                }
                txaRpta.AppendText("");

                for (int i = 0; i < n - 2; i++)
                {
                    txaRpta.AppendText("*");
                    for (int j = 0; j < n - 2; j++)
                    {
                        txaRpta.AppendText(" ");
                    }
                    txaRpta.AppendText("*");
                }


                for (int i = 0; i < n; i++)
                {
                    txaRpta.AppendText("*");
                }
            }
            else
            {
                txaRpta.AppendText("Error. El dato a ingresar de "
                        + "estar entre 0 y 50");
            }
        }
    }
}
