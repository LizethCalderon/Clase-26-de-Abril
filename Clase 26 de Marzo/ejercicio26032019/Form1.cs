using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace ejercicio26032019
{
    public partial class Form1 : Form
    {
        Operacion ingreso;
        Resta ingreso;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtvalora.Text);
            ingreso.V2 = double.Parse(txtvalorb.Text);
            lblResul.Text = ingreso.Calcular().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingreso = new Resta();
            ingreso.R1 = double.Parse(txtvalora.Text);
            ingreso.R2 = double.Parse(txtvalorb.Text);
            lblResul.Text = ingreso.Calcular().ToString();

        }
    }
}
