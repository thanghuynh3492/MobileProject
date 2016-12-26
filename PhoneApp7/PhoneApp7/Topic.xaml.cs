using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;

namespace PhoneApp7
{
    public partial class Topic : PhoneApplicationPage
    {
        ListBox lstMainPage = new ListBox();
        public Topic()
        {
            InitializeComponent();
        }
        public void GetDataMainPage()
        {
            ObservableCollection<DataMainPage> pages = new ObservableCollection<DataMainPage>();
            pages.Add(new DataMainPage(1, "Color", "/ImageSmartKid/color1.jpg"));
            pages.Add(new DataMainPage(2, "Clothing", "/ImageSmartKid/clothing.png"));
            pages.Add(new DataMainPage(3, "Vegetables", "/ImageSmartKid/vegetables.png"));
            pages.Add(new DataMainPage(4, "Fruits", "/ImageSmartKid/fruit.png"));
            pages.Add(new DataMainPage(5, "Alphabets", "/ImageSmartKid/alphabet.png"));
            pages.Add(new DataMainPage(6, "Number", "/ImageSmartKid/numbers.jpg"));
            pages.Add(new DataMainPage(7, "Animals", "/ImageSmartKid/animal.png"));
            pages.Add(new DataMainPage(8, "School Supplie", "/ImageSmartKid/school.png"));
            lstMainPage.ItemsSource = pages;
        }

        private void btclothes_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 2), UriKind.Relative));
        }

        private void btAlphabel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 5), UriKind.Relative));
        }

        private void btAnimal_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 7), UriKind.Relative));
        }

        private void btNumber_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 6), UriKind.Relative));
        }

        private void btschool_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 8), UriKind.Relative));
        }

        private void btColor_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 1), UriKind.Relative));
        }

        private void btFruit_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 4), UriKind.Relative));
        }

        private void btVegetable_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DataMainPage page = (DataMainPage)lstMainPage.SelectedItem;
            NavigationService.Navigate(new Uri(string.Format("/Details.xaml?id={0}", 3), UriKind.Relative));
        }
    }
}