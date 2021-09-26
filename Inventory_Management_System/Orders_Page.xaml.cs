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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;

namespace Inventory_Management_System
{
    /// <summary>
    /// Interaction logic for Orders_Page.xaml
    /// </summary>
    public partial class Orders_Page : Page
    {
        public Orders_Page()
        {
            InitializeComponent();
            FillDataGrid();
        }
        string ConString = ConfigurationManager.ConnectionStrings["Inventory_Management_System.Properties.Settings.InventoryManagementSystemConnectionString"].ConnectionString;
        private void FillDataGrid()
        {

            string CmdString = "SELECT * FROM Tbl_Orders";
            DataTable dt = DatabaseFunctions.Select(CmdString, false);

            grdOrders.ItemsSource = dt.DefaultView;
        }

        private void Btn_OrderAdd_Click(object sender, RoutedEventArgs e)
        {

            Orders order = new Orders();
            order.Name = TxtOrderName.Text;
            order.Type = TxtOrderType.Text;
            order.CourierCompany = TxtCourierComp.Text;
            order.ParcelTrackingNumber = MskdTrackNumber.Text;
            order.TransactionDate = DpOrderDate.Text;
            order.ShipmentFee = TxtShipmentFee.Text;

            DatabaseFunctions.Insert(order.InsertCommand(), order.CreateSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Order added successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        private void grdOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                foreach (DataGridCellInfo di in grdOrders.SelectedCells)
                {
                    DataRowView dvr = (DataRowView)di.Item;

                    TxtOrderName.Text = dvr[0].ToString();
                    TxtOrderType.Text = dvr[1].ToString();
                    TxtCourierComp.Text = dvr[2].ToString();
                    MskdTrackNumber.Text = dvr[3].ToString();
                    DpOrderDate.Text = dvr[4].ToString();
                    TxtShipmentFee.Text = dvr[5].ToString();
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        private void Btn_OrderEdit_Click(object sender, RoutedEventArgs e)
        {

            Orders order = new Orders();
            order.Name = TxtOrderName.Text;
            order.Type = TxtOrderType.Text;
            order.CourierCompany = TxtCourierComp.Text;
            order.ParcelTrackingNumber = MskdTrackNumber.Text;
            order.TransactionDate = DpOrderDate.Text;
            order.ShipmentFee = TxtShipmentFee.Text;

            DatabaseFunctions.Update(order.UpdateCommand(), order.UpdateSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Order edited successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        private void Btn_OrderDelete_Click(object sender, RoutedEventArgs e)
        {
            if (TxtOrderName.Text == "_")
            {
                MessageBox.Show("Please enter order name to delete", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            Orders order = new Orders();
            order.Name = TxtOrderName.Text;


            DatabaseFunctions.Delete(order.DeleteCommand(), order.DeleteSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Order deleted successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }
    }
}
