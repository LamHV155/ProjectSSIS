using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIProject_Visualization.AppCode
{
    public class ReviewDAL
    {
        DAL db = null;
        public ReviewDAL()
        {
            db = new DAL();
        }

        public static DataTable ReviewPerMonth(int year, string category)
        {
            DAL db = new DAL();
            return db.ExecuteQueryDataSet(
                "P_ReviewPerMonthInYear",
                CommandType.StoredProcedure,
                new SqlParameter("@Year", year),
                new SqlParameter("@Category", category)).Tables[0];
        }

        public static DataTable ReviewPerScore(int month, int year, string category)
        {
            DAL db = new DAL();
            return db.ExecuteQueryDataSet(
                "P_Count_ReviewScore",
                CommandType.StoredProcedure,
                new SqlParameter("@Month", month),
                new SqlParameter("@Year", year),
                new SqlParameter("@Category", category)).Tables[0];
        }
    }
}
