using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DVDSYS
{
    class Members
    {
        //instance variables
        private int member_id;
        private string name;
        private string email;
        private string street;
        private string town;
        private double contact;
        private string status;
        private string regdate;


        //no argument consturctor
        public Members()
        {
            member_id = 0;
            name = "";
            email = "";
            street = "";
            town = "";
            contact = 0;
            status = "";
            regdate = "";
        }

        //Define setters
        public void setMember_id(int Member_Id)
        {
            this.member_id = Member_Id;
        }

        public void setName(string Name)
        {
            this.name = Name;
        }

        public void setEmail(string Email)
        {
            this.email = Email;
        }

        public void setStreet(string Street)
        {
            this.street = Street;
        }

        public void setTown(string Town)
        {
            this.town = Town;
        }

        public void setContact(double Contact)
        {
            this.contact = Contact;
        }

        public void setStatus(string Status)
        {
            this.status = Status;
        }

        public void setRegDate(string RegDate)
        {
            this.regdate = RegDate;
        }

        //Define getters
        public int getMemId()
        {
            return member_id;
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return email;
        }

        public string getStreet()
        {
            return street;
        }

        public string getTown()
        {
            return town;
        }

        public double getContact()
        {
            return contact;
        }

        public string getStatus()
        {
            return status;
        }

        public string getRegDAte()
        {
            return regdate;
        }

        //define a static method to get data
        public static DataSet getMembers(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Members ORDER BY Member_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter ds = new OracleDataAdapter(cmd);

            ds.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        

        public void setRegisterMember()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT DVD record
            String strSQL = "INSERT INTO Members VALUES(" + this.member_id.ToString() + ",'" + this.name + "','" + this.email + "','" + this.street + "','" + this.town + "'," + this.contact + ",'"  + this.status + "','" + this.regdate + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static int nextMemId()
        {
            int nextMemId;

            //Connect to Database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Member_ID) FROM Members";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextMemId = 1;
            else
                nextMemId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return nextMemId;
        }

            public void getMember(int MemId)
            {
                //Connect to the DB
                OracleConnection myConn = new OracleConnection(DBConnect.oradb);
                myConn.Open();

                //Define SQL query to get MAX stock_No used
                String strSQL = "SELECT * FROM Members WHERE Member_Id = " + MemId;

                OracleCommand cmd = new OracleCommand(strSQL, myConn);

                //execute the SQL query
                OracleDataReader dr = cmd.ExecuteReader();

                //If first stockNo, assign value 1, otherwise add 1 to MAX value
                if (dr.Read())
                {

                    setMember_id(dr.GetInt32(0));
                    setName(dr.GetString(1));
                    setEmail(dr.GetString(2));
                    setStreet(dr.GetString(3));
                    setTown(dr.GetString(4));
                    setContact(dr.GetInt32(5));
                    setStatus(dr.GetString(6));

                }
                //close DB connection
                myConn.Close();

            }

        public void updMembers()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT DVDs record
            String strSQL = "UPDATE Members SET Name = '" + this.name + "', Email = '" +
                this.email + "', Street = '" + this.street + "', Town = '" + this.town + "', Contact = " + this.contact + " WHERE Member_Id = " + this.member_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


        public void DeRegMem()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "UPDATE Members SET Status = '" + this.status.ToUpper() + "' WHERE Member_Id = " + this.member_id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        

        public static DataSet getSearchName(DataSet DS, string MemberName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //connection name conn.Open();
            String strSQL = "SELECT * FROM Members WHERE Name LIKE '" + MemberName + "%' AND Status = 'A' ORDER BY Member_Id";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter ds = new OracleDataAdapter(cmd);

            ds.Fill(DS, "ss");

            conn.Close();

            return DS;
        }


      





    }


}
