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

namespace RegularExpression
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

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(userName.Text, @"^([A-Za-z]+\s*)+$") && userName.Text.Length != 0)
            {
                MessageBox.Show("The name is invalid (only alphabetical charachters are allowed)");
            }
            if (!Regex.IsMatch(userPhone.Text, @"^[\d-]+$") && userPhone.Text.Length != 0)
            {
                MessageBox.Show("The phone number is invalid");
            }
            if(!Regex.IsMatch(userEmail.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") && userEmail.Text.Length != 0)
            {
                MessageBox.Show("The e-mail address is invalid");
            }
        }
    }
}
