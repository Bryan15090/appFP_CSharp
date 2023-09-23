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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            int primerDigito = numero / 1000;
            int ultimoDIgito = numero % 10;

            int numeroMaximo = Math.Max(primerDigito, ultimoDIgito) * 10 + Math.Min(primerDigito, ultimoDIgito);

            txtRpta.Text = numeroMaximo.ToString();
        }
    }
}
