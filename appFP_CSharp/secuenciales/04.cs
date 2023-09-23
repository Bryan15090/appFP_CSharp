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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double estatura = double.Parse(txtEstatura.Text);

            double metros = estatura / 3.2808;

            txtEMetros.Text = metros.ToString("##.00");
        }
    }
}
