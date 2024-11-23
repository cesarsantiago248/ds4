using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio20._1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbNumero.Text, out int numero))
            {
                StringBuilder tabla = new StringBuilder();
                tabla.Append($"<h3>Tabla de multiplicar del {numero}:</h3>");
                tabla.Append("<ul>");

                for (int i = 1; i <= 25; i++)
                {
                    tabla.Append($"<li>{numero} x {i} = {numero * i}</li>");
                }

                tabla.Append("</ul>");

                lblResultado.Text = tabla.ToString();
            }
            else
            {
                lblResultado.Text = "<span style='color:red;'>Por favor, ingrese un número válido.</span>";
            }
        }
    }
}