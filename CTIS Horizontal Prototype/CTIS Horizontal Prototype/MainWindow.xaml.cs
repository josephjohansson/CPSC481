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

        private void blank_metal_button_croppoed_jpg_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (MainGrid.Visibility == Visibility.Visible)
            {
                MainGrid.Visibility = Visibility.Collapsed;
                CoinGrid.Visibility = Visibility.Visible;
            }

            if (SettingsGrid.Visibility == Visibility.Visible)
            {
                SettingsGrid.Visibility = Visibility.Collapsed;
                SettingsConfirmGrid.Visibility = Visibility.Visible;
                if (sender.Equals(blank_metal_button_croppoed_jpg))
                {
                    cardMode = 0;
                    buymessage.Content = "You have\npurchased a\nsingle ticket!";
                }
                else if (sender.Equals(blank_metal_button_croppoed_jpg_Copy))
                {
                    cardMode = 1;
                    buymessage.Content = "You have\npurchased a\nday pass!";
                }
                else if (sender.Equals(blank_metal_button_croppoed_jpg_Copy4))
                {
                    cardMode = 2;
                    buymessage.Content = "You have\npurchased a\nmonthly pass!";
                }
            }


        }

        private void cancel_button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!(MainGrid.Visibility == Visibility.Visible))
            {
                CoinGrid.Visibility = Visibility.Collapsed;
                BuyGrid.Visibility = Visibility.Collapsed;
                MapGrid.Visibility = Visibility.Collapsed;
                SettingsGrid.Visibility = Visibility.Collapsed;
                SettingsConfirmGrid.Visibility = Visibility.Collapsed;
                MainGrid.Visibility = Visibility.Visible;
            }
        }

        private void blank_metal_button_croppoed_jpg_Copy12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MainGrid.Visibility == Visibility.Visible)
            {
                MainGrid.Visibility = Visibility.Collapsed;
                MapGrid.Visibility = Visibility.Visible;
            }
        }

        private void Swipe_Card_Button_MouseDown(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Collapsed;
            SettingsGrid.Visibility = Visibility.Collapsed;
            MapGrid.Visibility = Visibility.Collapsed;
            CoinGrid.Visibility = Visibility.Collapsed;
            SettingsConfirmGrid.Visibility = Visibility.Collapsed;
            BuyGrid.Visibility = Visibility.Visible;
        }

        private void blank_metal_button_croppoed_jpg_Copy11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MainGrid.Visibility == Visibility.Visible)
            {
                MainGrid.Visibility = Visibility.Collapsed;
                SettingsGrid.Visibility = Visibility.Visible;
            }
        }
    }
}
