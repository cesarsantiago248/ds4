using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace semestralcs
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_return_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btn_crear_cuenta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox_username.Text) &&
                !string.IsNullOrWhiteSpace(txtbox_password.Text) &&
                !string.IsNullOrWhiteSpace(txtbox_nombre.Text))
            {
                ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["BDD1"];
                using (SqlConnection conexion = new SqlConnection(connString.ConnectionString))
                {
                    string query = "INSERT INTO clientes (username, password, nombre_cliente) VALUES (@Username, @Password, @Nombre)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        // Adding parameters
                        cmd.Parameters.AddWithValue("@Username", txtbox_username.Text);
                        cmd.Parameters.AddWithValue("@Password", txtbox_password.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtbox_nombre.Text);

                        try
                        {
                            conexion.Open(); // Open connection

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                lbl_crear_cuenta.Text = "Se ha creado su cuenta correctamente.";
                                lbl_crear_cuenta.ForeColor = System.Drawing.Color.Green;
                            }
                            else
                            {
                                lbl_crear_cuenta.Text = "No se pudo crear su cuenta. Inténtelo de nuevo.";
                                lbl_crear_cuenta.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions
                            lbl_crear_cuenta.Text = "Ocurrió un error: " + ex.Message;
                            lbl_crear_cuenta.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            else
            {
                lbl_crear_cuenta.Text = "Debe llenar todos los campos.";
                lbl_crear_cuenta.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}