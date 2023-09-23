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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int angulo = int.Parse(txtAngulo.Text);

            if (angulo == 0)
            {
                txtRpta.Text = ("Angulo nulo");
            }
            else if (angulo > 0 && angulo < 90)
            {
                txtRpta.Text = ("Angulo agudo");
            }
            else if (angulo == 90)
            {
                txtRpta.Text = ("Angulo recto");
            }
            else if (angulo > 90 && angulo < 180)
            {
                txtRpta.Text = ("Angulo obtuso");
            }
            else if (angulo == 180)
            {
                txtRpta.Text = ("Angulo llano");
            }
            else if (angulo > 180 && angulo < 360)
            {
                txtRpta.Text = ("Angulo concavo");
            }
            else if (angulo == 360)
            {
                txtRpta.Text = ("Angulo llano");
            }
            else
            {
                txtRpta.Text = ("Angulo invalido");
            }
        }
    }
}
