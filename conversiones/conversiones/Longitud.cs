using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    public class Longitud
    {
        public Double cm_plg(Double valor)
        {
            return valor / 2.54;
        }
        public Double cm_mts(Double valor)
        {
            return valor / 100;
        }
        public Double cm_mm(Double valor)
        {
            return valor * 10;
        }
        public Double plg_cm(Double valor)
        {
            return valor * 2.54;
        }
        public Double km_millaterrestre(Double valor)
        {
            return (valor*1000) / 1609;
        }
        public Double km_millamarina(Double valor)
        {
            return (valor*1000) / 1852;
        }
    }
}
