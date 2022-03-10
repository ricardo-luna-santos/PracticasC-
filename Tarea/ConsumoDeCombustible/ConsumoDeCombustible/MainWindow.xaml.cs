using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConsumoDeCombustible
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {
            Avion va = new Avion();
            // CombustibleGastado cg = new CombustibleGastado();
            //Datos del Vehiculo
            va.Modelo = Convert.ToInt32(txtmodelo.Text);
            va.Marca = txtmarca.Text;
            va.Color = txtxcolor.Text;
            va.VelocidadActual = Convert.ToDouble(txtvelocidada.Text);
            va.VelocidadMaxima = Convert.ToDouble(txtvelocidadm.Text);
            va.Rendimiento = Convert.ToDouble(txtrendimiento.Text);
            va.CapacidadDeTanque = Convert.ToDouble(txtcapacidad.Text);
            va.distancia = Convert.ToDouble(txtdistancia.Text);
            //Datos del Vehiculo Aereo
            va.NumeroDeMotores = Convert.ToInt32(txtmotores.Text);
            va.AltitudMaxima = Convert.ToDouble(txtaltitud.Text);
            va.NumeroDePuertas = Convert.ToInt32(txtpuertasavion.Text);
            //Datos Avión
            va.NumeroDePasajeros = Convert.ToInt32(txtpasajeros.Text);
            va.Ruta = cborutaavion.Text;
            String Mensaje = va.Despegar();
            String Mensaje2 = va.Aterrizar();

            va.distancia = Convert.ToDouble(txtdistancia.Text);
            Double gastoc = va.TotalConsumo();
            Double tiempoll = va.TiempoRecorrido();
            Double combustiblea = va.CombustibleRestante();
            lblresultado.Content = "El Vehiculo Modelo: " + va.Modelo + "\n Marca: " + va.Marca + "\n Con velocidad actual de: " + va.VelocidadActual + "Km/h \n  Gastara: " + gastoc + " Litros\n LLegara en un tiempo de: " + tiempoll * 60 + "min \n Le restaran :" + combustiblea + "litros \n Ruta: " + va.Ruta + " Numeros de Pasajeros: " + va.NumeroDePasajeros;
}

        private void btnguardaraauto_Click(object sender, RoutedEventArgs e)
        {

            AutoSedan va = new AutoSedan();
            //Datos del Vehiculo
            va.Modelo = Convert.ToInt32(txtmodelo.Text);
            va.Marca = txtmarca.Text;
            va.Color = txtxcolor.Text;
            va.VelocidadActual = Convert.ToDouble(txtvelocidada.Text);
            va.VelocidadMaxima = Convert.ToDouble(txtvelocidadm.Text);
            va.Rendimiento = Convert.ToDouble(txtrendimiento.Text);
            va.CapacidadDeTanque = Convert.ToDouble(txtcapacidad.Text);
            va.distancia = Convert.ToDouble(txtdistancia.Text);
            //Datos del Vehiculo Terrestre
            va.NumeroRuedas = Convert.ToInt32(txtruedas.Text);
            va.NumeroPuertas = Convert.ToInt32(txtpuertasauto.Text);
            va.KilometrajeActual = Convert.ToDouble(txtkilometrajeactual.Text);
            //datos del AutomovilSedan
            va.AltoMaletero = Convert.ToDouble(txtalto.Text);
            va.AnchoMaletero = Convert.ToDouble(txtancho.Text);
            va.LargoMaletero = Convert.ToDouble(txtlargo.Text);
            va.NumeroDePasajeros = Convert.ToInt32(txtpasajerosauto.Text);
            if (chkclima.IsChecked == true)
            {
                va.Clima = true;
            }
            else
            {
                va.Clima = false;
            }
            if (chkdescapotable.IsChecked == true)
            {
                va.Descapotable = true;
            }
            else
            {
                va.Descapotable = false;
            }
            if (chkturbo.IsChecked == true)
            {
                va.Turbo = true;
            }
            else
            {
                va.Turbo = false;
            }
            //Datos Vehiculo Terrestre

            String Mensaje = va.Avanzar();
            String Mensaje2 = va.Detener();

            va.distancia = Convert.ToDouble(txtdistancia.Text);
            Double gastoc = va.TotalConsumo();
            Double tiempoll = va.TiempoRecorrido();
            Double combustiblea = va.CombustibleRestante();
            lblresultado.Content = "El Vehiculo Modelo: " + va.Modelo + "\n Marca: " + va.Marca + "\n Con velocidad actual de: " + va.VelocidadActual + "Km/h \n  Gastara: " + gastoc + " Litros\n LLegara en un tiempo de: " + tiempoll + 
            "hrs \n Le restaran :" + combustiblea + "litros \n Medidas del Maletero: " + va.AltoMaletero+" cm de alto "+va.AnchoMaletero+"cm ancho "+va.LargoMaletero +"cm de largo "+ "\n Numeros de Pasajeros: " + va.NumeroDePasajeros+
            "Tiene Clima "+va.Clima+" Tiene Turbo "+va.Turbo+" Es descapotable "+va.Descapotable+"\n "+Mensaje+" Su kilometraje subio a "+ (va.KilometrajeActual + va.distancia) ;

        }
    }
}
