using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                metodos m = new metodos();
                double valorYarda;
                valorYarda = Convert.ToDouble(textBox1.Text);
                double resultMetros = m.yardaMetro(valorYarda);
                textBox3.Text = resultMetros.ToString();
                listBox1.Items.Add($"{valorYarda} yardas, convertidas a {resultMetros} metros");
            } catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                metodos m = new metodos();
                double valorMetros;
                valorMetros = Convert.ToDouble(textBox2.Text);
                double resultYardas = m.metroYarda(valorMetros);
                textBox4.Text = resultYardas.ToString();
                listBox1.Items.Add($"{valorMetros} metros, convertidos a {resultYardas} yardas");
            
            } catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
