namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodos m = new metodos();
            double valor1;
            double valor2;
            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);
            double result = m.calculaDistancia(valor1, valor2);
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metodos m = new metodos();
            m.VaciarTodo(textBox1, textBox2, textBox3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
