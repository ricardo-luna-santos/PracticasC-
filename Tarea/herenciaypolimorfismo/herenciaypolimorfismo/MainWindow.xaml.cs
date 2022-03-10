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

namespace herenciaypolimorfismo
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

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            suma s = new suma();
            s.Numero1 = Convert.ToDouble(txtval1.Text);
            s.Numero2 = Convert.ToDouble(txtval2.Text);
            Double res = s.CalcularSuma();
            MessageBox.Show("El resultado de la suma es: " + res.ToString());
            resta r = new resta();
            r.Numero1 = Convert.ToDouble(txtval1.Text);
            r.Numero2 = Convert.ToDouble(txtval2.Text);
            Double res1 = r.CalcularResta();
            MessageBox.Show("El resultado de la resta es: " + res1.ToString());
            multiplicacion m = new multiplicacion();
            m.Numero1 = Convert.ToDouble(txtval1.Text);
            m.Numero2 = Convert.ToDouble(txtval2.Text);
            Double res2 = m.CalcularMultiplicación();
            MessageBox.Show("El resultado de la multiplicación es: " + res2.ToString());
            division d = new division();
            d.Numero1 = Convert.ToDouble(txtval1.Text);
            d.Numero2 = Convert.ToDouble(txtval2.Text);
            Double res3 = d.CalcularDivision();
            MessageBox.Show("El resultado de la división es: " + res3.ToString());
        }
    }
}
