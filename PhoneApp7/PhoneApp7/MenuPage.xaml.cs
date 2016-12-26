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
    public partial class MenuPage : PhoneApplicationPage
    { 
        List<NewUnitItem> ListNewUnit = new List<NewUnitItem>();
        List<UnitItem> ListUnit = new List<UnitItem>();
        public MenuPage()
        {
            InitializeComponent();
            Uri urimedia = new Uri("/Resources/All/intro1.mp3", UriKind.RelativeOrAbsolute);
            Media.Source = urimedia;
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            EngDBContext c = new EngDBContext(EngDBContext.ConnectionString);
            c.CreateIfNotExists();
            var result = from p in c.EngUnit
                         where p.Lesson > 0
                         select p;
            foreach (EngUnit u in result)
            {
                NewUnitItem newitem = new NewUnitItem();
                newitem.Lesson = u.Lesson;
                newitem.Title = u.Title;
                newitem.Point = u.Point;
                newitem.Completed = u.Completed;
                newitem.Image = u.Image;
                newitem.ImageNotC = u.ImageNotC;
                ListNewUnit.Add(newitem);
            }
            for (int x = 0; x < ListNewUnit.Count; x++ )
            {
                UnitItem a = new UnitItem();
                if(ListNewUnit[x].Completed==0)
                {
                    a.Lesson = ListNewUnit[x].Lesson;
                    a.Point = ListNewUnit[x].Point;
                    a.Image = ListNewUnit[x].ImageNotC;
                    a.Title = ListNewUnit[x].Title;
                    a.Completed = ListNewUnit[x].Completed;
                    a.ViewLesson = "Lesson " + ListNewUnit[x].Lesson.ToString();
                    a.ViewCompleted = "Chưa hoàn thành";
                }
                else
                {
                    a.Lesson = ListNewUnit[x].Lesson;
                    a.Point = ListNewUnit[x].Point;
                    a.Image = ListNewUnit[x].Image;
                    a.Title = ListNewUnit[x].Title;
                    a.Completed = ListNewUnit[x].Completed;
                    a.ViewLesson = "Lesson " + ListNewUnit[x].Lesson.ToString();
                    a.ViewCompleted = "Hoàn Thành";
                }
                ListUnit.Add(a);
            }
                lstUnit.ItemsSource = ListUnit;
         
        }

        private void lstUnit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectitem = lstUnit.SelectedItem as UnitItem;
            if (selectitem != null)
            {
                if (selectitem.Completed == 1)
                {
                    NavigationService.Navigate(new Uri("/Introduction.xaml" + "?text=" + selectitem.Lesson, UriKind.Relative));
                }
                
            }
        }

        //private void lstUnit_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        //{
        //    var selectitem = lstUnit.SelectedItems as UnitItem;
        //    if (selectitem != null)
        //    {
        //        NavigationService.Navigate(new Uri("/MainPage.xaml" + "?text=" + selectitem.Lesson, UriKind.Relative));
        //    }
        //}
        //private void Ellipse_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/MainPage.xaml" + "?text=1", UriKind.Relative));
        //}
    }
}