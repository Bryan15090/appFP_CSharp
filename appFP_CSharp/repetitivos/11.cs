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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN1.Text);

            int aux = n;
            int inverso = 0;
            while (aux != 0)
            {
                int cifra = aux % 10;
                inverso = inverso * 10 + cifra;
                aux = aux / 10;
            }
            if (n == inverso)
            {
                txtN2.Text = ("Es cupicua");
            }
            else
            {
                txtN2.Text = ("No es cupicua");
            }
        }
    }
}
