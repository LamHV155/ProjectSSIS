using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIProject_Visualization.AppCode
{
    public class ComboboxDAL
    {
        DAL db = null;
        public ComboboxDAL()
        {
            db = new DAL();
        }
        public static DataTable GetCategory()
        {
            DAL db = new DAL();
            return db.ExecuteQueryDataSet(
                "P_GetCategory",
                CommandType.StoredProcedure,
                null).Tables[0];
        }
    }
}
