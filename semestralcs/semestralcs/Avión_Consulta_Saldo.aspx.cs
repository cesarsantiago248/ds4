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
    public partial class Avión_Consulta_Saldo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Prevent multiple execution on postbacks
            {
                LoadTarifarioData();
                string username = GlobalStorage.user1; // Logged-in user's username

                if (!string.IsNullOrWhiteSpace(username))
                {
                    // Retrieve the connection string from Web.config
                    ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["BDD1"];
                    using (SqlConnection conexion = new SqlConnection(connString.ConnectionString))
                    {
                        // Query to retrieve both saldo and nombre_cliente for the username
                        string query = "SELECT saldo_avion,saldo_avion_mora, nombre_cliente FROM clientes WHERE username = @Username";

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.CommandType = CommandType.Text;

                            // Add parameter to prevent SQL injection
                            cmd.Parameters.AddWithValue("@Username", username);

                            try
                            {
                                conexion.Open(); // Open the connection

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read()) // If a record is found
                                    {
                                        // Retrieve column values
                                        decimal saldo = reader.GetDecimal(reader.GetOrdinal("saldo_avion"));
                                        decimal saldomora = reader.GetDecimal(reader.GetOrdinal("saldo_avion_mora"));
                                        string nombreCliente = reader.GetString(reader.GetOrdinal("nombre_cliente"));

                                        // Display saldo in label
                                        lbl_saldo_cliente.Text = "Saldo Actual: B/." + saldo.ToString("C2"); // Format as currency
                                        lbl_saldo_mora_cliente.Text = "Saldo en Mora: B/." + saldomora.ToString("C2"); // Format as currency
                                        lbl_nombre_cliente.Text = "Nombre: " + nombreCliente; // Display nombre_cliente in another label
                                    }
                                    else
                                    {
                                        lbl_saldo_cliente.Text = "Saldo Actual: B/.0.00";
                                        lbl_saldo_mora_cliente.Text = "Saldo en Mora: B/.0.00";
                                        lbl_nombre_cliente.Text = "Nombre: No disponible";
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                // Handle exceptions
                                lbl_saldo_cliente.Text = "Error al recuperar el saldo: " + ex.Message;
                                lbl_nombre_cliente.Text = "Error al recuperar el nombre: " + ex.Message;
                                lbl_saldo_mora_cliente.Text = "Error al recuperar el saldo: " + ex.Message;
                                lbl_saldo_cliente.ForeColor = System.Drawing.Color.Red;
                                lbl_saldo_mora_cliente.ForeColor = System.Drawing.Color.Red;
                                lbl_nombre_cliente.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }
                else
                {
                    lbl_saldo_cliente.Text = "No se encontró un usuario válido.";
                    lbl_saldo_mora_cliente.Text = "No se encontró un usuario válido.";
                    lbl_nombre_cliente.Text = "No se encontró un usuario válido.";
                    lbl_saldo_cliente.ForeColor = System.Drawing.Color.Red;
                    lbl_saldo_mora_cliente.ForeColor = System.Drawing.Color.Red;
                    lbl_nombre_cliente.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void LoadTarifarioData()
        {
            // Retrieve the connection string from Web.config
            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["BDD1"];
            using (SqlConnection conexion = new SqlConnection(connString.ConnectionString))
            {
                // Query to retrieve all records from avion_tarifa
                string query = "SELECT * FROM avion_tarifas";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        conexion.Open(); // Open the connection

                        // Create a SqlDataAdapter to fetch data
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        // Use a DataTable to store the data
                        DataTable tarifarioTable = new DataTable();
                        adapter.Fill(tarifarioTable); // Fill the DataTable with data

                        // Bind the DataTable to the GridView
                        gridview_tarifario.DataSource = tarifarioTable;
                        gridview_tarifario.DataBind();
                    }
                    catch (Exception ex)
                    {
                    
                    }
                }
            }
        }
        protected void btn_return_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Avión.aspx");
        }

        protected void btn_agregar_saldo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Avión_Agregar_Saldo.aspx");
        }
    }
}