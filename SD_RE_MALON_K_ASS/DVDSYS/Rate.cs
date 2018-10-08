using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDSYS
{
    class Rate
    {
        //instance variables
        private string rate_code;
        private string description;
        private decimal rate;

    

    //no argument consturctor
    public Rate()
    {
        rate_code = "";
        description = "";
        rate = 0;

    }

    //Define setters
    public void setRateCode(String Rate_Code)
    {
        this.rate_code = Rate_Code;
    }

    public void setDescription(String Description)
    {
        this.description = Description;
    }

    public void setRate(decimal rate)
    {
        this.rate = rate;
    }

    //Define getters
    public String getRateCode()
    {
        return rate_code;
    }



    //define a static method to get data from Rate table - for displaying data
    public static DataSet getAllRate(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT Rate_Code, Description, Rate Order By Rate_Code";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "ss");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;


        }

    public void setRate()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT rate record
            String strSQL = "INSERT INTO Rates VALUES('" + this.rate_code.ToUpper() + "','" + this.description.ToUpper() + "'," + this.rate + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }


        //checks if rate code has already exists in Rate Table
        public static Boolean RateCodeExists(String RateCode)
        {
            Boolean answer = true;

            //Connect to Database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Rates WHERE Rate_code = '" + RateCode.ToUpper() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();
            
            //Finish
            if (dr.Read())
                answer.Equals(true);
            else
                answer = false;
             

            //close DB connection
            myConn.Close();

            //return answer
            return answer;
        }


        //checks if Ratecode exists when savin in the DVD Table
        public static Boolean DVDRateCodeExists(String RateCode)
        {
            Boolean answer = false;

            //Connect to Database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Rates WHERE Rate_code = '" + RateCode.ToUpper() + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //Finish
            if (dr.Read())
                answer.Equals(true);
            else
                answer = true;


            //close DB connection
            myConn.Close();

            //return answer
            return answer;
        }

       



    }

  
}
