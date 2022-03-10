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

namespace Hospital
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

        private void btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtusuario.Text=="" || txtpassword.Text=="" )
            {
                MessageBox.Show("Falsta usuario o contraseña");
            }
            else
            {
                if (txtusuario.Text=="rlunas" && txtpassword.Text == "1234")
                {
                    MessageBox.Show("Bienvenido al Sistema");
                    menu frmmenu = new menu();
                    frmmenu.Show();
                    this.Hide();
                }
            }
        }

        private void btncancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
