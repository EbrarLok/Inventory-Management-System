using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    class Clients
    {
        public string Name
        {
            set;
            get;
        }

        public string Phone
        {
            get;
            set;
        }

        public string Mail
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public Clients()
        {
            
        }

        public Clients(DataRow row)
        {
            Name = row["ClientName"].ToString();
            Phone = row["ClientPhone"].ToString();
            Mail = row["ClientMail"].ToString();
            Address = row["ClientAddress"].ToString();
        }

        public string InsertCommand()
        {
            return "INSERT INTO Tbl_Client (ClientName,ClientPhone,ClientMail,ClientAddress) VALUES (@p1,@p2,@p3,@p4)";
        }

        public string DeleteCommand()
        {
            return "DELETE FROM Tbl_Client WHERE ClientName=@p1";
        }

        public string UpdateCommand()
        {
            return "UPDATE Tbl_Client Set ClientPhone=@p1,ClientMail=@p2,ClientAddress=@p3 WHERE ClientName=@p4";
        }

        public SqlParameter[] CreateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Name.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Phone.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@p3";
            sqlParameters[2].Value = Mail.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@p4";
            sqlParameters[3].Value = Address.ToString();

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
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Phone.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Mail.ToString();

            sqlParameters[2] = new SqlParameter();
            sqlParameters[2].ParameterName = "@p3";
            sqlParameters[2].Value = Address.ToString();

            sqlParameters[3] = new SqlParameter();
            sqlParameters[3].ParameterName = "@p4";
            sqlParameters[3].Value = Name.ToString();

            return sqlParameters;
        }
    }
}
