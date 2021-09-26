using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    class Orders
    {
        public string Name
        {
            set;
            get;
        }

        public string Type
        {
            get;
            set;
        }

        public string CourierCompany
        {
            get;
            set;
        }

        public string ParcelTrackingNumber
        {
            get;
            set;
        }

        public string TransactionDate
        {
            get;
            set;
        }

        public string ShipmentFee
        {
            get;
            set;
        }

        public Orders()
        {

        }

        public Orders(DataRow row)
        {
            Name = row["OrderName"].ToString();
            Type = row["OrderType"].ToString();
            CourierCompany = row["CourierCompany"].ToString();
            ParcelTrackingNumber = row["ParcelTrackingNumber"].ToString();
            TransactionDate = row["TransactionDate"].ToString();
            ShipmentFee = row["ShipmentFee"].ToString();
        }

        public string InsertCommand()
        {
            return "INSERT INTO Tbl_Orders (OrderName,OrderType,CourierCompany,ParcelTrackingNumber,TransactionDate,ShipmentFee) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)";
        }

        public string DeleteCommand()
        {
            return "DELETE FROM Tbl_Orders WHERE OrderName=@p1";
        }

        public string UpdateCommand()
        {
            return "UPDATE Tbl_Orders Set OrderType=@o1,CourierCompany=@o2,ParcelTrackingNumber=@o3,TransactionDate=@o4,ShipmentFee=@o5 WHERE OrderName=@o6";
        }

        public SqlParameter[] CreateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Name.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Type.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@p3";
            sqlParameters[2].Value = CourierCompany.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@p4";
            sqlParameters[3].Value = ParcelTrackingNumber.ToString();

            sqlParameters[4] = new SqlParameter();
            sqlParameters[4].ParameterName = "@p5";
            sqlParameters[4].Value = TransactionDate.ToString();

            sqlParameters[5] = new SqlParameter();
            sqlParameters[5].ParameterName = "@p6";
            sqlParameters[5].Value = ShipmentFee.ToString();

            return sqlParameters;
        }

        public SqlParameter[] DeleteSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Name.ToString();
            return sqlParameters;
        }

        public SqlParameter[] UpdateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@o1";
            sqlParameters[0].Value = Type.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@o2";
            sqlParameters[1].Value = CourierCompany.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@o3";
            sqlParameters[2].Value = ParcelTrackingNumber.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@o4";
            sqlParameters[3].Value = TransactionDate.ToString();

            sqlParameters[4] = new SqlParameter();
            sqlParameters[4].ParameterName = "@o5";
            sqlParameters[4].Value = ShipmentFee.ToString();

            sqlParameters[5] = new SqlParameter();
            sqlParameters[5].ParameterName = "@o6";
            sqlParameters[5].Value = Name.ToString();

            return sqlParameters;
        }
    }
}
