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
    
    public partial class IntroStudy : PhoneApplicationPage
    {
        string Unit;
        public IntroStudy()
        {
            InitializeComponent();
            Uri urimedia = new Uri("/Resources/All/baitap.mp3", UriKind.RelativeOrAbsolute);
            Media.Source = urimedia;
            
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
            NavigationService.Navigate(new Uri("/Study1.xaml" + "?text=" + Unit, UriKind.Relative));
        }
    }
}