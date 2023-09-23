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
    public partial class _28 : Form
    {
        public _28()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hora = int.Parse(txtHora.Text);

            if (hora >= 0 && hora <= 23)
            {
                if (hora == 0)
                {
                    txtHora2.Text = ("12:00 am");
                }
                else if (hora < 12)
                {
                    txtHora2.Text = (hora + ":00 am");
                }
                else if (hora == 12)
                {
                    txtHora2.Text = ("12:00 pm");
                }
                else
                {
                    txtHora2.Text = ((hora - 12) + ":00 pm");
                }
            }
            else
            {
                txtHora2.Text = ("Hora inválida");
            }
        }
    }
}
