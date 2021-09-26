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
using Xceed.Wpf.Toolkit;

namespace Inventory_Management_System
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

        private void Btn_Product_Click(object sender, RoutedEventArgs e)
        {
            Products_Page page = new Products_Page();
            this.Content = page;

        }

        private void Btn_Clients_Click(object sender, RoutedEventArgs e)
        {
            Clients_Page page = new Clients_Page();
            this.Content = page;
        }

        private void Btn_Orders_Click(object sender, RoutedEventArgs e)
        {
            Orders_Page page = new Orders_Page();
            this.Content = page;
        }

        private void Btn_Users_Click(object sender, RoutedEventArgs e)
        {
            Users_Page page = new Users_Page();
            this.Content = page;
        }

        private void Btn_AssetsandLiab_Click(object sender, RoutedEventArgs e)
        {
            AssetsandLiab_Page page = new AssetsandLiab_Page();
            this.Content = page;
        }

        private void Btn_Reports_Click(object sender, RoutedEventArgs e)
        {
            Reports_Page page = new Reports_Page();
            this.Content = page;
        }
    }
}
