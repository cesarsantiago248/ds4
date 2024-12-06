using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace semestralcs
{
    public partial class Portal_Avión : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_saldo_tarifa_Click(object sender, EventArgs e)
        {
            Response.Redirect("Avión_Consulta_Saldo.aspx");
        }

        protected void btn_add_saldo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Avión_Agregar_Saldo.aspx");
        }

        protected void btn_agendar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Avión_Agendar.aspx");
        }

        protected void btn_viajes_agendados_Click(object sender, EventArgs e)
        {
            Response.Redirect("Avión_Viajes.aspx");
        }

        protected void btn_return_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}