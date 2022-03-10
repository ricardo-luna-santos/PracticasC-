using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeCombustible
{
    public class AutoSedan:VehiculosTerrestres
    {
        public Double AltoMaletero { get; set; }
        public Double AnchoMaletero { get; set; }
        public Double LargoMaletero { get; set; }
        public int NumeroDePasajeros { get; set; }
        public Boolean  Descapotable { get; set; }
        public Boolean Clima { get; set; }
        public Boolean Turbo { get; set; }
    }
}
