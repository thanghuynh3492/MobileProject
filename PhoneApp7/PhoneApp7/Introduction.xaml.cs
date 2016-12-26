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
    public partial class Introduction : PhoneApplicationPage
    {
        string Unit;
        public Introduction()
        {
            InitializeComponent();
            Uri urimedia = new Uri("/Resources/All/intro2.mp3", UriKind.RelativeOrAbsolute);
            Media.Source = urimedia;
            PlayNewFile(urimedia);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IDictionary<string, string> para = NavigationContext.QueryString;
            if (para.ContainsKey("text")) Unit = para["text"];
            tbLesson.Text = "Lesson " + Unit;
        }
        
        private void GridIntro2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Media.Stop();
            NavigationService.Navigate(new Uri("/MainPage.xaml" + "?text=" + Unit, UriKind.Relative));
        }
        public void PlayNewFile(Uri uriMedia)
        {
            if (null != uriMedia && null != Media)
            {
                Media.Stop();
                Media.Source = uriMedia;
                Media.Volume = 100;
                Media.IsMuted = false;

                Media.Play();
            }

        }
    }
}