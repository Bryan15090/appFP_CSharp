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
    public partial class _25 : Form
    {
        public _25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hijos = int.Parse(txtHijos.Text);
            int sueldo = int.Parse(txtSueldo.Text);

            double bonificacion;

            if (hijos >= 1)
            {
                bonificacion = (sueldo * 0.125) + (40 * hijos);
            }
            else
            {
                bonificacion = sueldo * 0.10;
            }

            double sueldo_neto = sueldo + bonificacion;

            txtSNeto.Text = sueldo_neto.ToString("##.00");
            txtBonificacion.Text = bonificacion.ToString("##.00");
        }
    }
}
