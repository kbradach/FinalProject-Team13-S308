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

namespace KeeganFinalProjectForms
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        public MainScreen()
        {
            //test change
        }

        private void btnNewReservation_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CreateQuote createquote = new CreateQuote();
            createquote.Show();
        }

        private void btnRoomManagement_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RoomManagement roommanagement = new RoomManagement();
            roommanagement.Show();
        }

        private void btnReservationReport_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 reservationreport = new Window1();
            reservationreport.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
