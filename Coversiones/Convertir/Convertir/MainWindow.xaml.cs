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

namespace Convertir
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

        private void cp_Checked(object sender, RoutedEventArgs e)
        {

                Longitud cp=new Longitud();
                Double res=cp.cm_plg(Convert.ToDouble(txtvalor.Text));
                rp.Content = res;
  
        }

        private void cm_Checked(object sender, RoutedEventArgs e)
        {
            Longitud cp = new Longitud();
            Double res = cp.cm_mts(Convert.ToDouble(txtvalor.Text));
            rm.Content = res;
        }

        private void cmm_Checked(object sender, RoutedEventArgs e)
        {
            Longitud cp = new Longitud();
            Double res = cp.cm_mm(Convert.ToDouble(txtvalor.Text));
            rmm.Content = res;
        }

        private void pc_Checked(object sender, RoutedEventArgs e)
        {
            Longitud cp = new Longitud();
            Double res = cp.plg_cm(Convert.ToDouble(txtvalor.Text));
            rcm.Content = res;
        }

        private void kmt_Checked(object sender, RoutedEventArgs e)
        {
            Longitud cp = new Longitud();
            Double res = cp.km_millaterrestre(Convert.ToDouble(txtvalor.Text));
            rmt.Content = res;
        }

        private void kmm_Checked(object sender, RoutedEventArgs e)
        {
            Longitud cp = new Longitud();
            Double res = cp.km_millamarina(Convert.ToDouble(txtvalor.Text));
            rmm1.Content = res;
        }

        private void gk_Checked(object sender, RoutedEventArgs e)
        {
            Peso cp = new Peso();
            Double res = cp.gr_kg(Convert.ToDouble(txtvalor.Text));
            rk.Content = res;
        }

        private void gl_Checked(object sender, RoutedEventArgs e)
        {
            Peso cp = new Peso();
            Double res = cp.gr_lb(Convert.ToDouble(txtvalor.Text));
            rl.Content = res;
        }

        private void lg_Checked(object sender, RoutedEventArgs e)
        {
            Peso cp = new Peso();
            Double res = cp.lb_gr(Convert.ToDouble(txtvalor.Text));
            rg.Content = res;
        }

        private void cf_Checked(object sender, RoutedEventArgs e)
        {
            Temperatura cp = new Temperatura();
            Double res = cp.c_f(Convert.ToDouble(txtvalor.Text));
            rf.Content = res;
        }

        private void ck_Checked(object sender, RoutedEventArgs e)
        {
            Temperatura cp = new Temperatura();
            Double res = cp.c_k(Convert.ToDouble(txtvalor.Text));
            rk1.Content = res;
        }

        private void fc_Checked(object sender, RoutedEventArgs e)
        {
            Temperatura cp = new Temperatura();
            Double res = cp.f_c(Convert.ToDouble(txtvalor.Text));
            rc.Content = res;
        }

        private void fk_Checked(object sender, RoutedEventArgs e)
        {
            Temperatura cp = new Temperatura();
            Double res = cp.f_k(Convert.ToDouble(txtvalor.Text));
            rfk.Content = res;
        }
    }
}
