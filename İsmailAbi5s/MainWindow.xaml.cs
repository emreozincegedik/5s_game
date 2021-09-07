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
        DateTime start;
        bool canPick = true;
        List<Label> scores;
        int level = 0;
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
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,100);


            scores = new List<Label>
            {
                score1,
                score2,
                score3
            };

            score_label.Visibility = Visibility.Hidden;
            score1.Visibility = Visibility.Hidden;
            score2.Visibility = Visibility.Hidden;
            score3.Visibility = Visibility.Hidden;
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
                number_next.Content = (int.Parse(a.Content.ToString())+1).ToString();
            }
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            int timeleft = 30 - (DateTime.Now - start).Seconds;
            if (timeleft<=0)
            {
                dispatcherTimer.Stop();
                canPick = false;
                score_label.Visibility = Visibility.Visible;
                scores[level].Visibility = Visibility.Visible;
                scores[level].Content = (int.Parse(number_next.Content.ToString())) - 1;
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
                level++;
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
    }
}
