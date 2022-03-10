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
  
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (cboopciones.SelectedIndex < 0)
            {
                MessageBox.Show("Error selecciona un tipo de conversion");
            }
            else
            {

                if (cboopciones.SelectedIndex == 0)
                {
                    
                    lblresultado.Content = "";
                    SistemasNumericos db = new SistemasNumericos();
                    string res = db.dec_bin(Convert.ToInt32(txtdato.Text));
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
    }
}
