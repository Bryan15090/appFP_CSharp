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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gigabytes = int.Parse(txtGigabytes.Text);

            double megasbyte = gigabytes * 1024;
            double kilobytes = megasbyte * 1024;
            double bytes = kilobytes * 1024;

            txtMegabytes.Text = megasbyte.ToString();
            txtKilobytes.Text = kilobytes.ToString();
            txtBytes.Text = bytes.ToString();


        }
    }
}
