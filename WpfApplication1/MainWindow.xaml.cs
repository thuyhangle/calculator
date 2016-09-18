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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string answer = "";
        string notiContent = "";
        int number1;
        int number2;


        public MainWindow()
        {
            InitializeComponent();

            
        }
  
        private void givenNumber1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                number1 = int.Parse(givenNumber1.Text);
            }
            catch (FormatException exception)
            {
                answer = "N/A!";
                notiContent = "Wrong format :( Please type again :)";
                noti.Content = notiContent.ToString();
            }
        }

        private void givenNumber2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                number2 = int.Parse(givenNumber2.Text);
            }
            catch (FormatException exception)
            {
                answer = "N/A!";
                notiContent = "Wrong format :( Please type again :)";
                noti.Content = notiContent.ToString();
            }
        }
        private void choosePlus_Checked(object sender, RoutedEventArgs e)
        {
            int output = number1 + number2;
            answer = output.ToString();
        }

        private void chooseMinus_Checked(object sender, RoutedEventArgs e)
        {
            int output = number1 - number2;
            answer = output.ToString();
        }

        private void chooseMulti_Checked(object sender, RoutedEventArgs e)
        {
            int output = number1 * number2;
            answer = output.ToString();
        }

        private void chooseDivide_Checked(object sender, RoutedEventArgs e)
        {
            if ( number2 == 0 )
            {
                notiContent = "You cannot divide by zero :( Please choose another number :)";
                noti.Content = notiContent.ToString();
            }
            else
            {
                float output = number1 / number2;
                answer = output.ToString();
            }   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ans.Content = answer.ToString();
        }
    }
}
