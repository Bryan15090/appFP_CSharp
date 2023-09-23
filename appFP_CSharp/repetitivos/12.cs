using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_CSharp.repetitivos
{
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                txaRpta.AppendText(i + "\n");
                if (i % 10 == 0)
                {
                    txaRpta.AppendText("");
                }
            }
        }
    }
}
