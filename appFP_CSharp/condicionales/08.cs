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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnota1.Text);
            int num2 = int.Parse(txtnota2.Text);
            int num3 = int.Parse(txtnota3.Text);

            int mensualidad = 20;
            int m1, m2, m3;

            if (num1 >= 13)
            {
                m1 = 5;
            }
            else
            {
                m1 = 0;
            }

            if (num2 >= 13)
            {
                m2 = 5;
            }
            else
            {
                m2 = 0;
            }

            if (num3 >= 13)
            {
                m3 = 5;
            }
            else
            {
                m3 = 0;
            }

            int total = mensualidad + m1 + m2 + m3;

            txtmensualidad.Text = total.ToString();
        }
    }
}
