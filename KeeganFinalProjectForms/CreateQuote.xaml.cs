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
    /// Interaction logic for CreateQuote.xaml
    /// </summary>
    public partial class CreateQuote : Window
    {
        public CreateQuote()
        {
            InitializeComponent();
            datCheckIn.SelectedDate = DateTime.Now;
            datCheckOutDate.SelectedDate = DateTime.Now;
        }

        private void btnCreateQuote_Click(object sender, RoutedEventArgs e)
        {
            //1.Declare Variables
            string strNumberOfRooms;
            int intNumberOfRooms;

            //2.Clear Results
            txbWarning.Text = "";
            txtNumRooms.Background = Brushes.White;
            cboRoomType.Background = Brushes.White;

            //4. Validate Number of Rooms is a Whole number.
            if (!Int32.TryParse(txtNumRooms.Text, out intNumberOfRooms))
            {
                txtNumRooms.Background = Brushes.LightPink;
                txbWarning.Text = "*Please enter a whole number for Number of Rooms.";
                return;
            }

            //5. Validate Number of Rooms isnt negative
            if (intNumberOfRooms < 1)
            {
                txtNumRooms.Background = Brushes.LightPink;
                txbWarning.Text = "*Please enter a number greater than 0";
                return;
            }

           
            //6.Validate that a room type is selected?
            if(!(cboRoomType.SelectedIndex > 0))
            {
                cboRoomType.Background = Brushes.LightPink;
                txbWarning.Text = "*Please select an option for room type";
                return;
            }

            //6.Validate that the check in date is before the check out date
            if(datCheckIn.SelectedDate > datCheckOutDate.SelectedDate)
            {
                txbWarning.Text = "*Check in date must be before Check out date";
                datCheckIn.Background = Brushes.LightPink;
                datCheckOutDate.Background = Brushes.LightPink;
                return;
            }

            //7.Validate that the check in date is in the future
            if(datCheckIn.SelectedDate <= DateTime.Now)
            {
                txbWarning.Text = "*Check in date must be in the future";
                datCheckIn.Background = Brushes.LightPink;
                return;
            }

            //8. Validate that the check out date is in the future
            if (datCheckOutDate.SelectedDate <= DateTime.Now)
            {
                txbWarning.Text = "*Check out date must be in the future";
                datCheckOutDate.Background = Brushes.LightPink;
                return;
            }

        }

        private void btnStartOver_Click(object sender, RoutedEventArgs e)
        {
            //Clear and Reset everything in the window?
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainScreen Mainscreen = new MainScreen();
            Mainscreen.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnReservation_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CreateReservation createreservation = new CreateReservation();
            createreservation.Show();
        }
    }
}
