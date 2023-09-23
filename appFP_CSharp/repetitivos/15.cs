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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = txtN1.Text;

            txtRpta.Text = (texto.ToUpper());
        }
    }
}
