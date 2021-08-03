using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBHelperForNet;
namespace JobReportProcess
{
    public class DataProcess
    {
        public static void ExecuteJob()
        {

            DBParams dbprocess = new DBParams();
           

            // DBConn.Conn.InsertUpdateDeleteProcedure("INSERT_TR_FILE_MONITORING", dbprocess);

            //int prhasil = 
                DBConn.Conn.InsertUpdateDeleteProcedure("JOB_GENERATE_REPORT", dbprocess);
            //if (prhasil > 0)
            //{
            //    return "OK";
            //}
            //else
            //{
            //    return "NG";
            //}
        }
    }
}
