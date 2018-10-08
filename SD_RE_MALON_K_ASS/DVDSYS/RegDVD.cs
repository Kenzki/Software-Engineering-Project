using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDSYS
{
    class RegDVD
    {
        //instance variables
        private int dvd_id;
        private string title;
        private string description;
        private int year;
        private string rate_code;

        //no argument consturctor
        public RegDVD()
        {
            dvd_id = 0;
            title = "";
            description = "";
            year = 0;
            rate_code = "";
        }

        //Define setters
        public void setDVDId(int DVD_Id)
        {
            this.dvd_id = DVD_Id;
        }

        public void setTitle(string Title)
        {
            this.title = Title;
        }

        public void setDescription(string Description)
        {
            this.description = Description;
        }

        public void setYear(int Year)
        {
            this.year = Year;
        }
        
        public void setRateCode(string Rate_Code)
        {
            this.rate_code = Rate_Code;
        }

        //Define getters
        public int getDVDId()
        {
            return dvd_id;
        }



        public void setRegisterDVD()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT DVD record
            String strSQL = "INSERT INTO DVDS VALUES(" + this.dvd_id.ToString() + ",'" + this.title + "','" + this.description + "'," + this.year.ToString() + ",'" + this.rate_code + "')"; 

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static int nextDVDId()
        {
            int nextDVDId;

            //Connect to Database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(DVD_ID) FROM DVDS";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextDVDId = 1;
            else
                nextDVDId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return nextDVDId;
        }







    }
}
