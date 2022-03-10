using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeCombustible
{
    class Helicoptero:VehiculosAereos
    {
        public Boolean TrenDeAterrizage { get; set; }
        public Double CapacidadDeCarga { get; set; }
        public Double PotenciaDelMotor { get; set; }
    }
}
