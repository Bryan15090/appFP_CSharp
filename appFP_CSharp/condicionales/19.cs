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
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sexo = txtSexo.Text;
            int edad = int.Parse(txtEdad.Text);
            String categoria = ("");

            if (sexo.Equals("F"))
            {
                if (edad <= 23)
                {
                    categoria = "FA";
                }
                else
                {
                    categoria = "FB";
                }
            }
            else if (sexo.Equals("M"))
            {
                if (edad <= 25)
                {
                    categoria = "MA";
                }
                else
                {
                    categoria = "MB";
                }
            }
            txtCategoria.Text = (categoria);
        }
    }
}
