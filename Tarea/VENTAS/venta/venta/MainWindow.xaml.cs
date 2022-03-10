using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace venta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox[,] elementoslista;
        int x,p=0,res1=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, RoutedEventArgs e)
        {
            txtsubtotal.Text = "";
            btnagregar.Visibility = Visibility.Visible;
            int g = 47;   
            grid2.Children.Clear();
            for (int f = 0; f < 4; f++)
            {
                Label etiqueta = new Label();
                etiqueta.Height = 23;
                etiqueta.Width = 160;
                if (f == 0)
                {
                    etiqueta.Content = "CANTIDAD";
                }
                else if (f == 1)
                {
                    etiqueta.Content = "CODIGO";
                } if (f == 2)
                {
                    etiqueta.Content = "PRECIO UNITARIO";
                } if (f == 3)
                {
                    etiqueta.Content = "PRECIO TOTAL";
                }
                
                etiqueta.Margin = new Thickness(g, 10, 0, 0);
                etiqueta.VerticalAlignment = VerticalAlignment.Top;
                etiqueta.HorizontalAlignment = HorizontalAlignment.Left;
                grid2.Children.Add(etiqueta);
                 g = g + 200;
            }


            int filas = Convert.ToInt16(txtnumero.Text);
            elementoslista = new TextBox[filas, 4];
            int y = 31;
            for (int i = 0; i < filas; i++)
            {
                elementoslista[i,0]=new TextBox();
                elementoslista[i, 0].Height = 23;
                elementoslista[i, 0].Width = 160;
                elementoslista[i, 0].Margin = new Thickness(10, y, 0, 0);
                elementoslista[i,0].VerticalAlignment=VerticalAlignment.Top;
                elementoslista[i,0].HorizontalAlignment=HorizontalAlignment.Left;
                grid2.Children.Add(elementoslista[i,0]);
                x = 190;
                for (int j = 1; j < 4; j++)
                {
                    elementoslista[i, j] = new TextBox();
                    elementoslista[i, j].Height = 23;
                    elementoslista[i, j].Width = 180;
                    elementoslista[i, j].Margin = new Thickness(x, y, 0, 0);
                    elementoslista[i, j].VerticalAlignment = VerticalAlignment.Top;
                    elementoslista[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    grid2.Children.Add(elementoslista[i, j]);
                    x += 200;
                }
                y = y + 31;
                
            }
            if (y<255)
            {
                grid2.Height = 255;
            }
            else
            {
                grid2.Height = y;
            }

        }

        private void btncrear_Click(object sender, RoutedEventArgs e)
        {

            String hora=DateTime.Now.ToString("hmmss");
            String fecha = DateTime.Now.ToString("ddMMyyyy");
            String cadena = "V" + fecha + "_" + hora + ".txt";
            using (StreamWriter writer = new StreamWriter(cadena))
            {
                writer.WriteLine(string.Format("{0}", txtrfc.Text));
                writer.WriteLine(string.Format("{0}", txtnombre.Text));
                writer.WriteLine(string.Format("{0}", txtcorreo.Text));
                writer.WriteLine(string.Format("{0}",txtuso.Text));
                for( int a = 0;a< Convert.ToInt16(txtnumero.Text); a++)
                {
                    writer.WriteLine(string.Format("{0},{1},{2}", elementoslista[a, 0].Text,elementoslista[a, 1].Text,elementoslista[a, 2].Text));
                }
            }
            MessageBox.Show("Venta Guardada");
            grid2.Children.Clear();
        }

        private void btnventa_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            String ruta = "V" + txtf.Text + "_" + txth.Text + ".txt";
            StreamReader archivo = File.OpenText(ruta);
            string linea = null;
            int i = 0,a=0;
            int y = 31;
            elementoslista = new TextBox[8, 4];
            while (!archivo.EndOfStream)
            {
                //Leer la 3ra línea:
                linea = archivo.ReadLine();
                y = y + 31;
                if (++i == 1)
                {
                    txtrfc.Text = (linea);
                }else if (i == 2)
                {
                    txtnombre.Text = (linea);
                }else if (i == 3)
                {
                    txtcorreo.Text = (linea);
                }else if (i == 4)
                {
                    txtuso.Text = (linea);
                }
                else
                {
                   string[] separadas;
                   separadas = linea.Split(',');
                    x = 10;
                    for (int b = 0; b < 4; b++)
                    {
                        elementoslista[a, b] = new TextBox();
                        elementoslista[a, b].Height = 23;
                        elementoslista[a, b].Width = 160;
                        elementoslista[a, b].Margin = new Thickness(x, y - 150, 0, 0);
                        elementoslista[a, b].VerticalAlignment = VerticalAlignment.Top;
                        elementoslista[a, b].HorizontalAlignment = HorizontalAlignment.Left;
                        if (b < 3)
                        {
                            elementoslista[a, b].Text = separadas[b];
                        }
                        else
                        {
                            int res = Convert.ToInt32(elementoslista[a, 0].Text) * Convert.ToInt32(elementoslista[a, 2].Text);
                            elementoslista[a, b].Text = Convert.ToString(res);
                            res1 = res1 + res;
                            txtsubtotal.Text = Convert.ToString(res1);
                            txtiva.Text = Convert.ToString(res1 * .16);
                            txttotal.Text = Convert.ToString(res1 + (res1 * .16));
                        }
                       
                        grid2.Children.Add(elementoslista[a, b]);
                        x = x + 190;
                    }
                    
                }
             //break;
            }
            a = a + 1;
        }

        private void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            
            for (int b = 0; b < 4; b++)
            {
                if (b==0)
                {
                    elementoslista[p, b].Text = txtcantidad.Text;
                }else if(b==1){
                     elementoslista[p, b].Text=txtcodigo.Text;
                }
                else if (b == 2)
                {
                    elementoslista[p, b].Text = txtpresiou.Text;
                }
                else if (b == 3)
                {
                    int res = Convert.ToInt16(txtcantidad.Text) * Convert.ToInt16(txtpresiou.Text);
                    elementoslista[p, b].Text = Convert.ToString(res);
                    res1 = res1 + res;
                    txtsubtotal.Text = Convert.ToString(res1);
                    txtiva.Text = Convert.ToString(res1 * .16);
                    txttotal.Text = Convert.ToString(res1+ (res1*.16));
                }
                              
            }
            txtcantidad.Text = "";
            txtcodigo.Text = "";
            txtpresiou.Text = "";
            p = p + 1;

            if (p == Convert.ToInt32(txtnumero.Text))
            {
                btnagregar.Visibility = Visibility.Hidden;
            }
            
        }

        private void txtnumero_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
