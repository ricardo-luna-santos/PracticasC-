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
using conversiones;
using System.Text.RegularExpressions;

namespace SistemaNumerico
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

        private void cboopciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboopciones.SelectedIndex == 0)
            {
                lblongitud.Visibility = Visibility.Visible;
                txtlongitud.Visibility = Visibility.Visible;
            }
            else
            {
                lblongitud.Visibility = Visibility.Hidden;
                txtlongitud.Visibility = Visibility.Hidden;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (cboopciones.SelectedIndex < 0 || txtdato.Text=="")
            {
                MessageBox.Show("Error selecciona un tipo de conversion");
            }
            else
            {

                if (cboopciones.SelectedIndex == 0)
                {
                   
                    lblresultado.Content = "";
                    SistemasNumericos db = new SistemasNumericos();
                    string res = db.dec_bin(Convert.ToInt32(txtdato.Text),Convert.ToInt32(txtlongitud.Text));
                    lblresultado.Content = res;

                }
                if (cboopciones.SelectedIndex == 1)
                {
                    lblresultado.Content = "";
                    SistemasNumericos dh = new SistemasNumericos();
                    string res2 = dh.dec_hex(Convert.ToInt32(txtdato.Text));
                    lblresultado.Content = res2;

                }
                if (cboopciones.SelectedIndex == 2)
                {
                    lblresultado.Content = "";
                    SistemasNumericos bd = new SistemasNumericos();
                    int res3 = bd.bin_dec(txtdato.Text);
                    lblresultado.Content = res3;

                }
                if (cboopciones.SelectedIndex == 3)
                {
                    lblresultado.Content = "";
                    SistemasNumericos hd = new SistemasNumericos();
                    int res4 = hd.hex_dec(txtdato.Text);
                    lblresultado.Content = res4;
                }
                if (cboopciones.SelectedIndex == 4)
                {
                    lblresultado.Content = "";
                    SistemasNumericos bh = new SistemasNumericos();
                    string res4 = bh.bin_hex(txtdato.Text);
                    lblresultado.Content = res4;
                }
                if (cboopciones.SelectedIndex == 5)
                {
                    lblresultado.Content = "";
                    SistemasNumericos hb = new SistemasNumericos();
                    string res4 = hb.hex_bin(txtdato.Text);
                    lblresultado.Content = res4;
                }
            }
        }

        private void txtdato_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cboopciones.SelectedIndex == 0)
            {
               
                Regex Val = new Regex(@"^-?[0-9]+(\.?[0-9]+)?$"); ;
                if (Val.IsMatch(txtdato.Text))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, introduzca solo nùmeros.");
                }

            }
            else if (cboopciones.SelectedIndex == 1)
            {

                Regex Val = new Regex(@"^-?[0-9]+(\.?[0-9]+)?$"); ;
                if (Val.IsMatch(txtdato.Text))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, introduzca solo nùmeros.");
                }
            }
            else if (cboopciones.SelectedIndex == 2)
            {

                Regex Val = new Regex(@"^-?[0-1]+(\.?[0-1]+)?$"); ;
                if (Val.IsMatch(txtdato.Text))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, introduzca solo 0 o 1");
                }
            }
            else if (cboopciones.SelectedIndex == 3)
            {

                Regex Val = new Regex(@"^-?[0-9a-fA-F]+(\.?[0-9a-fA-F]+)?$"); ;
                if (Val.IsMatch(txtdato.Text))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, introduzca solo caracteres validos");
                }
            }
            else if (cboopciones.SelectedIndex == 4)
            {

                Regex Val = new Regex(@"^-?[0-1]+(\.?[0-1]+)?$"); ;
                if (Val.IsMatch(txtdato.Text))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, introduzca solo 1 o 0.");
                }
            }
            else if (cboopciones.SelectedIndex == 5)
            {

                Regex Val = new Regex(@"^-?[0-9a-fA-F]+(\.?[0-9a-fA-F]+)?$"); ;
                if (Val.IsMatch(txtdato.Text))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, introduzca solo caracteres validos");
                }
            }
        }
    }
}
