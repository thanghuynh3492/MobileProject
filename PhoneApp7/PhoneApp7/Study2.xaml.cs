using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;

namespace PhoneApp7
{
    public partial class Study2 : PhoneApplicationPage
    {
        List<Study2Items> listNewItems = new List<Study2Items>();
        int i = 1;
        int indexTrue = 0;
        int indexQS;
        int Unit;
        public Study2()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IDictionary<string, string> para = NavigationContext.QueryString;
            if (para.ContainsKey("text")) Unit = int.Parse(para["text"]);
            tbLesson.Text = "Lesson " + Unit;
            Uri urimedia = new Uri("/Resources/All/bt2.mp3", UriKind.RelativeOrAbsolute);
            MediaStudy2.Source = urimedia;

            #region Load câu hỏi
            if (Unit == 1)
            {
                EngDBContext c = new EngDBContext(EngDBContext.ConnectionString);
                c.CreateIfNotExists();
                var result = from p in c.EngLish
                             where p.Unit == Unit
                             select p;
                foreach (EngLish eng in result)
                {
                    Study2Items n = new Study2Items();
                    n.SoundEng = eng.SoundEng;
                    n.ASImage1 = eng.ASImage1;
                    n.ASImage2 = eng.ASImage2;
                    n.ASImage3 = eng.ASImage3;
                    n.ASImage4 = eng.ASImage4;
                    n.AS = eng.AS;
                    listNewItems.Add(n);
                }
                shuffle(listNewItems);
                indexQS = listNewItems.Count();
            }
            else
            {
                for (int index = Unit - 1; index <= Unit; index++)
                {
                    EngDBContext c = new EngDBContext(EngDBContext.ConnectionString);
                    c.CreateIfNotExists();
                    var result = from p in c.EngLish
                                 where p.Unit == index
                                 select p;
                    foreach (EngLish eng in result)
                    {
                        Study2Items n = new Study2Items();
                        n.SoundEng = eng.SoundEng;
                        n.ASImage1 = eng.ASImage1;
                        n.ASImage2 = eng.ASImage2;
                        n.ASImage3 = eng.ASImage3;
                        n.ASImage4 = eng.ASImage4;
                        n.AS = eng.AS;
                        listNewItems.Add(n);
                    }
                }
                shuffle(listNewItems);
                indexQS = listNewItems.Count();
            }
            #endregion
        }
        private void GridIntro_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[0].SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy2.Source = urimedia;
            BitmapImage image = new BitmapImage(new Uri(listNewItems[0].ASImage1, UriKind.Relative));
            IM1.Source = image;
            image = new BitmapImage(new Uri(listNewItems[0].ASImage2, UriKind.Relative));
            IM2.Source = image;
            image = new BitmapImage(new Uri(listNewItems[0].ASImage3, UriKind.Relative));
            IM3.Source = image;
            image = new BitmapImage(new Uri(listNewItems[0].ASImage4, UriKind.Relative));
            IM4.Source = image;

