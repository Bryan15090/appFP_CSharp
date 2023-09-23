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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtN1.Text);

            if (num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        txtN2.Text = ("Es primo");
                        break;
                    }
                    else
                    {
                        txtN2.Text = ("No primo");
                    }
                }
            }
            else
            {
                txtN2.Text = ("No primo");
            }
        }
    }
}
