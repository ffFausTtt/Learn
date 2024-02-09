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
    /// Логика взаимодействия для PageUser.xaml
    /// </summary>
    public partial class PageUser : Page
    {
        Services services = new Services();
        List<Service> servicesList;
        public PageUser()
        {
            InitializeComponent();
            InitializeComponent();
            DataContext = services;
            AllServices.ItemsSource = services.usr.ToList();
            AllServices.Items.Refresh();
            servicesList = services.usr.ToList();
            CountList.Text = Convert.ToString(services.usr.Count);
            CountBD.Text = Convert.ToString(services.usr.Count);
        }
        private void up_Click(object sender, RoutedEventArgs e)
        {
            RadioButton RB = (RadioButton)sender;
            switch (RB.Uid)
            {
                case "up":
                    servicesList = servicesList.OrderBy(x => x.Cost).ToList();
                    AllServices.ItemsSource = servicesList;
                    break;
                case "down":
                    servicesList = servicesList.OrderBy(x => x.Cost).ToList();
                    servicesList.Reverse();
                    AllServices.ItemsSource = servicesList;
                    break;
            }
        }
        private void Filter(object sender, RoutedEventArgs e)
        {
            servicesList = services.usr.ToList();
            if (TxtFindServices.Text != "")
            {
                servicesList = servicesList.Where(x => x.Title.Contains(TxtFindServices.Text)).ToList();
            }
            if (up.IsChecked == true)
            {
                servicesList = servicesList.OrderBy(x => x.Cost).ToList();
                AllServices.ItemsSource = servicesList;
            }
            if (down.IsChecked == true)
            {
                servicesList = servicesList.OrderBy(x => x.Cost).ToList();
                servicesList.Reverse();
                AllServices.ItemsSource = servicesList;
            }

            switch (ListSkidok.SelectedIndex)
            {
                case 0:
                    servicesList = servicesList.Where(x => (x.Discount >= 0) && (x.Discount <= 4)).ToList();
                    break;
                case 1:
                    servicesList = servicesList.Where(x => (x.Discount > 4) && (x.Discount <= 14)).ToList();
                    break;
                case 2:
                    servicesList = servicesList.Where(x => (x.Discount > 14) && (x.Discount <= 29)).ToList();
                    break;
                case 3:
                    servicesList = servicesList.Where(x => (x.Discount > 29) && (x.Discount <= 69)).ToList();
                    break;
                case 4:
                    servicesList = servicesList.Where(x => (x.Discount > 69) && (x.Discount <= 99)).ToList();
                    break;

                default:
                    servicesList = servicesList.Where(x => (x.Discount >= 0) && (x.Discount <= 100)).ToList();
                    break;
            }
            AllServices.ItemsSource = servicesList;
            CountList.Text = Convert.ToString(servicesList.Count);
        }
    }
}
