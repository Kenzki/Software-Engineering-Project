using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDSYS
{
    class Rentals
    {

        //instance variables
        private int rental_id;
        private string name;
        private int member_id;
        private string rent_date;
        private string due_date;

        private int transaction_id;
        private string transaction_type;
        private string transaction_date;
        private decimal transaction_amount;

        //no argument consturctor
        public Rentals()
        {
            rental_id = 0;
            name = "";
            member_id = 0;     
            rent_date = "";
            due_date = "";

            transaction_id = 0;
            transaction_type = "";
            transaction_date = "";
            transaction_amount = 0;
            
        }

        //Define setters

        public void setRentalId(int Rental_Id)
        {
            this.rental_id = Rental_Id;
        }

        public void setName(string Name)
        {
            this.name = Name;
        }

        public void setMemberId(int Member_Id)
        {
            this.member_id = Member_Id;
        }


        public void setRentDate(string Rent_Date)
        {
            this.rent_date = Rent_Date;
        }

        public void setDueDate(string Due_Date)
        {
            this.due_date = Due_Date;
        }

        public void setTransactionId(int Transaction_Id)
        {
            this.transaction_id = Transaction_Id;
        }

        public void setTransactionType(string Transaction_Type)
        {
            this.transaction_type = Transaction_Type;
        }

        public void setTransactionDate(string Transaction_Date)
        {
            this.transaction_date = Transaction_Date;
        }

        public void setTransactionAmount(decimal Transactionb_Amount)
        {
            this.transaction_amount = Transactionb_Amount;
        }

    

        //Define getters
        public int getRentalId()
        {
            return rental_id;
        }

        public string getName()
        {
            return name;
        }

        public int getMemberId()
        {
            return member_id;
        }

  

        public string getRentDate()
        {
            return rent_date;
        }

        public string getDueDate()
        {
            return due_date;
        }


        public int getTransactionId()
        {
            return transaction_id;
        }

        public string getTransactionType()
        {
            return transaction_type;
        }

        public string getTransactionDate()
        {
            return transaction_date;
        }

        public decimal getTransactionAmount()
        {
            return transaction_amount;
        }
     

        //define a static method to get data
        public static DataSet getRentals(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Rentals ORDER BY Rental_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter ds = new OracleDataAdapter(cmd);

            ds.Fill(DS, "ss");

            conn.Close();

            return DS;


        }

        public static DataSet getTransaction(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Transactions ORDER BY Transaction_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter ds = new OracleDataAdapter(cmd);

            ds.Fill(DS, "ss");

            conn.Close();

            return DS;
        }



        public void setRentals()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT Rental record
            String strSQL = "INSERT INTO Rentals VALUES(" + this.rental_id.ToString() + ",'" + this.name + "'," + this.member_id.ToString() + ",'" + this.rent_date + "','" + this.due_date + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static int nextRentalId()
        {
            int nextRentalId;

            //Connect to Database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Rental_Id) FROM Rentals";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextRentalId = 1;
            else
                nextRentalId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return nextRentalId;
        }

        public void setTransaction()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT Transactions record
            String strSQL = "INSERT INTO Transactions VALUES(" + this.transaction_id.ToString() + "," + this.member_id.ToString() + "," + this.rental_id.ToString() + ",'"+ this.transaction_type + "','" + this.transaction_date + "'," + this.transaction_amount.ToString() + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static int nextTransactionId()
        {
            int nextTransactionId;

            //Connect to Database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Transaction_Id) FROM Transactions";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextTransactionId = 1;
            else
                nextTransactionId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return nextTransactionId;
        }


        public static DataSet getSearchRentIdbyName(DataSet DS, string MemberName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Rentals WHERE Name LIKE '" + MemberName + "%' ORDER BY Member_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter ds = new OracleDataAdapter(cmd);

            ds.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public void getRentals (int RentId)
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX Rental Id
            String strSQL = "SELECT * FROM Rentals WHERE Rental_Id = " + RentId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {


                setRentalId(dr.GetInt32(0));
                setName(dr.GetString(1));
                setMemberId(dr.GetInt32(2));
              
                //setDueDate(dr.GetString(4));

            }
            //close DB connection
            myConn.Close();

        }




    }
}