using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
namespace PhoneApp7
{
    public partial class FirstPage : PhoneApplicationPage
    {
        public FirstPage()
        {
            InitializeComponent();
            Uri urimedia = new Uri("/Resources/All/ABC.mp3", UriKind.RelativeOrAbsolute);
            media.Source = urimedia;
            

        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MenuPage.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainGame.xaml", UriKind.RelativeOrAbsolute));
            //media.Source = urimedia;
        }
    }
}