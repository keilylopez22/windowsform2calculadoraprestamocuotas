using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuotasdeprestamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtmonto.Text);
            double interes = double.Parse(txtintereses.Text);
            double plazo = double.Parse(txtplazos.Text);
            interes = interes / 100;

            double cuotaMensual = (monto * (interes * Math.Pow(1 + interes, plazo))) / (Math.Pow(1 + interes, plazo) - 1);
            cuotaMensual = Math.Round(cuotaMensual, 2);
            txtcuota.Text = cuotaMensual.ToString();
        }
    }
}
