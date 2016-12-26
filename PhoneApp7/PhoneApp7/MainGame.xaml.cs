using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp7
{
    public partial class MainGame : PhoneApplicationPage
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void btPicturegame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Topic.xaml", UriKind.Relative));
        }

        private void btbtWordGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WordGameHome.xaml", UriKind.Relative));
        }
    }
}