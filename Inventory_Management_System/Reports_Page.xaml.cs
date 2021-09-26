using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
using System.Data;
using System.Data.SqlClient;
using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;

namespace Inventory_Management_System
{
    /// <summary>
    /// Interaction logic for Reports_Page.xaml
    /// </summary>
    public partial class Reports_Page : Page
    {
        public Reports_Page()
        {
            InitializeComponent();


            string totalProducts = "SELECT * FROM Tbl_Products";
            string totalClients = "SELECT * FROM Tbl_Client";
            string totalOrders = "SELECT * FROM Tbl_Orders";


            var allProducts = DatabaseFunctions.Select(totalProducts, false);
            LblTotalProducts.Content = allProducts.Rows.Count;

            var allClients = DatabaseFunctions.Select(totalClients, false);
            LblTotalClients.Content = allClients.Rows.Count;

            var allOrders = DatabaseFunctions.Select(totalOrders, false);
            LblTotalOrders.Content = allOrders.Rows.Count;

            for (int i = 0; i < allProducts.Rows.Count; i++)
            {
                Product itemProduct = new Product(allProducts.Rows[i]);
                ProductSeriesCollection.Add(
                    new PieSeries
                    {
                        Title = $"Product {i + 1}",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(Convert.ToDouble(itemProduct.Quantity)) },
                        DataLabels = true
                    });
            }

            DataContext = this;
        }
        
        public SeriesCollection ProductSeriesCollection { get; set; } = new SeriesCollection();
        
    }
}
