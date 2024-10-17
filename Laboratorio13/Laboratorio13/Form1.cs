using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        public string connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

            string query = "SELECT ProductName FROM [dbo].[Products]";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                string producto = reader["ProductName"].ToString();
                listBox1.Items.Add(producto);
            }

            reader.Close();
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }
    }
}