            GridIntro.Visibility = Visibility.Collapsed;
        }

        private void Els_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[i - 1].SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy2.Source = urimedia;
            MediaStudy2.Play();
        }

        private async void RequestTrue(Study2Items n)
        {
            indexTrue++;
            GridTrue.Visibility = Visibility.Visible;
            Uri urimedia = new Uri("/Resources/All/Exactly.mp3", UriKind.RelativeOrAbsolute);
            MediaStudy2.Source = urimedia;
            await Task.Delay(2500);
            GridTrue.Visibility = Visibility.Collapsed;
            btnKQ.IsEnabled = true;
            BitmapImage image = new BitmapImage(new Uri(n.ASImage1, UriKind.Relative));
            IM1.Source = image;
            image = new BitmapImage(new Uri(n.ASImage2, UriKind.Relative));
            IM2.Source = image;
            image = new BitmapImage(new Uri(n.ASImage3, UriKind.Relative));
            IM3.Source = image;
            image = new BitmapImage(new Uri(n.ASImage4, UriKind.Relative));
            IM4.Source = image;
            urimedia = new Uri(n.SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy2.Source = urimedia;
            string a = "Câu số : " + i + "/" + indexQS;
            tbCauhoi.Text = a;
            string b = "Câu đúng : " + indexTrue;
            tbCauDung.Text = b;

        }
        private async void RequestFalse(Study2Items n)
        {
            GridFalse.Visibility = Visibility.Visible;
            Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
            MediaStudy2.Source = urimedia;
            await Task.Delay(2500);
            GridFalse.Visibility = Visibility.Collapsed;
            btnKQ.IsEnabled = true;
            BitmapImage image = new BitmapImage(new Uri(n.ASImage1, UriKind.Relative));
            IM1.Source = image;
            image = new BitmapImage(new Uri(n.ASImage2, UriKind.Relative));
            IM2.Source = image;
            image = new BitmapImage(new Uri(n.ASImage3, UriKind.Relative));
            IM3.Source = image;
            image = new BitmapImage(new Uri(n.ASImage4, UriKind.Relative));
            IM4.Source = image;
            urimedia = new Uri(n.SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy2.Source = urimedia;

            string a = "Câu số : " + i + "/" + indexQS;
            tbCauhoi.Text = a;
            string b = "Câu đúng : " + indexTrue;
            tbCauDung.Text = b;
        }
        /// <summary>
        /// Đảo cau hỏi
        /// </summary>
        /// <param name="a"></param>
        private void shuffle(List<Study2Items> a)
        {
            Random rd = new Random();
            int n = a.Count;
            while (n > 1)
            {
                n--;
                int k = rd.Next(n + 1);
                Study2Items st = new Study2Items();
                st = a[k];
                a[k] = a[n];
                a[n] = st;
            }
        }
        private async void btnKQ_Click(object sender, RoutedEventArgs e)
        {
            btnKQ.IsEnabled = false;

            #region Câu hỏi cuối cùng
            if (i == indexQS)
            {
                switch (listNewItems[indexQS - 1].AS)
                {
                    case 1:
                        {
                            if (RB1.IsChecked == true)
                            {
                                indexTrue++;
                                GridTrue.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/Exactly.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridFalse.Visibility = Visibility.Collapsed;

                            }
                            break;
                        }
                    case 2:
                        {
                            if (RB2.IsChecked == true)
                            {
                                indexTrue++;
                                GridTrue.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/Exactly.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridFalse.Visibility = Visibility.Collapsed;

                            }
                            break;
                        }
                    case 3:
                        {
                            if (RB3.IsChecked == true)
                            {
                                indexTrue++;
                                GridTrue.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/Exactly.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridFalse.Visibility = Visibility.Collapsed;

                            }
                            break;
                        }
                    case 4:
                        {
                            if (RB4.IsChecked == true)
                            {
                                indexTrue++;
                                GridTrue.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/Exactly.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy2.Source = urimedia;
                                await Task.Delay(2500);
                                GridFalse.Visibility = Visibility.Collapsed;

                            }
                            break;
                        }
                }
                NavigationService.Navigate(new Uri("/ResultEx.xaml" + "?text=" + indexTrue.ToString() + "&text1=" + indexQS.ToString() + "&study1=2" + "&unit=" + Unit, UriKind.Relative));

            }
            #endregion
            else
            {

                int Answer = listNewItems[i - 1].AS;

                switch (Answer)
                {
                    case 1:
                        {
                            if (RB1.IsChecked == true)
                            {
                                RequestTrue(listNewItems[i]);
                                RB1.IsChecked = false;
                            }
                            else
                            {
                                RequestFalse(listNewItems[i]);
                                RB1.IsChecked = false;
                                RB2.IsChecked = false;
                                RB3.IsChecked = false;
                                RB4.IsChecked = false;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (RB2.IsChecked == true)
                            {
                                RequestTrue(listNewItems[i]);
                                RB2.IsChecked = false;
                            }
                            else
                            {
                                RequestFalse(listNewItems[i]);
                                RB1.IsChecked = false;
                                RB2.IsChecked = false;
                                RB3.IsChecked = false;
                                RB4.IsChecked = false;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (RB3.IsChecked == true)
                            {
                                RequestTrue(listNewItems[i]);
                                RB3.IsChecked = false;
                            }
                            else
                            {
                                RequestFalse(listNewItems[i]);
                                RB1.IsChecked = false;
                                RB2.IsChecked = false;
                                RB3.IsChecked = false;
                                RB4.IsChecked = false;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (RB4.IsChecked == true)
                            {
                                RequestTrue(listNewItems[i]);
                                RB4.IsChecked = false;
                            }
                            else
                            {
                                RequestFalse(listNewItems[i]);
                                RB1.IsChecked = false;
                                RB2.IsChecked = false;
                                RB3.IsChecked = false;
                                RB4.IsChecked = false;
                            }
                            break;
                        }
                }


                i++;
            }
            
        }

       
        
    }
}