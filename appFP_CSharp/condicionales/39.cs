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
    public partial class _39 : Form
    {
        public _39()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bHoras = Double.Parse(txtHoras.Text) < 1.5;
            bool bTMalos = Double.Parse(txtTMalos.Text) < 300;
            bool bTBuenos = Double.Parse(txtTBuenos.Text) > 10000;

            if (!bHoras && !bTMalos && !bTBuenos) txtGrado.Text = ("5");
            else if (bHoras && !bTMalos && !bTBuenos) txtGrado.Text = ("7");
            else if (!bHoras && bTMalos && !bTBuenos) txtGrado.Text = ("8");
            else if (!bHoras && !bTMalos && bTBuenos) txtGrado.Text = ("9");
            else if (bHoras && bTMalos && !bTBuenos) txtGrado.Text = ("12");
            else if (bHoras && !bTMalos && bTBuenos) txtGrado.Text = ("13");
            else if (!bHoras && bTMalos && bTBuenos) txtGrado.Text = ("15");
            else if (bHoras && bTMalos && bTBuenos) txtGrado.Text = ("20");

        }
    }
}
