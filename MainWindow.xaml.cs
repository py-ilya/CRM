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


namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new MainPage());
        }

        private void docContractors_MouseLeave(object sender, MouseEventArgs e)
        {
            docContractors.Background = null;
        }

        private void docContractors_MouseMove(object sender, MouseEventArgs e)
        {
            docContractors.Background = Brushes.DarkOrange;
        }

        private void docContractors_MouseUp(object sender, MouseButtonEventArgs e)
        {
          
            frame.NavigationService.Navigate(new Page1());
   
        }

        private void btnHome_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            frame.NavigationService.Navigate(new MainPage());
          
        }

        private void docCompanies_MouseMove(object sender, MouseEventArgs e)
        {
            docCompanies.Background = Brushes.DarkOrange;
        }

        private void docCompanies_MouseLeave(object sender, MouseEventArgs e)
        {
            docCompanies.Background = null;
        }

        private void docAgreements_MouseMove(object sender, MouseEventArgs e)
        {
            docAgreements.Background = Brushes.DarkOrange;
        }

        private void docAgreements_MouseLeave(object sender, MouseEventArgs e)
        {
            docAgreements.Background = null;
        }

        private void docActs_MouseMove(object sender, MouseEventArgs e)
        {
            docActs.Background = Brushes.DarkOrange;
        }

        private void docActs_MouseLeave(object sender, MouseEventArgs e)
        {
            docActs.Background = null;
        }

        private void docInvoices_MouseMove(object sender, MouseEventArgs e)
        {
            docInvoices.Background = Brushes.DarkOrange;
        }

        private void docInvoices_MouseLeave(object sender, MouseEventArgs e)
        {
            docInvoices.Background = null;
        }

        private void docStatus_MouseMove(object sender, MouseEventArgs e)
        {
            docStatus.Background = Brushes.DarkOrange;
        }

        private void docStatus_MouseLeave(object sender, MouseEventArgs e)
        {
            docStatus.Background = null;
        }

        private void docOthers1_MouseMove(object sender, MouseEventArgs e)
        {
            docOthers1.Background = Brushes.DarkOrange;
        }

        private void docOthers1_MouseLeave(object sender, MouseEventArgs e)
        {
            docOthers1.Background = null;
        }

        private void docOthers2_MouseMove(object sender, MouseEventArgs e)
        {
            docOthers2.Background = Brushes.DarkOrange;
        }

        private void docOthers2_MouseLeave(object sender, MouseEventArgs e)
        {
            docOthers2.Background = null;
        }

        private void docOthers3_MouseMove(object sender, MouseEventArgs e)
        {
            docOthers3.Background = Brushes.DarkOrange;
        }

        private void docOthers3_MouseLeave(object sender, MouseEventArgs e)
        {
            docOthers3.Background = null;
        }

        private void docCompanies_MouseUp(object sender, MouseButtonEventArgs e)
        {
            frame.NavigationService.Navigate(new PageCompanies());
        }
    }
}
