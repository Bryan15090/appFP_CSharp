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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtAltura.Text);
            double radio = double.Parse(txtRadio.Text);

            double area = 2 * Math.PI * radio * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            txtArea.Text = area.ToString("##.00");
            txtVolumen.Text = volumen.ToString("##.00");

        }
    }
}
