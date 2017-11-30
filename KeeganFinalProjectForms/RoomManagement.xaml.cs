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
using System.IO;
using Newtonsoft.Json;
using Microsoft.Win32;

namespace KeeganFinalProjectForms
{
    /// <summary>
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        List<Room> roomList;
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //1. Declare Variables
            string strPrice;
            double dblPrice;
            string strQuantity;
            int intQuantity;

            //Clear Results
            txbWarning.Text = "";
            txtPrice.Background = Brushes.White;
            txtQuantity.Background = Brushes.White;
            cboRoomType.Background = Brushes.White;

            //2.Verify room type is selected
            if (!(cboRoomType.SelectedIndex > 0))
            {
                cboRoomType.Background = Brushes.LightPink;
                txbWarning.Text = "*Please select an option for room type";
                return;
            }

            //3.Verify Price is a number
            if (!double.TryParse(txtPrice.Text, out dblPrice))
            {
                txtPrice.Background = Brushes.LightPink;
                txbWarning.Text = "*Please enter a number for price.";
                return;
            }


            //4. Verify Price isnt negative
            if (dblPrice < 0)
            {
                txtPrice.Background = Brushes.LightPink;
                txbWarning.Text = "*Please enter a non-negative price";
                return;
            }

            //5. Verify Quantity of rooms is a number
            if (Int32.TryParse(txtQuantity.Text, out intQuantity))
            {
                txtQuantity.Background = Brushes.LightPink;
                txbWarning.Text = "*Please enter a whole number for room quantity.";
                return;
            }

            //6. Verify Quantity of rooms isnt negative
            if (intQuantity < 0)
            {
                txtQuantity.Background = Brushes.LightPink;
                txbWarning.Text.Text = "*Please enter a non-negative quantity";
                return;
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainScreen MainMenu = new MainScreen();
            MainMenu.Show();
        }


        private void btnViewRoom_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files | *.json";

            if (openFileDialog.ShowDialog() == true)
            {
                string strFilePath = openFileDialog.FileName;

                try
                {
                    StreamReader reader = new StreamReader(strFilePath);
                    string jsonData = reader.ReadToEnd();
                    reader.Close();

                    roomList = JsonConvert.DeserializeObject<List<Room>>(jsonData);

                    dtgRoomMgmt.ItemsSource = roomList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in import process: " + ex.Message);
                }

                dtgRoomMgmt.Items.Refresh();
            }
        }


    }
}
