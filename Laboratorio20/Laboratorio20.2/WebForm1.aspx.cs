using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio20._2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            matriz.Controls.Clear();

            if (int.TryParse(txtDimension.Text, out int n) && n > 0)
            {
                Table tabla = new Table();

                for (int i = 0; i < n; i++)
                {
                    TableRow fila = new TableRow();
                    for (int j = 0; j < n; j++)
                    {
                        TableCell celda = new TableCell();
                        celda.Text = (i + j == n - 1) ? "1" : "0";
                        fila.Cells.Add(celda);
                    }
                    tabla.Rows.Add(fila);
                }

                matriz.Controls.Add(tabla);
                }
                else
                {
                    lblError.Text = "Por favor, ingrese un número entero positivo.";
                }
        }
    }
}