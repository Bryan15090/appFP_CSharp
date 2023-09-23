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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int base1 = int.Parse(txtBase.Text); ;
            int altura = int.Parse(txtAltura.Text);

            int area = base1 * altura;
            int perimetro = 2 * (base1 + altura);

            txtArea.Text = area.ToString();
            txtPerimetro.Text = perimetro.ToString();
        }
    }
}
