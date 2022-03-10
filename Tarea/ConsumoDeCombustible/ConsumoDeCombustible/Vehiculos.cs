using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeCombustible
{
    public class Vehiculos
    {
        public int Modelo { get; set; }
        public String Marca { get; set; }
        public String Color { get; set; }
        public Double VelocidadMaxima { get; set; }
        public Double VelocidadActual{get; set;}
        public Double Rendimiento { get; set; }
        public Double CapacidadDeTanque { get; set; }
        public Double distancia { get; set; }


        public Double TotalConsumo()
        {
            return distancia / Rendimiento; //consumo de gasolina de acuerdo ala distancia
        }
        public Double TiempoRecorrido()
        {
            return distancia / VelocidadActual;//tiempo transcurrido en el recorrido
        }
        public Double CombustibleRestante()
        {
            return CapacidadDeTanque - TotalConsumo();
        }
    }
}
