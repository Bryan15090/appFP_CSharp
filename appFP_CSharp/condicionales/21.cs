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
    public partial class _21 : Form
    {
        public _21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtnum.Text);
            double estadoc = num / 1000;
            double edad = (num % 1000) / 10;
            double genero = num % 10;

            if (estadoc == 1) txtEstadoC.Text = ("Soltero");
            else if (estadoc == 2) txtEstadoC.Text = ("Casado");
            else if (estadoc == 3) txtEstadoC.Text = ("Divorciado");
            else if (estadoc == 4) txtEstadoC.Text = ("Viudo");

            if (genero == 1) txtGenero.Text = ("Masculino");
            else if (genero == 2) txtGenero.Text = ("Femenino");

            txtEdad.Text = "" + edad;

        }
    }
}
