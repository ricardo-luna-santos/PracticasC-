using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class administrativo:trabajador
    {
        public Double Descuento { get; set; }
        public Double CalculoTotal()
        {
            return CalcularPago() - Descuento;
        }
    }
}
