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
        int[,] arreglo2,arreglo3;
        TextBox txt,txtm,txtmn,txtmnr;
        double a,res=0;
        int i=0;
        Random r = new Random();
      

        public MainWindow()
        {
            InitializeComponent();

        }


        private void btncrear_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            grid2.Children.Clear();
            arreglo = new double[Convert.ToInt32(txtnumero.Text)];
            MessageBox.Show("Arreglo creado");
            txtval.Visibility = Visibility.Visible;
            btnguardar.Visibility = Visibility.Visible;
            btncrear.Visibility = Visibility.Hidden;
        }

        private void btncrearmatriz_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            int b = 0;
            int c = 150;
            int d = 350;
            
            arreglo2 = new int[Convert.ToInt32(txtcolumnas.Text),Convert.ToInt32(txtfilas.Text)];
            arreglo3 = new int[Convert.ToInt32(txtcolumnas.Text), Convert.ToInt32(txtfilas.Text)];
            MessageBox.Show("Matriz creada");

            for(int i= 0; i< Convert.ToInt32(txtcolumnas.Text); i++)
            {
                for(int j=0;j< Convert.ToInt32(txtfilas.Text); j++)
                {
                    int aleatorio = r.Next(0, 100);
                    txtm = new TextBox();
                    txtm.HorizontalAlignment = HorizontalAlignment.Left;
                    txtm.Margin = new Thickness(b, a, 0, 0);
                    txtm.Width = 30;
                    txtm.Height = 20;
                    txtm.Text = Convert.ToString(aleatorio);
                    Grid.SetColumn(txtm, 0);
                    grid2.Children.Add(txtm);
                    a = a + 45;
                    arreglo2[i,j] = aleatorio;
                }
                b = b + 40;
                a =0;
            }
            c = b + 150;
            for (int k = 0; k < Convert.ToInt32(txtcolumnas.Text); k++)
            {
                for (int l = 0; l < Convert.ToInt32(txtfilas.Text); l++)
                {
                    int aleatorio = r.Next(0, 100);
                    txtmn = new TextBox();
                    txtmn.HorizontalAlignment = HorizontalAlignment.Left;
                    txtmn.Margin = new Thickness(c, a, 0, 0);
                    txtmn.Width = 30;
                    txtmn.Height = 20;
                    txtmn.Text = Convert.ToString(aleatorio);
                    Grid.SetColumn(txtmn, 0);
                    grid2.Children.Add(txtmn);
                    a = a + 45;
                    arreglo3[k,l] = aleatorio;
                }
                c = c + 40;
                a = 0;
            }
            d = c + 150;
            for (int m = 0; m < Convert.ToInt32(txtcolumnas.Text); m++)
            {
                for (int n = 0; n < Convert.ToInt32(txtfilas.Text); n++)
                { 
                    txtmnr = new TextBox();
                    txtmnr.HorizontalAlignment = HorizontalAlignment.Left;
                    txtmnr.Margin = new Thickness(d, a, 0, 0);
                    txtmnr.Width = 30;
                    txtmnr.Height = 20;
                    int resultado = arreglo2[m, n] + arreglo3[m, n];
                    txtmnr.Text = Convert.ToString(resultado);
                    Grid.SetColumn(txtmnr, 0);
                    grid2.Children.Add(txtmnr);
                    a = a + 45;
                }
                d = d + 40;
                a = 0;
            }
        }



        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {

            if (i < Convert.ToInt32(txtnumero.Text))
                {
                txt = new TextBox();
                txt.HorizontalAlignment = HorizontalAlignment.Left;
                txt.Margin = new Thickness(10, a, 0, 0);
                txt.Width = 110;
                txt.Height = 20;
                txt.Text = txtval.Text;
                Grid.SetColumn(txt, 0);
                grid2.Children.Add(txt);
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
        private void btnsuma_Click(object sender, RoutedEventArgs e)
        {
            res = 0;
            for (int j = 0; j < Convert.ToInt32(txtnumero.Text); j++)
            {
                res = res + arreglo[j];

            }
            MessageBox.Show("El resultado es: " + Convert.ToString(res));

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
            int rep = 0;
            int k,j;
            double moda=0;
            for (j = 0; j < Convert.ToInt32(txtnumero.Text); j++)
            {
                for (k = (j+1); k < Convert.ToInt32(txtnumero.Text); k++)
                {
                    if (arreglo[j] == arreglo[k])
                    {
                        rep++;
                        moda = arreglo[j];
                    }
                }
            }
            MessageBox.Show("Moda igual" + moda);
        }

        private void btnmediana_Click(object sender, RoutedEventArgs e)
        {
            int length = arreglo.Length;
            int mediana,par,mediana2;
            Array.Sort(arreglo);
            for (int i = 0; i < length; i++)
            {
                MessageBox.Show("Hordenando el Arreglo Posición: " +i+" Valor "+ Convert.ToString(arreglo[i]));
            }
            par = length % 2;
            //MessageBox.Show("resultado"+par);
            if (par == 1)
            {
                mediana = (length) / 2;
                MessageBox.Show("Mediana: " + Convert.ToString(arreglo[mediana]));
            }
            else
            {
                mediana = (length + 1)/2;
                mediana2 = (length - 1) / 2;
                MessageBox.Show("Mediana: " + Convert.ToString(arreglo[mediana])+"y"+ Convert.ToString(arreglo[mediana2]));
            }
           
            
        }

        private void btnguardar2_Click(object sender, RoutedEventArgs e)
        {
            if (i < Convert.ToInt32(txtnumero.Text))
            {
                txt = new TextBox();
                txt.HorizontalAlignment = HorizontalAlignment.Left;
                txt.Margin = new Thickness(10, a, 0, 0);
                txt.Width = 110;
                txt.Height = 20;
                txt.Text = txtval.Text;
                Grid.SetColumn(txt, 0);
                grid1.Children.Add(txt);
                a = a + 45;
                arreglo[i] = Convert.ToDouble(txt.Text);
                res = res + arreglo[i];
                i = i + 1;
//                txtval.Text = "";

            }
            else
            {
                MessageBox.Show("El Arreglo esta lleno");
            }
    }

        private void txtval_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
