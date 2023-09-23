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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = txtTexto.Text;
            int pos = texto.IndexOf('a');
            txtIndexOf.Text = ("" + pos);
        }
    }
}
