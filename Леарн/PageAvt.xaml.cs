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

namespace Леарн
{
    /// <summary>
    /// Логика взаимодействия для PageAvt.xaml
    /// </summary>
    public partial class PageAvt : Page
    {
        public PageAvt()
        {
            InitializeComponent();
        }

        private void OnUser_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frameMain.Navigate(new PageUser());
        }

        private void OnAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (cod.Text == "0000")
            {
                FrameClass.frameMain.Navigate(new PageAdmin());
            }
            else
            {
                MessageBox.Show("Код не правильный!");
            }
        }

        private void AvtAdmin_Click(object sender, RoutedEventArgs e)
        {
            login.Visibility = Visibility.Visible;
        }
    }
}
