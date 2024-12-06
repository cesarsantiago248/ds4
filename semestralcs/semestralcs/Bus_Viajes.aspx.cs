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
    public partial class Bus_Viajes : System.Web.UI.Page
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
                // Query to perform LEFT JOIN between tren_boletos_clientes and tren_viajes
                string query = "SELECT * FROM bus_boletos_clientes LEFT JOIN bus_viajes ON bus_boletos_clientes.id_viaje = bus_viajes.id_viaje";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        conexion.Open(); // Open the connection

                        // Create a SqlDataAdapter to fetch data
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        // Use a DataTable to store the data
                        DataTable viajesData = new DataTable();
                        adapter.Fill(viajesData); // Fill the DataTable with data from the LEFT JOIN query

                        // Bind the DataTable to the GridView
                        gridview_viajes.DataSource = viajesData;
                        gridview_viajes.DataBind();
                    }
                    catch (Exception ex)
                    {
                        // Handle error (optional)
                        lbl_error.Text = "Error loading data: " + ex.Message;
                        lbl_error.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }


        protected void btn_return_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Bus.aspx");
        }
    }
}