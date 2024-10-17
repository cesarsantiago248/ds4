using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodos m = new metodos();
            double nota1 = Convert.ToDouble(textBox1.Text);
            double nota2 = Convert.ToDouble(textBox2.Text);
            double nota3 = Convert.ToDouble(textBox3.Text);
            double promedioFinal = m.calcularPromedio(nota1, nota2, nota3);
            textBox4.Text = promedioFinal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
