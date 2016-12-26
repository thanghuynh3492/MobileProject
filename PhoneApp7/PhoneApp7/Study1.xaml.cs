using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;

namespace PhoneApp7
{
    public partial class Study1 : PhoneApplicationPage
    {
        List<Study1Items> listNewItems = new List<Study1Items>();
        int i = 1;
        int indexTrue = 0;
        int indexQS;
        int Unit;
        public Study1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IDictionary<string, string> para = NavigationContext.QueryString;
            if (para.ContainsKey("text")) Unit = int.Parse(para["text"]);
            tbLesson.Text = "Lesson " + Unit;
            #region Nhạc Introduction
            Uri urimedia = new Uri("/Resources/All/baitap1.mp3", UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
            #endregion

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
                    Study1Items n = new Study1Items();
                    n.SoundEng = eng.SoundEng;
                    n.Answer1 = eng.Answer1;
                    n.Answer2 = eng.Answer2;
                    n.Answer3 = eng.Answer3;
                    n.Answer4 = eng.Answer4;
                    n.SoundAS1 = eng.SoundAS1;
                    n.SoundAS2 = eng.SoundAS2;
                    n.SoundAS3 = eng.SoundAS3;
                    n.SoundAS4 = eng.SoundAS4;
                    n.AS = eng.AS;
                    listNewItems.Add(n);
                }
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
                        Study1Items n = new Study1Items();
                        n.SoundEng = eng.SoundEng;
                        n.Answer1 = eng.Answer1;
                        n.Answer2 = eng.Answer2;
                        n.Answer3 = eng.Answer3;
                        n.Answer4 = eng.Answer4;
                        n.SoundAS1 = eng.SoundAS1;
                        n.SoundAS2 = eng.SoundAS2;
                        n.SoundAS3 = eng.SoundAS3;
                        n.SoundAS4 = eng.SoundAS4;
                        n.AS = eng.AS;
                        listNewItems.Add(n);
                    }
                }
                shuffle(listNewItems);
                indexQS = listNewItems.Count();
            }
            #endregion
        }

        private void GrIntroBT_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[0].SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
            RB1.Content = listNewItems[0].Answer1;
            RB2.Content = listNewItems[0].Answer2;
            RB3.Content = listNewItems[0].Answer3;
            RB4.Content = listNewItems[0].Answer4;
            GrIntroBT.Visibility = Visibility.Collapsed;

            string a = "Câu số : " + i + "/" + indexQS;
            string b = "Câu đúng : " + indexTrue + "/" + indexQS;
            tbCauDung.Text = b;
            tbCauhoi.Text = a;
        }
        // Nhấp vào loa để phát lại âm thanh
        private void ElsMedia_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[i - 1].SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
            MediaStudy1.Play();
        }

        // kiểm tra kết quả
        private async void Btn_Kq_Click(object sender, RoutedEventArgs e)
        {
            Btn_Kq.IsEnabled = false;

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
                                MediaStudy1.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy1.Source = urimedia;
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
                                MediaStudy1.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy1.Source = urimedia;
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
                                MediaStudy1.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy1.Source = urimedia;
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
                                MediaStudy1.Source = urimedia;
                                await Task.Delay(2500);
                                GridTrue.Visibility = Visibility.Collapsed;
                            }
                            else
                            {
                                GridFalse.Visibility = Visibility.Visible;
                                Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
                                MediaStudy1.Source = urimedia;
                                await Task.Delay(2500);
                                GridFalse.Visibility = Visibility.Collapsed;

                            }
                            break;
                        }

                }
                NavigationService.Navigate(new Uri("/ResultEx.xaml" + "?text=" + indexTrue.ToString() + "&text1=" + indexQS.ToString() + "&study1=1" + "&unit=" + Unit, UriKind.Relative));

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
                                RB4.IsChecked = false;
                                RB3.IsChecked = false;
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
                                RB4.IsChecked = false;
                                RB3.IsChecked = false;
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
                                RB4.IsChecked = false;
                                RB3.IsChecked = false;
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
                                RB4.IsChecked = false;
                                RB3.IsChecked = false;
                            }
                            break;
                        }
                }


                i++;

            }



        }
        /// <summary>
        /// Hiện thị kết quả đúng
        /// </summary>
        /// <param name="n"></param>
        private async void RequestTrue(Study1Items n)
        {
            indexTrue++;
            GridTrue.Visibility = Visibility.Visible;
            Uri urimedia = new Uri("/Resources/All/Exactly.mp3", UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
            await Task.Delay(2500);
            GridTrue.Visibility = Visibility.Collapsed;
            RB1.Content = n.Answer1;
            RB2.Content = n.Answer2;
            RB3.Content = n.Answer3;
            RB4.Content = n.Answer4;
            urimedia = new Uri(n.SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
            string a = "Câu số : " + i + "/" + indexQS;
            tbCauhoi.Text = a;
            string b = "Câu đúng : " + indexTrue;
            tbCauDung.Text = b;
            Btn_Kq.IsEnabled = true;

        }
        /// <summary>
        /// Hiển thị kết quả sai
        /// </summary>
        /// <param name="n"></param>
        private async void RequestFalse(Study1Items n)
        {
            GridFalse.Visibility = Visibility.Visible;
            Uri urimedia = new Uri("/Resources/All/sorry.mp3", UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
            await Task.Delay(2500);
            GridFalse.Visibility = Visibility.Collapsed;
            RB1.Content = n.Answer1;
            RB2.Content = n.Answer2;
            RB3.Content = n.Answer3;
            RB4.Content = n.Answer4;
            urimedia = new Uri(n.SoundEng, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
            string a = "Câu số : " + i + "/" + indexQS;
            tbCauhoi.Text = a;
            string b = "Câu đúng : " + indexTrue;
            tbCauDung.Text = b;
            Btn_Kq.IsEnabled = true;
        }
        /// <summary>
        /// Đảo câu hỏi
        /// </summary>
        /// <param name="a"></param>
        private void shuffle(List<Study1Items> a)
        {
            Random rd = new Random();
            int n = a.Count;
            while (n > 1)
            {
                n--;
                int k = rd.Next(n + 1);
                Study1Items st = new Study1Items();
                st = a[k];
                a[k] = a[n];
                a[n] = st;
            }
        }

        #region Phát âm đáp án
        private void imgsp1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[i - 1].SoundAS1, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
        }

        private void imgsp2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[i - 1].SoundAS2, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
        }

        private void imgsp3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[i - 1].SoundAS3, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
        }

        private void imgsp4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Uri urimedia = new Uri(listNewItems[i - 1].SoundAS4, UriKind.RelativeOrAbsolute);
            MediaStudy1.Source = urimedia;
        }

        #endregion
    }
}