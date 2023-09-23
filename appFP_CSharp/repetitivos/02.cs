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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txtN1.Text);
            int N2 = int.Parse(txtN2.Text);

            for (int Nx = N1, veces = 1; veces++ < N2; N1 += Nx) ;


            txtProducto.Text =("" + N1);
        }
    }
}
