using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Helpers
{
    public static class DatabaseFunctions
    {
        private static string ConString = ConfigurationManager.ConnectionStrings["Inventory_Management_System.Properties.Settings.InventoryManagementSystemConnectionString"].ConnectionString;

        public static DataTable Select(string storedProcedureorCommandText, bool isStoredProcedure = true)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    if (!isStoredProcedure)
                    {
                        command.CommandType = CommandType.Text;
                    }
                    command.CommandText = storedProcedureorCommandText;
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static int Insert(string storedProcedureorCommandText, SqlParameter[] sqlCommands, bool isStoredProcedure = true)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        if (!isStoredProcedure)
                        {
                            command.CommandType = CommandType.Text;
                        }
                        command.CommandText = storedProcedureorCommandText;

                        command.Parameters.AddRange(sqlCommands);

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                return 1;
            }
            catch (Exception err)
            {

                return -1;
            }
           
        }

        public static void Update(string storedProcedureorCommandText, SqlParameter[] sqlCommands, bool isStoredProcedure = true)
        {
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    if (!isStoredProcedure)
                    {
                        command.CommandType = CommandType.Text;
                    }
                    command.CommandText = storedProcedureorCommandText;

                    command.Parameters.AddRange(sqlCommands);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        


        public static void Delete(string storedProcedureorCommandText, SqlParameter[] sqlCommands, bool isStoredProcedure = true)
        {
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    if (!isStoredProcedure)
                    {
                        command.CommandType = CommandType.Text;
                    }
                    command.CommandText = storedProcedureorCommandText;

                    command.Parameters.AddRange(sqlCommands);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


        public static IEnumerable<T> ExcuteObject<T>(string storedProcedureorCommandText, bool isStoredProcedure = true)
        {
            List<T> items = new List<T>();
            var dataTable = Select(storedProcedureorCommandText, isStoredProcedure); //this will use the DataTable Select function
            foreach (var row in dataTable.Rows)
            {
                T item = (T)Activator.CreateInstance(typeof(T), row);
                items.Add(item);
            }
            return items;
        }

        //public static IEnumerable<Product> ExcuteObjectProduct<Product>(string storedProcedureorCommandText, bool isStoredProcedure = true)
        //{
        //    List<Product> items = new List<Product>();
        //    var dataTable = Select(storedProcedureorCommandText, isStoredProcedure); //this will use the DataTable Select function
        //    foreach (var row in dataTable.Rows)
        //    {
        //        Product item = (Product)Activator.CreateInstance(typeof(Product), row);
        //        items.Add(item);
        //    }
        //    return items;
        //}


    }
}
