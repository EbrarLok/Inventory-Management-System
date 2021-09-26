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
    /// Interaction logic for Clients_Page.xaml
    /// </summary>
    public partial class Clients_Page : Page
    {
        public Clients_Page()
        {
            InitializeComponent();
            FillDataGrid();
        }
        string ConString = ConfigurationManager.ConnectionStrings["Inventory_Management_System.Properties.Settings.InventoryManagementSystemConnectionString"].ConnectionString;
        private void FillDataGrid()
        {

            string CmdString = "SELECT * FROM Tbl_Client";
            DataTable dt = DatabaseFunctions.Select(CmdString, false);

            grdClient.ItemsSource = dt.DefaultView;
        }

        private void Btn_ClientAdd_Click(object sender, RoutedEventArgs e)
        {

            Clients client = new Clients();
            client.Name = TxtClientName.Text;
            client.Phone = MskdClientPhone.Text;
            client.Mail = TxtClientMail.Text;
            client.Address = TxtClientAddress.Text;

            DatabaseFunctions.Insert(client.InsertCommand(), client.CreateSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Client added successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        private void grdClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                foreach (DataGridCellInfo di in grdClient.SelectedCells)
                {
                    DataRowView dvr = (DataRowView)di.Item;

                    TxtClientName.Text = dvr[0].ToString();
                    MskdClientPhone.Text = dvr[1].ToString();
                    TxtClientMail.Text = dvr[2].ToString();
                    TxtClientAddress.Text = dvr[3].ToString();
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        private void Btn_ClientEdit_Click(object sender, RoutedEventArgs e)
        {

            Clients client = new Clients();
            client.Name = TxtClientName.Text;
            client.Phone = MskdClientPhone.Text;
            client.Mail = TxtClientMail.Text;
            client.Address = TxtClientAddress.Text;

            DatabaseFunctions.Update(client.UpdateCommand(), client.UpdateSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Client edited successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        private void Btn_ClientDelete_Click(object sender, RoutedEventArgs e)
        {
            if (TxtClientName.Text == "")
            {
                MessageBox.Show("Please enter client name to delete", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            Clients client = new Clients();
            client.Name = TxtClientName.Text;


            DatabaseFunctions.Delete(client.DeleteCommand(), client.DeleteSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Client deleted successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }
    }
}
