using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDSYS
{
    class DVD
    {
        //instance variables
        private int dvd_id;
        private string title;
        private string description;
        private int year;
        private string rate_code;
        private string status;
        private string rent_status;

        //no argument consturctor
        public DVD()
        {
            dvd_id = 0;
            title = "";
            description = "";
            year = 0;
            rate_code = "";
            status = "";
            rent_status = "";
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

        public void setStatus(string Status)
        {
            this.status = Status;
        }

        public void setRentStatus(string Rent_Staus)
        {
            this.rent_status = Rent_Staus;
        }

        //Define getters
        public int getDVDId()
        {
            return dvd_id;
        }

        public string getTitle()
        {
            return title;
        }

        public string getDescription()
        {
            return description;
        }

        public int getYear()
        {
            return year;
        }

        public string getRateCode()
        {
            return rate_code;
        }

        public string getStatus()
        {
            return status;
        }

        public string getRentStatus()
        {
            return rent_status;
        }

        //define a static method to get data
        public static DataSet getDVD(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM DVDS ORDER BY DVD_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter ds = new OracleDataAdapter(cmd);

            ds.Fill(DS, "ss");

            conn.Close();

            return DS;
        }



        public void setRegisterDVD()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT DVD record
            String strSQL = "INSERT INTO DVDS VALUES(" + this.dvd_id.ToString() + ",'" + this.title + "','" + this.description + "'," + this.year.ToString() + ",'" + this.rate_code.ToUpper() + "','" + this.status + "','" + this.rent_status + "')"; 

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

        public void getDVD(int DVDId)
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT * FROM DVDS WHERE DVD_Id = " + DVDId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {

                setDVDId(dr.GetInt32(0));
                setTitle(dr.GetString(1));
                setDescription(dr.GetString(2));
                setYear(dr.GetInt32(3));
                setRateCode(dr.GetString(4));
                setStatus(dr.GetString(5));

            }
            //close DB connection
            myConn.Close();


        }

        public void updDVD()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT DVDs record
            String strSQL = "UPDATE DVDS SET Title = '" + this.title + "', Description = '" + 
                this.description + "', Release_Year = " + this.year + ", Rate_Code = '" + this.rate_code.ToUpper() + "' WHERE DVD_Id = " + this.dvd_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

      

        public void DiscontinueDVD()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE DVDS SET Status = '" + this.status.ToUpper() + "' WHERE DVD_Id = " + this.dvd_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static DataSet getSearchDVD(DataSet DS, string DVDTitle)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT Dvd_ID, Title, Rent_Status, D.Rate_Code, Rate  FROM DVDS D JOIN Rates R ON D.Rate_Code = R.Rate_Code WHERE Title LIKE '" + DVDTitle + "%' AND Status = 'A' ORDER BY Title";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter ds = new OracleDataAdapter(cmd);

            ds.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


        public void ChangeRentDVD()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE DVDS SET Rent_Status = '" + this.rent_status.ToUpper() + "' WHERE DVD_Id = " + this.dvd_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }






    }
}
