using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    public class AssetsandLiabilities
    {
        public string Id
        {
            set;
            get;
        }

        public string Situation
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string TransactionDate
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
        public string Drawee
        {
            get;
            set;
        }

        public AssetsandLiabilities()
        {

        }


        public AssetsandLiabilities(DataRow row)
        {
            Id = row["ProductId"].ToString();
            Situation = row["Situation"].ToString();
            Description = row["Description"].ToString();
            TransactionDate = row["TransactionDate"].ToString();
            Quantity = row["ProductQuantity"].ToString();
            Price = row["Price"].ToString();
            Drawee = row["Drawee"].ToString();
        }

        public string InsertCommand()
        {
            return "INSERT INTO Tbl_AssetsandLiabilities (ProductId,Situation,Description,TransactionDate,ProductQuantity,Price,Drawee) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
        }

        public string UpdateCommand()
        {
            return "UPDATE Tbl_AssetsandLiabilities Set Situation=@p1,Description=@p2,TransactionDate=@p3,ProductQuantity=@p4,Price=@p5,Drawee=@p6 WHERE ProductId=@p7";
        }

        public string DeleteCommand()
        {
            return "DELETE FROM Tbl_AssetsandLiabilities WHERE ProductId=@p1";
        }

        


        public SqlParameter[] CreateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Id.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Situation.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@p3";
            sqlParameters[2].Value = Description.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@p4";
            sqlParameters[3].Value = TransactionDate.ToString();

            sqlParameters[4] = new SqlParameter();
            sqlParameters[4].ParameterName = "@p5";
            sqlParameters[4].Value = Quantity.ToString();

            sqlParameters[5] = new SqlParameter();
            sqlParameters[5].ParameterName = "@p6";
            sqlParameters[5].Value = Price.ToString();

            sqlParameters[6] = new SqlParameter();
            sqlParameters[6].ParameterName = "@p7";
            sqlParameters[6].Value = Drawee.ToString();

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
            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Situation.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Description.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@p3";
            sqlParameters[2].Value = TransactionDate.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@p4";
            sqlParameters[3].Value = Quantity.ToString();

            sqlParameters[4] = new SqlParameter();
            sqlParameters[4].ParameterName = "@p5";
            sqlParameters[4].Value = Price.ToString();

            sqlParameters[5] = new SqlParameter();
            sqlParameters[5].ParameterName = "@p6";
            sqlParameters[5].Value = Drawee.ToString();

            sqlParameters[6] = new SqlParameter();
            sqlParameters[6].ParameterName = "@p7";
            sqlParameters[6].Value = Id.ToString();

            return sqlParameters;
        }

    }
}
