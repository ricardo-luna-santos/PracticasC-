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

namespace edaddeunapersona
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
        public int CalcularEdad(DateTime fechaActual,DateTime fechaNacimiento)
        {
            
            TimeSpan ResFecha = fechaActual - fechaNacimiento;
            int anios = ResFecha.Days;
            double canios = anios / 365.20;

            return Convert.ToInt32(canios);
        }

        private void btnuno_Click(object sender, RoutedEventArgs e)
        {
            DateTime fn = Convert.ToDateTime(txtnacimiento.Text);
            DateTime fa = Convert.ToDateTime(txtactual.Text);
            int a = CalcularEdad(fa,fn);
            lblresultado.Content = a;

        }
          public int CalcularEdad1(int diaA, int mesA, int anioA,int diaN, int mesN, int anioN)
          {
            int edad = anioA - anioN;

            if (mesN > mesA)
            {
                edad--;
            }
            if (mesN==mesA && diaN> diaA){
                edad--;
            }
            return edad;
         }

        private void btnmetodo2_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(txtdn.Text);
            int b = Convert.ToInt32(txtmn.Text);
            int c = Convert.ToInt32(txtan.Text);

            int d = Convert.ToInt32(txtda.Text);
            int e1 = Convert.ToInt32(txtma.Text);
            int f = Convert.ToInt32(txtaa.Text);

            int resedad = CalcularEdad1(a,b,c,d,e1,f);
            lblresultado2.Content = resedad;
        }
    }
}
