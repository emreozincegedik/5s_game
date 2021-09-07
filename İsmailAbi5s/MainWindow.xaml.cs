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
        int score1 = 0;
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();


        
       


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // code goes here
        }
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
            
        }

        private void number_47_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            number_next.Content = 5;
        }

        private void number_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            number_next.Content = 5;
        }


        private void Button_Click(object sender, MouseButtonEventArgs e)
        {
            Label a = (Label)sender;
            if ((int.Parse(a.Content.ToString()))==(int.Parse(number_next.Content.ToString())))
            {
             borders[int.Parse(a.Content.ToString())-1].Visibility = Visibility.Visible;
            number_next.Content = (int.Parse(a.Content.ToString())+1).ToString();

            }
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            tab2.Focus();
        }
    }
}
