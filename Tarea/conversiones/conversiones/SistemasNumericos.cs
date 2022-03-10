using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    public class SistemasNumericos
    {
        public String dec_bin(int valor, int valor2)
        {
            string cadena="";
            for(int x=1; x<= valor2; x++)
            {
                    if (valor % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    valor = (int)(valor / 2);
            }
            return cadena;
        }
             
        public String dec_bin2(int valor)
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
            string b = dec_bin2(a);

            return b;
        }
    }
}
