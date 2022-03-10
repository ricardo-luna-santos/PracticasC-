using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class trabajador
    {
        public String rfc { get; set; }
        public String area { get; set; }
        public String cargo { get; set; }
        public Double salariobase { get; set; }
        public int horastrabajadas { get; set; }
        public Double CalcularPago()
        {
            return horastrabajadas * salariobase;
        }
    }
}
