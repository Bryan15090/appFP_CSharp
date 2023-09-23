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
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Donacion_anual = int.Parse(txtDAnual.Text);

            double csalud;
            double cniños;
            double invertir;

            if (Donacion_anual >= 10000)
            {
                csalud = Donacion_anual * 0.30;
                cniños = Donacion_anual * 0.50;
                invertir = Donacion_anual - csalud - cniños;
            }
            else
            {
                csalud = Donacion_anual * 0.25;
                cniños = Donacion_anual * 0.60;
                invertir = Donacion_anual - csalud - cniños;
            }

            txtCSalud.Text = csalud.ToString();
            txtCNiños.Text = cniños.ToString();
            txtInvertir.Text = invertir.ToString();
        }
    }
}
