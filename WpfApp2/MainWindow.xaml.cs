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
using System;
using System.IO;
using System.Text.Json;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             string logs = log.Text;
            string pasw = pas.Text;
          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }



        private void TextBox_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            log.Text= "";
        }

        
    }
}
