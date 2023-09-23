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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumeros.Text);
            int multiplos = int.Parse(txtMultiplos.Text);

            for (int i = 1; i <= multiplos; i++)
            {
                int multiple = numero * i;

                txtMultiplosd.Text = ("" + multiple);
            }
        }
    }
}
