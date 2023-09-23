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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN1.Text);

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    sum += i;
                }
            }

            txtN2.Text = ("Suma: " + sum);
        }
    }
}
