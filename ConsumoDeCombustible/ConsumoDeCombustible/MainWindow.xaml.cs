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
            VehiculosAereos va = new VehiculosAereos();
           // CombustibleGastado cg = new CombustibleGastado();
            //Datos del Vehiculo
            va.Modelo = Convert.ToInt32(txtmodelo.Text);
            va.Marca = txtmarca.Text;
            va.Color = txtxcolor.Text;
            va.VelocidadActual = Convert.ToDouble(txtvelocidada.Text);
            va.VelocidadMaxima = Convert.ToDouble(txtvelocidadm.Text);
            va.Rendimiento = Convert.ToDouble(txtrendimiento.Text);
            va.CapacidadDeTanque = Convert.ToDouble(txtcapacidad.Text);
            //Datos del Vehiculo Aereo
            va.NumeroDeMotores = Convert.ToInt16(txtmotores.Text);
            va.AltitudMaxima = Convert.ToDouble(txtaltitud.Text);
            String Mensaje = va.Volar();
            va.distancia = Convert.ToDouble(txtdistancia.Text);
            Double gastoc = va.TotalConsumo();
            Double tiempoll = va.TiempoRecorrido();
            Double combustiblea = va.CombustibleRestante();
            lblresultado.Content = "El Vehiculo Modelo: " + va.Modelo + "\n Marca: " + va.Marca + "\n Con velocidad actual de: " + va.VelocidadActual + "Km/h \n  Gastara: " + gastoc + " Litros\n LLegara en un tiempo de: " + tiempoll*60 + "min \n Le restaran :" + combustiblea + "litros"; 
        }
    }
}
