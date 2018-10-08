using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace DVDSYS
{
    class Analysis
    {

        public static DataSet getMonthlyData(DataSet DS, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(Transaction_Date,'MM'), SUM(Transaction_Amount) FROM Transactions WHERE Transaction_Date LIKE '%" + Year + "' GROUP BY TO_CHAR(Transaction_Date, 'MM') " +
                            "ORDER BY TO_CHAR(Transaction_Date, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }

        public static DataSet getMonthlyMember(DataSet DS, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT TO_CHAR(Register_Date,'MM'), Count(Member_Id) FROM Members WHERE Register_Date LIKE '%" + Year + "' GROUP BY TO_CHAR(Register_Date, 'MM') " +
                            "ORDER BY TO_CHAR(Register_Date, 'MM')";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;

        }


    }
}
