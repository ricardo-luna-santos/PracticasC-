using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    public class Temperatura
    {
        public Double c_f(Double valor)
        {

            return (valor*1.8) + 32;
        }
        public Double c_k(Double valor)
        {
            return valor + 273.15;
        }
        public Double f_c(Double valor)
        {

            return (valor-32)/1.8;
        }
        public Double f_k(Double valor)
        {

            double fc = f_c(valor);
            double ck = c_k(fc);
            return ck;
        }
    }
}
