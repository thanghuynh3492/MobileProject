using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp7.Resources;

namespace PhoneApp7
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<NewItems> listNewItems = new List<NewItems>();
        string Unit;
        private int dem = 0;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            //FeedbackOverlay.VisibilityChanged += FeedbackOverlay_VisibilityChanged;
        }

        void FeedbackOverlay_VisibilityChanged(object sender, EventArgs e)
        {
            //ApplicationBar.IsVisible = (FeedbackOverlay.Visibility != Visibility.Visible);
            //throw new NotImplementedException();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IDictionary<string, string> para = NavigationContext.QueryString;
            if (para.ContainsKey("text")) Unit = para["text"];

            EngDBContext c = new EngDBContext(EngDBContext.ConnectionString);
            c.CreateIfNotExists();
            var result = from p in c.EngLish
                         where p.Unit == int.Parse(Unit)
                         select p;
            foreach (EngLish eng in result)
            {
                NewItems n = new NewItems();
                n.Image = eng.Image;
                n.SoundEng = eng.SoundEng;
                n.SoundVie = eng.SoundVie;
                n.TextEng = eng.TextEng;
                n.TextVie = eng.TextVie;

                listNewItems.Add(n);
            }
            PivotUnit.ItemsSource = listNewItems;


        }
        // Chạy file mp3
        public void PlayNewFile(Uri uriMedia)
        {
            if (null != uriMedia && null != MediaUnit)
            {
                MediaUnit.Stop();
                MediaUnit.Source = uriMedia;
                MediaUnit.Volume = 100;
                MediaUnit.IsMuted = false;

                MediaUnit.Play();
            }

        }

        private void PivotUnit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dem++;
            var newItem = PivotUnit.SelectedItem as NewItems;
            string a = newItem.SoundEng;
            if (newItem != null)
            {
                Uri urimedia = new Uri(a, UriKind.RelativeOrAbsolute);
                PlayNewFile(urimedia);
            }
            var x = PivotUnit.SelectedIndex;
            if (x == 5 && dem >= 5)
            {
                GridBT.Visibility = Visibility.Visible;
            }
        }
        // Nhấp vào Loa để phát âm tiếng việt
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var newItem = PivotUnit.SelectedItem as NewItems;

            if (newItem != null)
            {
                string a = newItem.SoundVie;
                Uri urimedia = new Uri(a, UriKind.RelativeOrAbsolute);
                PlayNewFile(urimedia);
            }
        }

        private void Image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var newItem = PivotUnit.SelectedItem as NewItems;

            if (newItem != null)
            {
                string a = newItem.SoundEng;
                Uri urimedia = new Uri(a, UriKind.RelativeOrAbsolute);
                PlayNewFile(urimedia);
            }
        }

        private void GridBT_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/VocaCompleled.xaml" + "?text=" + Unit, UriKind.Relative));
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}