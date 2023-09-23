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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double copuesto = Double.Parse(txtCOpuesto.Text);
            double cadyacente = Double.Parse(txtCAdyacente.Text);

            double hipotenusa = Math.Sqrt(Math.Pow(copuesto, 2) + Math.Pow(cadyacente, 2));

            
            txtHipotenusa.Text= hipotenusa.ToString("##.00");

        }
    }
}
