using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class Product
    {
        public string Id
        {
            set;
            get;
        }

        public string Name
        {
            get;
            set;
        }

        public string Quantity
        {
            get;
            set;
        }

        public string Price
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public Product()
        {

        }

        public Product(DataRow row)
        {
            Id = row["ProductId"].ToString();
            Name = row["ProductName"].ToString();
            Quantity = row["ProductQuantity"].ToString();
            Price = row["ProductPrice"].ToString();
            Description = row["ProductDescription"].ToString();
            Category = row["ProductCategory"].ToString();
        }

        public string InsertCommand()
        {
            return "INSERT INTO Tbl_Products (ProductId,ProductName,ProductQuantity,ProductPrice,ProductDescription,Productcategory) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)";
        }

        public string DeleteCommand()
        {
            return "DELETE FROM Tbl_Products WHERE ProductId=@p1";
        }

        public string UpdateCommand()
        {
            return "UPDATE Tbl_Products Set ProductName=@p1,ProductQuantity=@p2,ProductPrice=@p3,ProductDescription=@p4,ProductCategory=@p5 WHERE ProductId=@p6";
        }

        

        public SqlParameter[] CreateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Id.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Name.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@p3";
            sqlParameters[2].Value = Quantity.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@p4";
            sqlParameters[3].Value = Price.ToString();

            sqlParameters[4] = new SqlParameter();
            sqlParameters[4].ParameterName = "@p5";
            sqlParameters[4].Value = Description.ToString();

            sqlParameters[5] = new SqlParameter();
            sqlParameters[5].ParameterName = "@p6";
            sqlParameters[5].Value = Category.ToString();

            return sqlParameters;
        }

        public SqlParameter[] DeleteSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];                   
            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Id.ToString();
            return sqlParameters;
        }

        public SqlParameter[] UpdateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Name.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Quantity.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@p3";
            sqlParameters[2].Value = Price.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@p4";
            sqlParameters[3].Value = Description.ToString();

            sqlParameters[4] = new SqlParameter();
            sqlParameters[4].ParameterName = "@p5";
            sqlParameters[4].Value = Category.ToString();

            sqlParameters[5] = new SqlParameter();
            sqlParameters[5].ParameterName = "@p6";
            sqlParameters[5].Value = Id.ToString();

            return sqlParameters;
        }
    }
}
