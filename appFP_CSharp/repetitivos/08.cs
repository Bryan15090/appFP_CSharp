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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int base1 = int.Parse(txtBase.Text);
            int exponente = int.Parse(txtExponente.Text);

            int resultado = 1;
            int i = 0;

            while (i < exponente)
            {
                resultado *= base1;
                i++;
            }
            txtResultado.Text = ("" + resultado);
        }
    }
}
