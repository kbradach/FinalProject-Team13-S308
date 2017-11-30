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
    /// Interaction logic for CreateReservation.xaml
    /// </summary>
    public partial class CreateReservation : Window
    {
        public CreateReservation()
        {
            InitializeComponent();
        }

        private void btnCheckAvailability_Click(object sender, RoutedEventArgs e)
        {
            //1.Declare Variables

            //2.Verify that first name isnt blank
            //just letters?

            //3.Verify that last name isnt blank

            //4.Verify that card type is selected

            //5.Verify that card number isnt blank

            //6.Varify that card number is a valid (12 digits and not negative)

            //7.Verify that phone number isnt blank

            //8.Verify that phone is a ten digit number 
            //in format?

            //9.Verify that email isnt blank

            //10.Verify that email address is valid (@ and .)


        }

        private void btnCreateReservation_Click(object sender, RoutedEventArgs e)
        {
            //Verify that "Room Available" is Yes
        }

        private void btnReturnToQuote_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CreateQuote returntoquote = new CreateQuote();
            returntoquote.Show();
            //Will the values still be there?
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainScreen MainMenu = new MainScreen();
            MainMenu.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
