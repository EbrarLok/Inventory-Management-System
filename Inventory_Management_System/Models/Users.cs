using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Models
{
    class Users
    {
        public string Name
        {
            set;
            get;
        }
        public string Password
        {
            set;
            get;
        }

        public Users()
        {

        }

        public Users(DataRow row)
        {
            Name = row["UserName"].ToString();
            Password = row["UserPassword"].ToString();
        }

        public string InsertCommand()
        {
            return "INSERT INTO Tbl_Users (UserName,UserPassword) VALUES (@p1,@p2)";
        }

        public string DeleteCommand()
        {
            return "DELETE FROM Tbl_Users WHERE UserName=@u1";
        }

        public string UpdateCommand()
        {
            return "UPDATE Tbl_Users Set UserPassword=@u1 WHERE UserName=@u2";
        }

        public SqlParameter[] CreateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@p1";
            sqlParameters[0].Value = Name.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@p2";
            sqlParameters[1].Value = Password.ToString();

            return sqlParameters;
        }

        public SqlParameter[] DeleteSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@u1";
            sqlParameters[0].Value = Name.ToString();
            return sqlParameters;
        }

        public SqlParameter[] UpdateSQLParameters()
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter();
            sqlParameters[0].ParameterName = "@u1";
            sqlParameters[0].Value = Password.ToString();

            sqlParameters[1] = new SqlParameter();
            sqlParameters[1].ParameterName = "@u2";
            sqlParameters[1].Value = Name.ToString();
  

            return sqlParameters;
        }
    }
}
