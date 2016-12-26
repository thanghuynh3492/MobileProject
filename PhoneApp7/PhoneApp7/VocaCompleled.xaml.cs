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
    public partial class VocaCompleled : PhoneApplicationPage
    {
        string Unit;
        public VocaCompleled()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IDictionary<string, string> para = NavigationContext.QueryString;
            if (para.ContainsKey("text")) Unit = para["text"];
            Uri urimedia = new Uri("/Resources/All/HTUnit.mp3", UriKind.RelativeOrAbsolute);
            Media.Source = urimedia;
            tbLesson.Text = "Lesson " + Unit + "- Bài tập 1";
        }
        
        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/IntroStudy.xaml" + "?text=" + Unit, UriKind.Relative));
        }
    }
}