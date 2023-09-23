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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double radio = Double.Parse(txtRadio.Text);
            double altura = Double.Parse(txtAltura.Text);

            double areaBase = Math.PI * Math.Pow(radio, 2);
            double areaLateral = 2 * Math.PI * radio * altura;
            double areaTotal = 2 * areaBase + areaLateral;


            txtAreaB.Text = areaBase.ToString("##.00");
            txtAreaL.Text = areaLateral.ToString("##.00");
            txtAreaT.Text = areaTotal.ToString("##.00");
        }
    }
}
