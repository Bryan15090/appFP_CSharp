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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int ingreso_mensual = int.Parse(txtImensual.Text);
            int costo = int.Parse(txtCosto.Text);

            double cuota_inicial;
            double mensualidad;

            if (ingreso_mensual < 1250)
            {
                cuota_inicial = costo * 0.15;
                mensualidad = (costo - cuota_inicial) / 120;
            }
            else
            {
                cuota_inicial = costo * 0.30;
                mensualidad = (costo - cuota_inicial) / 75;
            }

            txtCuota.Text = cuota_inicial.ToString("##.00");
            txtMensualidad.Text = mensualidad.ToString("##.00");
        }
    }
}
