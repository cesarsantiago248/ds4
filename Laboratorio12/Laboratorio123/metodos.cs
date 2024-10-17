using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio123
{
    public class metodos
    {

        public double calcularSemiperi(double ladoA, double ladoB, double ladoC)
        {
            double s = (ladoA + ladoB + ladoC) / 2;
            return s;
        }

        public double calcularArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}
