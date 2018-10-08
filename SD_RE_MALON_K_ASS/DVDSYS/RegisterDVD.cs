using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDSYS
{
    class RegisterDVD
    {
        //instance variables
        private int dvd_id;
        private string title;
        private string description;
        private string date;
        private string rate_code;

        //no argument consturctor
        public RegisterDVD()
        {
            dvd_id = 0;
            title = "";
            description = "";
            date = "";
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

        public void setDate(string Date)
        {
            this.date = Date;
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
            String strSQL = "INSERT INTO Rates VALUES(" + this.rate_code +
                ",'" + this.description.ToUpper() + "','" + this.dvd_id + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }





    }
}
