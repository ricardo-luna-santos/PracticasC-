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
using System.Windows.Shapes;

namespace Hospital
{
    /// <summary>
    /// Lógica de interacción para tranajador.xaml
    /// </summary>
    public partial class vistatrabajador : Window
    {
        public vistatrabajador()
        {
            InitializeComponent();
        }

        private void txtadicionales_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbotrabajador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbotrabajador.SelectedIndex==0)
            {
                gbdoctor.Visibility = Visibility.Visible;
                gbenfermera.Visibility = Visibility.Hidden;
                gbadministrativo.Visibility = Visibility.Hidden;

            }
            else if (cbotrabajador.SelectedIndex == 1)
            {
                gbenfermera.Visibility = Visibility.Visible;
                gbdoctor.Visibility = Visibility.Hidden;
                gbadministrativo.Visibility = Visibility.Hidden;
            }
            else
            {
                gbadministrativo.Visibility = Visibility.Visible;
                gbenfermera.Visibility = Visibility.Hidden;
                gbdoctor.Visibility = Visibility.Hidden;
            }
        }
    }
}
