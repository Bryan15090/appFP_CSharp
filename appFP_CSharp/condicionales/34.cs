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
    public partial class _34 : Form
    {
        public _34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int peso = int.Parse(txtPeso.Text);
            double estatura = Double.Parse(txtEstatura.Text);

            double imc2 = peso / (Math.Pow(estatura, 2));

            if (imc2 < 20) txtIMC.Text = ("Delgado");
            else if (imc2 > 20 && imc2 < 25) txtIMC.Text = ("Normal");
            else if (imc2 > 25 && imc2 < 27) txtIMC.Text = ("Sobrepeso");
            else txtIMC.Text = ("Obesidad");
        }
    }
}
