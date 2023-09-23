using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.secuenciales
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilometros = int.Parse(txtKilometros.Text);
            int pies = int.Parse(txtPies.Text);
            int millas = int.Parse(txtMillas.Text);

            double metrosk = kilometros * 1000;
            double yardasK = kilometros * 1093;

            double metrosp = pies / 3.2808;
            double yardasp = pies * 0.333333;

            double metrosm = millas / 1609;
            double yardasm = 1760 * millas;

            double Tmetros = metrosk + metrosp + metrosm;
            double Tyardas = yardasK + yardasp + yardasm;

            txtTMetros.Text = Tmetros.ToString("##.00");
            txtTYardas.Text = Tyardas.ToString("##.00");
        }
    }
}
