using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Laboratorio20._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarFormulario();
            }
        }

        protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            nuevo = true;
            txbId.Text = string.Empty;
            txbId.Enabled = false;
            txbNombre.Enabled = true;
            txbPrecio.Enabled = true;
            txbStock.Enabled = true;
            txbNombre.Text = string.Empty;
            txbPrecio.Text = string.Empty;
            txbStock.Text = string.Empty;
            lblMensaje.Text = string.Empty;
            txbNombre.Focus();
        }

        protected void btnGuardar_Click(object sender, ImageClickEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProductosDB"].ConnectionString;
            string sql = nuevo
                ? "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@Nombre, @Precio, @Stock)"
                : "UPDATE LAPTOPS SET NOMBRE=@Nombre, PRECIO=@Precio, STOCK=@Stock WHERE ID=@Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Nombre", txbNombre.Text);
                cmd.Parameters.AddWithValue("@Precio", txbPrecio.Text);
                cmd.Parameters.AddWithValue("@Stock", txbStock.Text);
                if (!nuevo)
                {
                    cmd.Parameters.AddWithValue("@Id", txbId.Text);
                }

                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    lblMensaje.Text = result > 0 ? "Registro guardado correctamente." : "No se pudo guardar el registro.";
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }

            LimpiarFormulario();
        }

        protected void btnCancelar_Click(object sender, ImageClickEventArgs e)
        {
            LimpiarFormulario();
        }

        protected void btnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProductosDB"].ConnectionString;
            string sql = "DELETE FROM LAPTOPS WHERE ID=@Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", txbId.Text);

                try
                {
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    lblMensaje.Text = result > 0 ? "Registro eliminado correctamente." : "No se pudo eliminar el registro.";
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }

            LimpiarFormulario();
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProductosDB"].ConnectionString;
            string sql = "SELECT * FROM LAPTOPS WHERE ID=@Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", txbBuscar.Text);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txbBuscar.Text = reader["ID"].ToString();
                        txbNombre.Text = reader["NOMBRE"].ToString();
                        txbPrecio.Text = reader["PRECIO"].ToString();
                        txbStock.Text = reader["STOCK"].ToString();
                        txbId.Enabled = false;
                        txbNombre.Enabled = true;
                        txbPrecio.Enabled = true;
                        txbStock.Enabled = true;
                        nuevo = false;
                        lblMensaje.Text = "Registro encontrado.";
                    }
                    else
                    {
                        lblMensaje.Text = "No se encontró ningún registro.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }
        }

        private void LimpiarFormulario()
        {
            txbId.Text = string.Empty;
            txbNombre.Text = string.Empty;
            txbPrecio.Text = string.Empty;
            txbStock.Text = string.Empty;
            txbId.Enabled = false;
            txbNombre.Enabled = false;
            txbPrecio.Enabled = false;
            txbStock.Enabled = false;
            lblMensaje.Text = string.Empty;
        }
    }
}
