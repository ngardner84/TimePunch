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

namespace TimePunch
{
    /// <summary>
    /// Interaction logic for Punch1Window.xaml
    /// </summary>
    public partial class Punch1Window : Page
    {



        public Punch1Window()
        {
            InitializeComponent();
        }

        private void Start_Shift(object sender, RoutedEventArgs e)
        {

        }

        private void End_Shift(object sender, RoutedEventArgs e)
        {

        }

        private void Start_Lunch(object sender, RoutedEventArgs e)
        {

        }

        private void End_Lunch(object sender, RoutedEventArgs e)
        {

        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new Login();
        }
    }
}
