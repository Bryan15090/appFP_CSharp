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
    public partial class _36 : Form
    {
        public _36()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cuadernos =int.Parse(txtCuadernos.Text);
            int lapiceros;

            if (cuadernos <= 12) lapiceros = 0;
            else if (cuadernos > 12 && cuadernos <= 24) lapiceros = (cuadernos / 4) * 1;
            else if (cuadernos > 24 && cuadernos <= 36) lapiceros = (cuadernos / 4) * 2;
            else lapiceros = (cuadernos / 4) * 2 + (cuadernos / 6) + (cuadernos / 12);

            txtLapiceros.Text = "" + (lapiceros) ;
        }
    }
}
