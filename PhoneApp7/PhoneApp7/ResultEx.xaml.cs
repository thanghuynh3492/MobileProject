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
    public partial class ResultEx : PhoneApplicationPage
    {
        int IndexTrue;
        int IndexQS;
        int Unit;
        int Study;
        public ResultEx()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // lấy các biến từ page trước
            IDictionary<string,string> para = NavigationContext.QueryString;
            if(para.ContainsKey("text")) IndexTrue = int.Parse(para["text"]);
            if (para.ContainsKey("text1")) IndexQS = int.Parse(para["text1"]);
            if (para.ContainsKey("study1")) Study = int.Parse(para["study1"]);
            if (para.ContainsKey("unit")) Unit = int.Parse(para["unit"]);
           
            #region Load kết quả bài tập
            int point = IndexTrue * 10 / IndexQS;
            if(point>=8)
            {
                txtCP.Text = "Chúc mừng em ! ";
                Imagecp.Visibility = Visibility.Visible;
                GridBT.Visibility = Visibility.Visible;
                tbLesson.Text = "Bài tập " + (Study+1);
                tbDiem.Text = "Số Điểm : " + point +"điểm";
                tbDiem.Visibility = Visibility.Visible;
                switch(Study)
                {
                    case 1:
                        {
                            Uri urimedia = new Uri("/Resources/All/HTBT1.mp3", UriKind.RelativeOrAbsolute);
                            media.Source = urimedia;
                            break;
                        }
                    case 2:
                        {
                            Uri urimedia = new Uri("/Resources/All/HTBT2.mp3", UriKind.RelativeOrAbsolute);
                                media.Source = urimedia;
                            break;
                        }
                    case 3:
                        {
                            Uri urimedia = new Uri("/Resources/All/HTBT3.mp3", UriKind.RelativeOrAbsolute);
                            media.Source = urimedia;
                            tbLesson.Text = "Trang chủ";
                            SaveCompleted();
                            break;
                        }
                }
                
            }
            else
            {
                txtCP.Text = "Rất tiếc ";
                tbDiem.Text = "Điểm " + point;
               
                Imagefalse.Visibility = Visibility.Visible;
                btnrepeat.Visibility = Visibility.Visible;
                switch(Study)
                {
                    case 1:
                        {
                            Uri urimedia = new Uri("/Resources/All/KHTBT1.mp3", UriKind.RelativeOrAbsolute);
                            media.Source = urimedia;
                            break;
                        }
                    case 2:
                        {
                            Uri urimedia = new Uri("/Resources/All/KHTBT2.mp3", UriKind.RelativeOrAbsolute);
                                media.Source = urimedia;
                            break;
                        }
                    case 3:
                        {
                            Uri urimedia = new Uri("/Resources/All/KHTBT3.mp3", UriKind.RelativeOrAbsolute);
                            media.Source = urimedia;
                            break;
                        }
                }
            }
        #endregion
        }

        private void btnrepeat_Click(object sender, RoutedEventArgs e)
        {
             switch(Study)
                {
                    case 1:
                        {
                             NavigationService.Navigate(new Uri("/Study1.xaml" + "?text=" + Unit, UriKind.Relative));
                            break;
                        }
                    case 2:
                        {
                            NavigationService.Navigate(new Uri("/Study2.xaml" + "?text=" + Unit, UriKind.Relative));
                            break;
                        }
                    case 3:
                        {
                            NavigationService.Navigate(new Uri("/Study3.xaml" + "?text=" + Unit, UriKind.Relative));
                            break;
                        }
                }
           
        }

       
        /// <summary>
        /// Nếu hoàn thành lưu vào database
        /// </summary>
        private void SaveCompleted()
        {
            EngDBContext c = new EngDBContext(EngDBContext.ConnectionString);
            c.CreateIfNotExists();
            var result = (from p in c.EngUnit
                         where p.Lesson == (Unit+1)
                         select p).SingleOrDefault();
            result.Completed = 1;
            c.SubmitChanges();
        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            switch (Study)
            {
                case 1:
                    {
                        NavigationService.Navigate(new Uri("/Study2.xaml" + "?text=" + Unit, UriKind.Relative));
                        break;
                    }
                case 2:
                    {
                        NavigationService.Navigate(new Uri("/Study3.xaml" + "?text=" + Unit, UriKind.Relative));
                        break;
                    }
                case 3:
                    {
                        NavigationService.Navigate(new Uri("/FirstPage.xaml", UriKind.Relative));
                        break;
                    }
            }
        }

    }
}