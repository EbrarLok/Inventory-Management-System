# Inventory-Management-System
Bu program bir işletmenin envanter yönetimi yapmasına olanak sağlayan bir projedir.
## Getting Started
Ürün ekleme, güncelleme, silmenin yanı sıra sipariş takibi, alım satım işlemlerinin takibi gibi işlemleri gerçekleştiren söz konusu program nesne tabanlı programlama mantığı göz önünde bulundurularak gerçekleştirilmiştir.Örneğin farklı sayfalarda kullanılacak select, insert, update, delete gibi database işlemleri aşağıda bir kısmı görüldüğü gibi belli bir sınıf içerisinde tanımlanarak gereksiz kod yazımından kaçınılmış ve okunabilirliği artırmıştır.
```c#
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
```
