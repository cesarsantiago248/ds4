using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio121
{
    public class metodos
    {
        public double calculaDistancia(double velocidad, double tiempo)
        {
            double distancia = velocidad / tiempo;
            return distancia;
        }
        public void VaciarTodo(params TextBox[] textboxes)
        {
            foreach (var textbox in textboxes)
            {
                textbox.Clear();
            }
        }

    }
}
