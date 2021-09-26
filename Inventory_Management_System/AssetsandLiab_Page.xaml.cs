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
using Inventory_Management_System.Models;
using System.Data.Linq;
using System.Collections.ObjectModel;
using Inventory_Management_System.Helpers;


namespace Inventory_Management_System
{
    /// <summary>
    /// Interaction logic for AssetsandLiab_Page.xaml
    /// </summary>
    public partial class AssetsandLiab_Page : Page
    {
        public AssetsandLiab_Page()
        {
            InitializeComponent();
            FillDataGrid();
        }

        string ConString = ConfigurationManager.ConnectionStrings["Inventory_Management_System.Properties.Settings.InventoryManagementSystemConnectionString"].ConnectionString;
        private void FillDataGrid()
        {
            string CmdString = "SELECT * FROM Tbl_AssetsandLiabilities";
            DataTable dt = DatabaseFunctions.Select(CmdString, false);

            grdAssetsandLiab.ItemsSource = dt.DefaultView;

            
        }

        private void Btn_ALAdd_Click(object sender, RoutedEventArgs e)
        {
            

            AssetsandLiabilities assetsandLiability = new AssetsandLiabilities();
            assetsandLiability.Id = TxtProductIdAL.Text;
            assetsandLiability.Situation = TxtSituation.Text;
            assetsandLiability.Description = TxtDescript.Text;
            assetsandLiability.TransactionDate = DateTimeAL.Text;
            assetsandLiability.Quantity = TxtQuantityAL.Text;
            assetsandLiability.Price = TxtPrice.Text;
            assetsandLiability.Drawee = TxtDrawee.Text;


            try
            {
                string connectionString = "Data Source=DESKTOP-8EU3443\\SQLSERVER;Initial Catalog=InventoryManagementSystem;Integrated Security=True";

                string triggerbuycommandtext = "Enable TRIGGER trigger_buy on Tbl_AssetsandLiabilities begin declare @ProducId int declare @ProductQuantity int select @ProducId=ProductId,@ProductQuantity=ProductQuantity from Tbl_AssetsandLiabilities update Tbl_Products set ProductQuantity=ProductQuantity+@ProductQuantity where ProductId=@ProducId end";
                string triggersellcommandtext = "Enable TRIGGER trigger_sell on Tbl_AssetsandLiabilities begin declare @ProducId int declare @ProductQuantity int select @ProducId=ProductId,@ProductQuantity=ProductQuantity from Tbl_AssetsandLiabilities update Tbl_Products set ProductQuantity=ProductQuantity-@ProductQuantity where ProductId=@ProducId end";

                string commandtext = "create trigger trigger_buy on Tbl_AssetsandLiabilities after insert as begin declare @ProducId int declare @ProductQuantity int select @ProducId=ProductId,@ProductQuantity=ProductQuantity from inserted update Tbl_Products set ProductQuantity=ProductQuantity+@ProductQuantity where ProductId=@ProducId end";

                if(TxtSituation.Text == "Alım")
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmdtrigger = new SqlCommand(triggerbuycommandtext, conn))
                    {
                        conn.Open();
                        cmdtrigger.ExecuteNonQuery();
                        conn.Close();
                    }
                    NLogger.Logger.Debug("Purchased");
                }
                if(TxtSituation.Text == "Satım")
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmdtrigger = new SqlCommand(triggersellcommandtext, conn))
                    {
                        conn.Open();
                        cmdtrigger.ExecuteNonQuery();
                        conn.Close();
                    }
                    NLogger.Logger.Debug("Selled");
                }


            }
            catch (Exception error)
            {
                NLogger.Logger.Error(error, "Error occured: ");

                throw;
            }

            DatabaseFunctions.Insert(assetsandLiability.InsertCommand(), assetsandLiability.CreateSQLParameters(), false);          

            MessageBoxResult result = MessageBox.Show("AL added successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }


        }

        
        private void Btn_ProductEdit_Click(object sender, RoutedEventArgs e)
        {
            AssetsandLiabilities assetsandLiability = new AssetsandLiabilities();
            assetsandLiability.Id = TxtProductIdAL.Text;
            assetsandLiability.Situation = TxtSituation.Text;
            assetsandLiability.Description = TxtDescript.Text;
            assetsandLiability.TransactionDate = DateTimeAL.Text;
            assetsandLiability.Quantity = TxtQuantityAL.Text;
            assetsandLiability.Price = TxtPrice.Text;
            assetsandLiability.Drawee = TxtDrawee.Text;

            DatabaseFunctions.Update(assetsandLiability.UpdateCommand(), assetsandLiability.UpdateSQLParameters(), false);


            MessageBoxResult result = MessageBox.Show("Activity updated successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        private void grdAssetsandLiab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                foreach (DataGridCellInfo di in grdAssetsandLiab.SelectedCells)
                {
                    DataRowView dvr = (DataRowView)di.Item;

                    TxtProductIdAL.Text = dvr[0].ToString();
                    TxtSituation.Text = dvr[1].ToString();
                    TxtDescript.Text = dvr[2].ToString();
                    DateTimeAL.Text = dvr[3].ToString();
                    TxtQuantityAL.Text = dvr[4].ToString();
                    TxtPrice.Text = dvr[5].ToString();
                    TxtDrawee.Text = dvr[6].ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Btn_ProductDelete_Click(object sender, RoutedEventArgs e)
        {
            if (TxtProductIdAL.Text == "_")
            {
                MessageBox.Show("Please enter product ıd to delete", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            AssetsandLiabilities assetsandLiability = new AssetsandLiabilities();
            assetsandLiability.Id = TxtProductIdAL.Text;


            DatabaseFunctions.Delete(assetsandLiability.DeleteCommand(), assetsandLiability.DeleteSQLParameters(), false);

            MessageBoxResult result = MessageBox.Show("Product deleted successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                FillDataGrid();
            }
        }

        
    }
    }

