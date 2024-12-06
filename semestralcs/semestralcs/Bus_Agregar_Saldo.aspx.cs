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
    public partial class Bus_Agregar_Saldo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            // Check if the value in the textbox is a valid number
            decimal newSaldo;
            if (decimal.TryParse(txtbox_agregar_saldo.Text, out newSaldo))
            {
                // If the value is valid, proceed with the update
                string username = GlobalStorage.user1; // Get the username from GlobalStorage

                ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["BDD1"];
                using (SqlConnection conexion = new SqlConnection(connString.ConnectionString))
                {
                    // Query to update saldo_avion and saldo_avion_mora by adding the newSaldo value
                    string query = "UPDATE clientes SET saldo_bus = saldo_bus + @NewSaldo, saldo_bus_mora = saldo_bus_mora + @NewSaldo WHERE username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        // Add parameters for newSaldo and username
                        cmd.Parameters.AddWithValue("@NewSaldo", newSaldo);
                        cmd.Parameters.AddWithValue("@Username", username);

                        try
                        {
                            conexion.Open(); // Open the connection

                            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update query

                            if (rowsAffected > 0) // If the update was successful
                            {
                                // Retrieve and display the updated saldo_avion and saldo_avion_mora values
                                string selectQuery = "SELECT saldo_bus, saldo_bus_mora FROM clientes WHERE username = @Username"; // Same condition used in the update query

                                using (SqlCommand selectCmd = new SqlCommand(selectQuery, conexion))
                                {
                                    // Add parameter for username in select query
                                    selectCmd.Parameters.AddWithValue("@Username", username);

                                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                                    {
                                        if (reader.Read()) // If a record is found
                                        {
                                            decimal saldoAvion = reader.GetDecimal(reader.GetOrdinal("saldo_bus"));
                                            decimal saldoAvionMora = reader.GetDecimal(reader.GetOrdinal("saldo_bus_mora"));

                                            // Display the updated values in labels
                                            lbl_saldos_1.Text = "Saldo bus: " + saldoAvion.ToString("C2"); // Format as currency
                                            lbl_saldos_2.Text = "Saldo Mora: " + saldoAvionMora.ToString("C2"); // Format as currency
                                        }
                                    }
                                }
                            }
                            else
                            {
                                lbl_saldos_1.Text = "No se pudo actualizar el saldo.";
                                lbl_saldos_2.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions
                            lbl_saldos_1.Text = "Error al actualizar el saldo: " + ex.Message;
                            lbl_saldos_2.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            else
            {
                // If the value is not a valid number
                lbl_error.Text = "Por favor, ingrese un valor numérico válido.";
                lbl_error.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void btn_return_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Bus.aspx");
        }


    }
}