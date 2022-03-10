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

namespace formularios
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public MainWindow f1 { get; set; }
        public Window1(MainWindow f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void btnregresar_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow form2 = new MainWindow();
            //f1.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            f1.Show();

        }
    }
}
