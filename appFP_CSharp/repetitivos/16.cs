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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = txtTexto.Text;
            String invertida = "";

            for (int indice = texto.Length - 1; indice >= 0; indice--)
            {
                invertida += texto[indice];
            }

            txtRpta.Text = ("" + invertida);
        }
    }
}
