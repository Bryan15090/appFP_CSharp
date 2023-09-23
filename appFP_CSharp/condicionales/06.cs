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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad1 = int.Parse(txtedad1.Text);
            int edad2 = int.Parse(txtedad2.Text);
            int edad3 = int.Parse(txtedad3.Text);

            int minEdad = Math.Min(edad1, Math.Min(edad2, edad3));
            int maxEdad = Math.Max(edad1, Math.Max(edad2, edad3));


            txtEmayor.Text = maxEdad.ToString();
            txtEmenor.Text = minEdad.ToString();
        }
    }
}
