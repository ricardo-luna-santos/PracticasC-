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

namespace WpfApplicatio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double[] arreglo;
        TextBox txt;
        double a,res=0;
        int i=0;

        public MainWindow()
        {
            InitializeComponent();

        }


        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            arreglo = new double[Convert.ToInt32(txtnumero.Text)];
            MessageBox.Show("Arreglo creado");
            txtval.Visibility = Visibility.Visible;
            btnguardar.Visibility = Visibility.Visible;
            btncrear.Visibility = Visibility.Hidden;
        }

        private void btncrearmatriz_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int b = 0;

            for (int i = 1; i <= Convert.ToInt32(txtfilas.Text); i++)
            {
                a = a + 45;
                b = 0;

                for (int j=1; j<= Convert.ToInt32(txtcolumnas.Text);j++)
                {
                    
                    txt.Margin = new Thickness(10, a, b, 0);
                    txt.Width = 50;
                    txt.Height = 20;
                    txt.Name = "btn" + i+j;
                    Grid.SetColumn(txt, 0);
                    grid1.Children.Add(txt);
                    b = b + 130;
                    MessageBox.Show(txt.Name);

                }

            }
        }

        private void btnsuma_Click(object sender, RoutedEventArgs e)
        {
            res = 0;
            for (int j = 0; j < Convert.ToInt32(txtnumero.Text); j++)
           {
                res = res+arreglo[j];
                
            }
            MessageBox.Show("El resultado es: " + Convert.ToString(res));
            
        }

        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {
            if (i < Convert.ToInt32(txtnumero.Text))
                {
                txt = new TextBox();
                txt.Margin = new Thickness(10, a, 10, 0);
                txt.Width = 110;
                txt.Height = 20;
                txt.Text = txtval.Text;
                Grid.SetColumn(txt, 0);
                grid1.Children.Add(txt);
                a = a + 45;
                arreglo[i] = Convert.ToDouble(txt.Text);
                res = res + arreglo[i];
                i = i + 1;
                if (i == Convert.ToInt32(txtnumero.Text))
                {
                    btnguardar.Visibility = Visibility.Hidden;
                    txtval.Visibility = Visibility.Hidden;
                    btncrear.Visibility = Visibility.Visible;
                    
                }
                txtval.Text = "";
                
            }
            else
            {
                MessageBox.Show("El Arreglo esta lleno");
            }
           
        }

        private void txtnumero_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnmax_Click(object sender, RoutedEventArgs e)
        {
            double mayor;
            int pos;
            mayor = arreglo[0];
            pos = 0;
            for (int j = 0; j < Convert.ToInt32(txtnumero.Text); j++)
            {
                if (arreglo[j]>mayor)
                {
                    mayor = arreglo[j];
                    pos=j;
                }

            }
            MessageBox.Show("El Mayor es: " + arreglo[pos]);

        }

        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            double menor;
            int pos;
            menor = arreglo[0];
            pos = 0;
            for (int j = 0; j < Convert.ToInt32(txtnumero.Text); j++)
            {
                if (arreglo[j] < menor)
                {
                    menor = arreglo[j];
                    pos = j;
                }

            }
            MessageBox.Show("El Menor es: " + arreglo[pos]);
        }

        private void btnmedia_Click(object sender, RoutedEventArgs e)
        {
            res = 0;
            for (int j = 0; j < Convert.ToInt32(txtnumero.Text); j++)
            {
                res = res + arreglo[j];

            }
            MessageBox.Show("El resultado es: " + res/ Convert.ToDouble(txtnumero.Text));

        }

        private void btnmoda_Click(object sender, RoutedEventArgs e)
        {
            double moda;
            int pos;
            moda = arreglo[0];
            pos = 0;
            for (int j = 0; j < Convert.ToInt32(txtnumero.Text); j++)
            {
                if (arreglo[j] == moda)
                {
                    moda = arreglo[j];
                    pos = j;
                }

            }
            MessageBox.Show("La Moda es: " + arreglo[pos]);

        }

        private void txtval_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
