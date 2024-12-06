using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace semestralcs
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {

            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["BDD1"];
            SqlConnection conexion = new SqlConnection(connString.ConnectionString);
            string query = "SELECT COUNT(*) FROM clientes WHERE username = @Username AND password = @Password";
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                conexion.Open();



                cmd.Parameters.AddWithValue("@Username", txtbox_username.Text);
                cmd.Parameters.AddWithValue("@Password", txtbox_password.Text);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    login_label.Text = "Ha iniciado sesion correctamente.";
                    login_label.ForeColor = System.Drawing.Color.Green;
                    GlobalStorage.user1 = txtbox_username.Text;
                   Response.Redirect("Home.aspx");
                }
                else
                {
                    login_label.Text = "Usuario o contrasena invalidos.";
                    login_label.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}