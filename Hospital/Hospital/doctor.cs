using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class doctor: trabajador
    {
        public Double pagosAdicionales { get; set; }
        public int cedula { get; set; }
        public String especialidad { get; set; }
        public Double CalculoTotal ()
        {
            return CalcularPago() + pagosAdicionales;
        }
    }
}
