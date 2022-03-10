using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeCombustible
{
    public class VehiculosAereos: Vehiculos
    {
        public Double AltitudMaxima { get; set; }
        public int NumeroDeMotores { get; set; }
        public int NumeroDePuertas { get; set; }
        public String Despegar ()
        {
            return "Despegar e iniciar vuelo";
        }
        public String Aterrizar()
        {
            return "Bajar lentamente a la pista";
        }
    }
}
