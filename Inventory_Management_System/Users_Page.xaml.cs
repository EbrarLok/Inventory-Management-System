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
    /// Interaction logic for Users_Page.xaml
    /// </summary>
    public partial class Users_Page : Page
    {
        public Users_Page()
        {
            InitializeComponent();
            FillDataGrid();
        }
        string ConString = ConfigurationManager.ConnectionStrings["Inventory_Management_System.Properties.Settings.InventoryManagementSystemConnectionString"].ConnectionString;
        private void FillDataGrid()
        {

            string CmdString = "SELECT * FROM Tbl_Users";
            DataTable dt = DatabaseFunctions.Select(CmdString, false);

            grdUsers.ItemsSource = dt.DefaultView;
        }

        private void Btn_UserAdd_Click(object sender, RoutedEventArgs e)
        {

            Users user = new Users();
            user.Name = TxtUserName.Text;
            user.Password = TxtUserPassword.Text;

            DatabaseFunctions.Insert(user.InsertCommand(),user.CreateSQLParameters(),false);

            MessageBoxResult result = MessageBox.Show("User added successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        private void grdUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                foreach (DataGridCellInfo di in grdUsers.SelectedCells)
                {
                    DataRowView dvr = (DataRowView)di.Item;

                    TxtUserName.Text = dvr[0].ToString();
                    TxtUserPassword.Text = dvr[1].ToString();

                }
            }
            catch (Exception)
            {

               
            }
            
        }

        private void Btn_UserEdit_Click(object sender, RoutedEventArgs e)
        {

            Users user = new Users();
            user.Name = TxtUserName.Text;
            user.Password = TxtUserPassword.Text;

            DatabaseFunctions.Update(user.UpdateCommand(),user.UpdateSQLParameters(),false);

            MessageBoxResult result = MessageBox.Show("User edited successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        private void Btn_UserDelete_Click(object sender, RoutedEventArgs e)
        {
            if (TxtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name to delete", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            Users user = new Users();
            user.Name = TxtUserName.Text;

            DatabaseFunctions.Delete(user.DeleteCommand(),user.DeleteSQLParameters(),false);

            MessageBoxResult result = MessageBox.Show("User deleted successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }


        }
    }
}
