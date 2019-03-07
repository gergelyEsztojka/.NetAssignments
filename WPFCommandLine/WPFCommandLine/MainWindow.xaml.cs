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
using System.IO;

namespace WPFCommandLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String[] args = App.Args;

            try
            {
                using (StreamReader sr = new StreamReader(args[0]))
                {
                    String line = sr.ReadToEnd();
                    textBox.AppendText(line.ToString());
                    textBox.AppendText("\n");
                }
            }
            catch (Exception e)
            {
                textBox.AppendText("The file could not be read: ");
                textBox.AppendText("\n");
                textBox.AppendText(e.Message);
            }
        }
    }
}
