using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class enfermera : trabajador
    {
        public Double HorasAdicionales { get; set; }
        public String Especialidad { get; set; }
        public String CorreoElectronico { get; set; }
        public Double CalculoTotal()
        {
            return CalcularPago() + (HorasAdicionales*salariobase);
        }
    }
}
