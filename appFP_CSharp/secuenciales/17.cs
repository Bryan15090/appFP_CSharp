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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double donacion = Double.Parse(txtDonacion.Text);

            double salud = donacion * 0.25;
            double comedor = donacion * 0.35;
            double escuela = donacion * 0.25;
            double asilo = donacion - salud - comedor - escuela;


            txtSalud.Text = salud.ToString();
            txtComedor.Text = comedor.ToString();
            txtEscuela.Text = escuela.ToString();
            txtAsilo.Text = asilo.ToString();
        }
    }
}
