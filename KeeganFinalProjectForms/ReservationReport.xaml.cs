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

namespace KeeganFinalProjectForms
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            datCheckInStart.SelectedDate = DateTime.Now;
            datCheckInEnd.SelectedDate = DateTime.Now;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //1.Declare Variables

            //2.Verify Check in date is in the future
            if(datCheckInEnd.SelectedDate > DateTime.Now)
            {
                txtLastNameInput.Background = Brushes.LightPink;
            }
            //3.Verify Check out date is in the future
            //or that its not in the past for current reservations

            //4.Veriy Check in date is before check out date

            //5.Verify that last name isnt blank

            //6.Verify that a room type is selected


        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainScreen MainMenu = new MainScreen();
            MainMenu.Show();
        }
    }
}
