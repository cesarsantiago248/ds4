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
    public partial class Avión_Agendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadViajesData();
        }


        private void LoadViajesData()
        {
            // Retrieve the connection string from Web.config
            ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["BDD1"];
            using (SqlConnection conexion = new SqlConnection(connString.ConnectionString))
            {
                // Query to retrieve all records from avion_tarifa
                string query = "SELECT * FROM avion_viajes";

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
                        gridview_viajes.DataSource = tarifarioTable;
                        gridview_viajes.DataBind();

                        listbox_viajes.DataSource = tarifarioTable;
                        listbox_viajes.DataTextField = "lugar_destino"; // The text to display in the dropdown
                        listbox_viajes.DataValueField = "id_viaje"; // The value to use when selecting
                        listbox_viajes.DataBind();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        protected void btn_agendar_Click(object sender, EventArgs e)
        {
            // Check if a valid item is selected from the DropDownList
            if (listbox_viajes.SelectedValue != "")
            {
                // Get the selected id_viaje from the DropDownList
                int selectedViajeId = int.Parse(listbox_viajes.SelectedValue);

                // Retrieve the username from GlobalStorage
                string username = GlobalStorage.user1;

                // Insert data into another table (e.g., viaje_user)
                ConnectionStringSettings connString = ConfigurationManager.ConnectionStrings["BDD1"];
                using (SqlConnection conexion = new SqlConnection(connString.ConnectionString))
                {
                    // Query to insert into another table (e.g., viaje_user)
                    string insertQuery = "INSERT INTO avion_boletos_clientes (username, id_viaje) VALUES (@Username, @IdViaje)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conexion))
                    {
                        cmd.CommandType = CommandType.Text;

                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@IdViaje", selectedViajeId);

                        try
                        {
                            conexion.Open(); // Open the connection

                            // Execute the insert command
                            cmd.ExecuteNonQuery();

                            // Show a success message
                            lbl_agenda.Text = "Se ha agregado correctamente.";
                            lbl_agenda.ForeColor = System.Drawing.Color.Green;
                        }
                        catch (Exception ex)
                        {
                            // Handle error (optional)
                            lbl_agenda.Text = "Error: " + ex.Message;
                            lbl_agenda.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            else
            {
                // Handle the case where no viaje is selected
                lbl_agenda.Text = "Por favor, seleccione un viaje.";
                lbl_agenda.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void btn_return_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Avión.aspx");
        }


    }
}