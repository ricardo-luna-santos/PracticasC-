using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeCombustible
{
    public class VehiculosAereos: Vehiculos
    {
        public int NumeroDeMotores { get; set; }
        public Double AltitudMaxima { get; set; }

        public String Volar ()
        {
            return "Despegar e iniciar vuelo";
        }
        public String Aterrizar()
        {
            return "Bajar lentamente a la pista";
        }
    }
}
