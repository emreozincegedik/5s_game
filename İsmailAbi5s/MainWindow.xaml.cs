using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace İsmailAbi5s
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Border> borders;
        List<Border> bordersn;
        DateTime start;
        bool canPick = true;
        List<Label> scores;
        int level = 0;
        int score = 1;
        public MainWindow()
        {
            InitializeComponent();
            borders = new List<Border>() {
                number_1,number_2,number_3,number_4,number_5,number_6,number_7,number_8,number_9,number_10,
                number_11,number_12,number_13,number_14,number_15,number_16,number_17,number_18,number_19,number_20,
                number_21,number_22,number_23,number_24,number_25,number_26,number_27,number_28,number_29,number_30,
                number_31,number_32,number_33,number_34,number_35,number_36,number_37,number_38,number_39,number_40,
                number_41,number_42,number_43,number_44,number_45,number_46,number_47,number_48,number_49
            };
            bordersn = new List<Border>() {
                number_1n,number_2n,number_3n,number_4n,number_5n,number_6n,number_7n,number_8n,number_9n,number_10n,
                number_11n,number_12n,number_13n,number_14n,number_15n,number_16n,number_17n,number_18n,number_19n,number_20n,
                number_21n,number_22n,number_23n,number_24n,number_25n,number_26n,number_27n,number_28n,number_29n,number_30n,
                number_31n,number_32n,number_33n,number_34n,number_35n,number_36n,number_37n,number_38n,number_39n,number_40n,
                number_41n,number_42n,number_43n,number_44n,number_45n,number_46n,number_47n,number_48n,number_49n
            };
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,100);


            scores = new List<Label>
            {
                score1,
                score2,
                score3,
                score4               
            };

            score_label.Visibility = Visibility.Hidden;
            score1.Visibility = Visibility.Hidden;
            score2.Visibility = Visibility.Hidden;
            score3.Visibility = Visibility.Hidden;
            score4.Visibility = Visibility.Hidden;
            score5.Visibility = Visibility.Hidden;
            line1.Visibility = Visibility.Hidden;
            line2.Visibility = Visibility.Hidden;
            line3.Visibility = Visibility.Hidden;
            line4.Visibility = Visibility.Hidden;
        }


        private void Button_Click(object sender, MouseButtonEventArgs e)
        {
            if (!canPick)
            {
                return;
            }
            Label a = (Label)sender;

            if ((int.Parse(a.Content.ToString()))==(int.Parse(number_next.Content.ToString())))
            {
                borders[int.Parse(a.Content.ToString())-1].Visibility = Visibility.Visible;
                bordersn[int.Parse(a.Content.ToString()) - 1].Visibility = Visibility.Visible;
                number_next.Content = (int.Parse(a.Content.ToString())+1).ToString();
                score = int.Parse(a.Content.ToString());

                if (a.Content.ToString() == "49")
                {
                    timer.Content = "Hepsini bitirdiniz!";
                    dispatcherTimer.Stop();
                    canPick = false;

                    next_page.IsEnabled = true;
                    number_next.Content = "Hepsini bitirdiniz!";
                    score = int.Parse(a.Content.ToString());
                }
            }

        }
        int a = 3;
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            int timeleft = a - (DateTime.Now - start).Seconds;
            if (timeleft<0)
            {
                timer.Content = "Süreniz doldu";
                dispatcherTimer.Stop();
                canPick = false;
                
                next_page.IsEnabled = true;
                if (level==0)
                {
                    // işlemler
                }
                else if (level == 1)
                {
                    // işlemler
                }
                else if(level == 2)
                {
                    // işlemler
                }
                
                return;
                //sayfa değiştir
            }
            timer.Content = timeleft;

        }
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            tab2.Focus();
            start = DateTime.Now;
            dispatcherTimer.Start();
        }

        private void next_page_Click(object sender, RoutedEventArgs e)
        {
            foreach (Border border in borders)
            {
                border.Visibility = Visibility.Hidden;
            }
            foreach (Border border in bordersn)
            {
                border.Visibility = Visibility.Hidden;
            }
            
            canPick = true;
            score_label.Visibility = Visibility.Visible;
            scores[level].Visibility = Visibility.Visible;
            //scores[level].Content = (int.Parse(number_next.Content.ToString())) - 1;
            scores[level].Content = score;
            level++;
            number_next.Content = 1;
            if (level==1)
            {
                tab3.Focus();
            }
            else if (level == 2)
            {
                tab4.Focus();
            }
            else if (level == 3)
            {
                tab5.Focus();
                
            }
            else
            {
                MessageBox.Show("Yeni sayfa oluştur");
                return;
            }
            next_page.IsEnabled = false;



        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            tab2.Focus();
            if (level==2)
            {
                line1.Visibility = Visibility.Visible;
                line2.Visibility = Visibility.Visible;
                line3.Visibility = Visibility.Visible;
                line4.Visibility = Visibility.Visible;
            }
            if (level == 3)
            {
                tab6.Focus();
                a = 30;
            }
            image.Source = new BitmapImage(new Uri(@"/images/transparent 1-49.png", UriKind.Relative));
            
            start = DateTime.Now;
            dispatcherTimer.Start();
        }
    }
}
