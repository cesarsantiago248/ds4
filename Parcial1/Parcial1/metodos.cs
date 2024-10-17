using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class metodos
    {
        public double yardaMetro(double yardasInput)
        {
            double metrosResultado = yardasInput * 0.9144;
            return metrosResultado;
        }

        public double metroYarda(double metrosInput)
        {
            double yardasResultado = metrosInput / 0.9144;
            return yardasResultado;
        }

    }
}
