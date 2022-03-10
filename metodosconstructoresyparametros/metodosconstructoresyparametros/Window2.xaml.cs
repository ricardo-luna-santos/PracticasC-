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

namespace metodosconstructoresyparametros
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window1 f2 { get; set; }
       public MainWindow f1 { get; set; }

        public Window2(Window1 f2, MainWindow f1)
        {
            InitializeComponent();
            this.f2 = f2;
            this.f1 = f1;
        }

        private void btnterminar_Click(object sender, RoutedEventArgs e)
        {
            if (txtescuela.Text == "" || txtestudio.Text == "")
            {
                MessageBox.Show("Faltan Datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                f1.Show();
                f1.lbletiqueta1.Content = f2.txtdomicilio.Text + ", " + f2.txtcolonia.Text + ", " + f2.txtciudad.Text;
                f1.lbletiqueta2.Content = txtescuela.Text + ", " + txtestudio.Text;
                this.Close();
            }
        }


    }
}
