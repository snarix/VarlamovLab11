using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace VarlamovLab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AbbaAbea(object sender, RoutedEventArgs e)
        {
            string a = "aba aca aea abba adca abea";
            Regex regex = new Regex(@"ab[be]a");
            MatchCollection match = regex.Matches(a);
            for (int i = 0; i < match.Count; i++)
            {

                MessageBox.Show(match[i].ToString());
            }
        }

        private void FindStr(object sender, RoutedEventArgs e)
        {
            string a = letter.Text;
            Regex regex = new Regex(@"\ba[a-f j-z]a{1}\b");
            MatchCollection match = regex.Matches(a);
            for (int i = 0; i < match.Count; i++)
            {

                MessageBox.Show(match[i].ToString());
            }
        }

        private void AboutProgram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана строка 'aba aca aea abba adca abea'." +
                "\r\nНапишите регулярное выражение, которое найдет строки abba и abea, не захватив adca." +
                "\r\nНапишите регулярное выражение, которое найдет строки следующего вида: покраям стоят буквы 'a', а между ними - буква от a до f и от j до z.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
