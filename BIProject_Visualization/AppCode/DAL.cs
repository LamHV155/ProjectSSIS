using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIProject_Visualization.AppCode
{
    public class DAL
    {
        private static string ServerName = "DESKTOP-UB2VQRM";
        private static string DBName = "OnlineRetail_DWH_BI";
        private static string UserName = "sa";
        private static string Password = "viet12345";
        private static string ConnStr = @"Data Source=" + ServerName + ";" +
                                  "Initial Catalog=" + DBName + ";" +
                                  "User id=" + UserName + ";" +
                                  "Password=" + Password + ";";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DAL()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(
            string strSQL,
            CommandType ct,
            params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm = conn.CreateCommand();

            comm.CommandType = ct;
            comm.CommandText = strSQL;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                    comm.Parameters.Add(p);
            }

            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds;
        }
    }
}
