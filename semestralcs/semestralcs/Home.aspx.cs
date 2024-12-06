using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace semestralcs
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_user.Text = GlobalStorage.user1;
        }

        protected void btn_tren_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Tren.aspx");
        }

        protected void btn_bus_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Bus.aspx");
        }

        protected void btn_avion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Portal_Avión.aspx");
        }
    }
}