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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void givenNumber1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void givenNumber2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void choosePlus_Checked(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(givenNumber1.Text) + Int32.Parse(givenNumber2.Text);
            answer = output.ToString();
        }

        private void chooseMinus_Checked(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(givenNumber1.Text) - Int32.Parse(givenNumber2.Text);
            answer = output.ToString();
        }

        private void chooseMulti_Checked(object sender, RoutedEventArgs e)
        {
            int output = Int32.Parse(givenNumber1.Text) * Int32.Parse(givenNumber2.Text);
            answer = output.ToString();
        }

        private void chooseDivide_Checked(object sender, RoutedEventArgs e)
        {
            float output = float.Parse(givenNumber1.Text) / float.Parse(givenNumber2.Text);
            answer = output.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ans.Content = answer.ToString();
        }
    }
}
