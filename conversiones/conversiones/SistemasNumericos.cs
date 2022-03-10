using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    public class SistemasNumericos
    {
        public String dec_bin(int valor)
        {
             return Convert.ToString(valor, 2);
        }
        public String dec_hex(int valor)
        {
            
            return Convert.ToString(valor, 16);
        }
        public int bin_dec(string valor)
        {
            return Convert.ToInt32(valor, 2);
        }
        public int hex_dec(string valor)
        {
            return Convert.ToInt32(valor, 16);
        }

        public String bin_hex(string valor)
        {
            int a = bin_dec(valor);
            string b = dec_hex(a);
            return b;
        }

        public String hex_bin(string valor)
        {
            int a = hex_dec(valor);
            string b = dec_bin(a);

            return b;
        }
    }
}
