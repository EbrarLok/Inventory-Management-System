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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Inventory_Management_System.Helpers;
using Inventory_Management_System.Models;

namespace Inventory_Management_System
{
    /// <summary>
    /// Interaction logic for Products_Page.xaml
    /// </summary>
    public partial class Products_Page : Page
    {
        public Products_Page()
        {
            InitializeComponent();
            FillDataGrid();
        }
        string ConString = ConfigurationManager.ConnectionStrings["Inventory_Management_System.Properties.Settings.InventoryManagementSystemConnectionString"].ConnectionString;
        private void FillDataGrid()
        {
            string CmdString = "SELECT * FROM Tbl_Products";
            DataTable dt = DatabaseFunctions.Select(CmdString, false);
            
            grdProduct.ItemsSource = dt.DefaultView;

            //List<Product> products = DatabaseFunctions.ExcuteObject<Product>(CmdString, false).ToList();
        }

        

        private void Btn_ProductAdd_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Id = MskdProductId.Text;
            newProduct.Name = TxtProductName.Text;
            newProduct.Quantity = MskdProductQuantity.Text;
            newProduct.Price = MskdProductPrice.Text;
            newProduct.Description = Txt_ProductDesc.Text;
            newProduct.Category = CmbProductCategory.Text;


            NLogger.Logger.Info("Urun eklendi");

            DatabaseFunctions.Insert(newProduct.InsertCommand(), newProduct.CreateSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Product added successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if(result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }



        private void grdProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                foreach (DataGridCellInfo di in grdProduct.SelectedCells)
                {
                    DataRowView dvr = (DataRowView)di.Item;

                    MskdProductId.Text = dvr[0].ToString();
                    TxtProductName.Text = dvr[1].ToString();
                    MskdProductQuantity.Text = dvr[2].ToString();
                    MskdProductPrice.Text = dvr[3].ToString();
                    Txt_ProductDesc.Text = dvr[4].ToString();
                    CmbProductCategory.Text = dvr[5].ToString();

                }
            }
            catch (Exception)
            {
                
            }

        }

        private void Btn_ProductEdit_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product();
            newProduct.Id = MskdProductId.Text;
            newProduct.Name = TxtProductName.Text;
            newProduct.Quantity = MskdProductQuantity.Text;
            newProduct.Price = MskdProductPrice.Text;
            newProduct.Description = Txt_ProductDesc.Text;
            newProduct.Category = CmbProductCategory.Text;

            DatabaseFunctions.Update(newProduct.UpdateCommand(), newProduct.UpdateSQLParameters(), false);

            NLogger.Logger.Info("Urun editlendi");

            MessageBoxResult result = MessageBox.Show("Product updated successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }
        
        private void Btn_ProductDelete_Click(object sender, RoutedEventArgs e)
        {
            if(MskdProductId.Text == "_")
            {
                MessageBox.Show("Please enter product ıd to delete", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            Product newProduct = new Product();
            newProduct.Id = MskdProductId.Text;

          
            DatabaseFunctions.Delete(newProduct.DeleteCommand(), newProduct.DeleteSQLParameters(), false);

            NLogger.Logger.Info("Urun silindi");



            MessageBoxResult result = MessageBox.Show("Product deleted successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }
    }
}
