using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void montoinicial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
            double Montoinicial = double.Parse(txtmontoinicial.Text);
            double Interesanual = double.Parse(txtinteresanual.Text);
            double periodo = double.Parse(textaniopagar.Text)*12;
            double tasa = Interesanual / 100;

            double CapitalFinal = Montoinicial * Math.Pow(1 + tasa, periodo);
            txtResultado.Text = CapitalFinal.ToString();


        }

       
    }
}
