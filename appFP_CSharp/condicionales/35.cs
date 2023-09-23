using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.condicionales
{
    public partial class _35 : Form
    {
        public _35()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            if (numero > 99 && numero < 1000)
            {
                if (numero % 2 == 0 && numero % 3 == 0 && numero % 5 == 0) txtTipo.Text = ("Administrativo");
                else if (numero % 3 == 0 && numero % 5 == 0) txtTipo.Text = ("Directivo");
                else if (numero % 2 == 0) txtTipo.Text = ("Vendedor");
                else txtTipo.Text = ("Sin tipo");

            }
            else txtTipo.Text = ("Error");
        }
    }
}
