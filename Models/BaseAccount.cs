using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class BaseAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool VerifyLogin()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(ConnString);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            if (this.UserName == "Tanjir" && this.Password == "1234")
            {
                return true;
            }
            return false;
        }
    }
}