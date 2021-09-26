using Inventory_Management_System.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace Inventory_Management_System
{
    /// <summary>
    /// Interaction logic for Login_Window.xaml
    /// </summary>
    public partial class Login_Window : Window
    {
        public Login_Window()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8EU3443\\SQLSERVER;Initial Catalog=InventoryManagementSystem;Integrated Security=True");

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Users WHERE UserName=@p1 and UserPassword=@p2",connection);
            cmd.Parameters.AddWithValue("@p1", TxtUserName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Password);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid name or password","Warning",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }
    }
}
