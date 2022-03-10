using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    public class Peso
    {
        public Double gr_kg(Double valor)
        {
            return valor/1000;
        }
        public Double gr_lb(Double valor)
        {
            return valor / 453.592;
        }
        public Double lb_gr(Double valor)
        {
            return valor* 453.592;
        }
    }
}
