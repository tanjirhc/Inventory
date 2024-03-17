using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    [Serializable]
    public class BaseAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool VerifyLogin()
        {
            DataTable dataTable = new DataTable();

            string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            
            //ApplicationName
            SqlConnection connection = new SqlConnection(ConnString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;

            cmd.CommandText = "spOst_LstUsers";
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SqlParameter("@UserName", this.UserName));
            cmd.Parameters.Add(new SqlParameter("@Password", this.Password));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;                      
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            cmd.Dispose();
            connection.Close();

            if (dataTable.Rows.Count>0)
            {
                return true;
            }


            //var pdata =(from p in dataTable.AsEnumerable() 
            //            where p.Field<string>("Username") ==this.UserName && p.Field<string>("Password")==this.Password                        select new
            //            {
            //                UserName = p.Field<string>("Username")
            //            }
            //            ).SingleOrDefault();
            //if (pdata!=null)
            //{
            //    return true;
            //}
            return false;
        }
    }
}