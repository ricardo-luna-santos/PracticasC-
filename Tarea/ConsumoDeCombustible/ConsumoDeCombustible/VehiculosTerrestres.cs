using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeCombustible
{
    public class VehiculosTerrestres:Vehiculos
    {
        public int NumeroRuedas { get; set; }
        public int NumeroPuertas { get; set; }
        public Double KilometrajeActual { get; set; }
        public String Detener ()
        {
            return "Frenar";
        }
        public String Avanzar()
        {
            return "Poner velocidad y acelerar";
        }
    }
}
