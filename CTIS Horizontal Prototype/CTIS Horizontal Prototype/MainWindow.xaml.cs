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

namespace CTIS_Horizontal_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //0 = single ticket
        //1 = daily pass
        //2 = monthly pass
        int cardMode;

        public MainWindow()
        {
            InitializeComponent();
            Swipe_Card_Button.AddHandler(Button.MouseDownEvent, new RoutedEventHandler(Swipe_Card_Button_MouseDown), true);
            cardMode=0;
        }
        //top left button
        private void blank_metal_button_croppoed_jpg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //If its on the main screen selecting the button will take you to the choose payment screen
            if (MainGrid.Visibility == Visibility.Visible)
            {
                MainGrid.Visibility = Visibility.Collapsed;
                ChoosePaymentGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Collapsed;
                cardMode = 0;
            }
            //Selecting Credit
            else if (ChoosePaymentGrid.Visibility == Visibility.Visible)
            {
                ChoosePaymentGrid.Visibility = Visibility.Collapsed;
                DebsCredsGrid.Visibility = Visibility.Visible;
            }
            //Printing Ticket or tapping card
            else if (DebsCredsGrid.Visibility == Visibility.Visible)
            {
                DebsCredsGrid.Visibility = Visibility.Collapsed;
                Swipe_Card_Button.Visibility = Visibility.Visible;
                TapOrPrint.Visibility = Visibility.Visible;
            }
            //Go to bought ticket screen
            else if (TapOrPrint.Visibility == Visibility.Visible)
            {
                TapOrPrint.Visibility = Visibility.Collapsed;
                Swipe_Card_Button.Visibility = Visibility.Collapsed;
                BuyGrid.Visibility = Visibility.Visible;
            }
            //go to individual bus route screen
            else if (BussesGrid.Visibility == Visibility.Visible)
            {
                BussesGrid.Visibility = Visibility.Collapsed;
                BusRoutGrid.Visibility = Visibility.Visible;
            }


            if (SettingsGrid.Visibility == Visibility.Visible)
            {
                
                if (sender.Equals(blank_metal_button_croppoed_jpg) && Swipe_Card_Button.Visibility == Visibility.Collapsed)
                {
                    cardMode = 0;
                    buymessage.Content = "You have\npurchased a\nsingle ticket!";
                    SettingsGrid.Visibility = Visibility.Collapsed;
                    SettingsConfirmGrid.Visibility = Visibility.Visible;
                }
                else if (sender.Equals(blank_metal_button_croppoed_jpg_Copy) && Swipe_Card_Button.Visibility == Visibility.Collapsed)
                {
                    cardMode = 1;
                    buymessage.Content = "You have\npurchased a\nday pass!";
                    SettingsGrid.Visibility = Visibility.Collapsed;
                    SettingsConfirmGrid.Visibility = Visibility.Visible;
                }
                else if (sender.Equals(blank_metal_button_croppoed_jpg_Copy4) && Swipe_Card_Button.Visibility == Visibility.Collapsed)
                {
                    cardMode = 2;
                    buymessage.Content = "You have\npurchased a\nmonthly pass!";
                    SettingsGrid.Visibility = Visibility.Collapsed;
                    SettingsConfirmGrid.Visibility = Visibility.Visible;
                }
                else
                {
                    setlabel_Copy2.Visibility = Visibility.Visible;
                }
                
            }


        }
        //Cancel Button
        private void cancel_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //go back from choosing a ticket type in main
            if (ChoosePaymentGrid.Visibility == Visibility.Visible)
            {
                ChoosePaymentGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Visible;
            }
            //Go back from choosing credit
            else if (DebsCredsGrid.Visibility == Visibility.Visible)
            {
                DebsCredsGrid.Visibility = Visibility.Collapsed;
                ChoosePaymentGrid.Visibility = Visibility.Visible;
            }
            //Go back from settings
            else if (SettingsGrid.Visibility == Visibility.Visible)
            {
                SettingsGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Visible;
            }
            //Go back form confirmed settings
            else if (SettingsConfirmGrid.Visibility == Visibility.Visible)
            {
                SettingsConfirmGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Visible;
            }
            //Go back from paid ticket
            else if (BuyGrid.Visibility == Visibility.Visible)
            {
                BuyGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Visible;
            }
            //Go back from bus route map
            else if (BusRoutGrid.Visibility == Visibility.Visible)
            {
                BusRoutGrid.Visibility = Visibility.Collapsed;
                BussesGrid.Visibility = Visibility.Visible;
            }
            //Go back from bus selection screen
            else if (BussesGrid.Visibility == Visibility.Visible)
            {
                BussesGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Visible;
            }
            //go back from train map
            else if (MapGrid.Visibility == Visibility.Visible)
            {
                MapGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Visible;
            }
            

        }
        //Train Map
        private void blank_metal_button_croppoed_jpg_Copy12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MainGrid.Visibility == Visibility.Visible)
            {
                MainGrid.Visibility = Visibility.Collapsed;
                MapGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Collapsed;
            }
        }
        //Quickpay with card
        private void Swipe_Card_Button_MouseDown(object sender, RoutedEventArgs e)
        {
            if (Swipe_Card_Button.Visibility == Visibility.Visible && SettingsGrid.Visibility == Visibility.Visible)
            {
                Swipe_Card_Button.Visibility = Visibility.Collapsed;
                setlabel_Copy2.Visibility = Visibility.Collapsed;
                setlabel_Copy3.Visibility = Visibility.Visible;
            }
            
            else
            {
                MainGrid.Visibility = Visibility.Collapsed;
                SettingsGrid.Visibility = Visibility.Collapsed;
                MapGrid.Visibility = Visibility.Collapsed;
                CoinGrid.Visibility = Visibility.Collapsed;
                SettingsConfirmGrid.Visibility = Visibility.Collapsed;
                BuyGrid.Visibility = Visibility.Visible;
                TapOrPrint.Visibility = Visibility.Collapsed;
                Swipe_Card_Button.Visibility = Visibility.Collapsed;
            }
            
        }

        //Pull up settings
        private void blank_metal_button_croppoed_jpg_Copy11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MainGrid.Visibility == Visibility.Visible)
            {
                MainGrid.Visibility = Visibility.Collapsed;
                SettingsGrid.Visibility = Visibility.Visible;
            }
            else if (ChoosePaymentGrid.Visibility == Visibility.Visible)
            {
                ChoosePaymentGrid.Visibility = Visibility.Collapsed;
                DebsCredsGrid.Visibility = Visibility.Visible;
            }
        }
        //Bus 
        private void blank_metal_button_croppoed_jpg_Copy16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MainGrid.Visibility == Visibility.Visible)
            {
                MainGrid.Visibility = Visibility.Collapsed;
                BussesGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Collapsed;
            }
            else if(ChoosePaymentGrid.Visibility == Visibility.Visible)
            {
                ChoosePaymentGrid.Visibility = Visibility.Collapsed;
                CoinGrid.Visibility = Visibility.Visible;
                Swipe_Card_Button.Visibility = Visibility.Collapsed;
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CoinGrid.Visibility == Visibility.Visible)
            {
                CoinGrid.Visibility = Visibility.Collapsed;
                BuyGrid.Visibility = Visibility.Visible;
            }
        }

        private void label3_Copy4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (DebsCredsGrid.Visibility == Visibility.Visible)
            {
                DebsCredsGrid.Visibility = Visibility.Collapsed;
                BuyGrid.Visibility = Visibility.Visible;
            }
        }
    }
}
