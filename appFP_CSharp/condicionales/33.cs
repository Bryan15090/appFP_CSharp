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
    public partial class _33 : Form
    {
        public _33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puntualidad = int.Parse(txtPuntualidad.Text);
            int rendimiento = int.Parse(txtRendimiento.Text);

            int puntaje_total = puntualidad + rendimiento;
            double bonificacion;

            if (puntaje_total <= 11) bonificacion = puntaje_total * 0.25;
            else if (puntaje_total > 11 && puntaje_total <= 13) bonificacion = puntaje_total * 5.0;
            else if (puntaje_total > 14 && puntaje_total <= 16) bonificacion = puntaje_total * 7.5;
            else if (puntaje_total > 17 && puntaje_total <= 19) bonificacion = puntaje_total * 10.0;
            else bonificacion = puntaje_total * 12.5;

            txtPtotal.Text = "" + (puntaje_total);
            txtBonficacion.Text = "" + (bonificacion);
        }
    }
}
