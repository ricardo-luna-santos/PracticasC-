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
    /// Lógica de interacción para menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            vistapersona frmpersona = new vistapersona();
            frmpersona.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            vistatrabajador frmtrabajador = new vistatrabajador();
            frmtrabajador.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            vistapaciente frmpaciente = new vistapaciente();
            frmpaciente.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
