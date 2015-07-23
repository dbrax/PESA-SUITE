using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.Configuration;


namespace AccessPesa
{


    class Databasecon : Data
    {
        public SQLiteConnection sqlite;
        private String tablename = "null";
        //note the connection string needs to be edited for packaging
        private String conn = @"Data Source=pesasuite.db";
        private String lastdate;
        private String stm;
        public Databasecon()
        {
            sqlite = new SQLiteConnection(conn);
            //this class contructor

        }

        public void selectdata(String tn)
        {
            this.tablename = tn;
            customerName = new ArrayList();
            transactionID = new ArrayList();
            transactionValue = new ArrayList();
            Bnlc = new ArrayList();
            customerID = new ArrayList();

            datte = new ArrayList();
            customerPhoneNo = new ArrayList();
            customerIdType = new ArrayList();
            transactionType = new ArrayList();
            Cash_in = new ArrayList();


            //MessageBox.Show(tablename);


            using (SQLiteConnection con = new SQLiteConnection(conn))
            {
                    
                switch (tablename)
                {
                    case "mpesa":
                        stm = "SELECT * from mpesa";
                        break;

                    case "tigopesa":
                        stm = "SELECT * from tigopesa";
                        break;

                    case "airtel":
                        stm = "SELECT * from airtel";
                        break;

                    case "ezypesa":
                        stm = "select * from ezypesa";
                        break;

                    case "crdb":
                        stm = "SELECT * from crdb";
                        break;


                }






                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {

                        try
                        {

                            while (rdr.Read())
                            {

                                transactionID.Add(rdr.GetValue(1));

                                customerName.Add(rdr.GetString(3));
                                transactionValue.Add(rdr.GetValue(7));
                                Bnlc.Add(rdr.GetValue(9));
                                customerID.Add(rdr.GetValue(2));
                                datte.Add(rdr.GetString(6));
                                customerPhoneNo.Add(rdr.GetValue(5));
                                customerIdType.Add(rdr.GetString(4));
                                transactionType.Add(rdr.GetString(8));
                                Cash_in.Add(rdr.GetInt32(10));







                            }
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show("error in connection");

                        }





                    }
                }

                con.Close();
                //end of the f(*)
            }




        }
        public void Insertdata(String tablename, String transaction_id, String transaction_type, float transaction_value, String customer_name, int customer_phone_no, int customer_id, String customer_id_type, float balance, float cash)
        {
            this.cash = cash;
            this.customer_id = customer_id;
            this.balance = balance;
            this.customer_id_type = customer_id_type;
            this.customer_phone_no = customer_phone_no;
            this.transaction_id = transaction_id;
            this.transaction_value = transaction_value;
            this.transaction_type = transaction_type;
            this.customer_name = customer_name;
            this.tablename = tablename;
            this.date = DateTime.Now.ToString("d/M/yyyy");
            //important connection starts here
            if (tablename == "null")
            {

                MessageBox.Show("table name was not provided");

            }
            else
            {


                using (this.sqlite)
                {
                    try
                    {

                        this.sqlite.Open();
                        if (this.sqlite.State == ConnectionState.Open)
                        {

                            SQLiteCommand cmd = new SQLiteCommand(this.sqlite);
                            if (tablename == "mpesa")
                                cmd.CommandText = "INSERT INTO mpesa (transaction_id, customer_id,customer_name,customer_id_type,customer_phone_no,date,transaction_value,transaction_type,balance,cash)  VALUES (@transaction_id, @customer_id,@customer_name,@customer_id_type,@customer_phone_no,@date,@transaction_value,@transaction_type,@balance,@cash)";
                            else if (tablename == "tigopesa")
                                cmd.CommandText = "INSERT INTO tigopesa (transaction_id,customer_id,customer_name,customer_id_type,customer_phone_no,date, transaction_value,transaction_type,balance,cash)  VALUES (@transaction_id, @customer_id,@customer_name,@customer_id_type,@customer_phone_no,@date,@transaction_value,@transaction_type,@balance,@cash)";
                            else if (tablename == "airtel")
                                cmd.CommandText = "INSERT INTO airtel (transaction_id,customer_id,customer_name,customer_id_type,customer_phone_no,date, transaction_value,transaction_type,balance,cash)  VALUES (@transaction_id, @customer_id,@customer_name,@customer_id_type,@customer_phone_no,@date,@transaction_value,@transaction_type,@balance,@cash)";
                            else if (tablename == "ezypesa")
                                cmd.CommandText = "INSERT INTO ezypesa (transaction_id,customer_id,customer_name,customer_id_type,customer_phone_no,date, transaction_value,transaction_type,balance,cash)  VALUES (@transaction_id, @customer_id,@customer_name,@customer_id_type,@customer_phone_no,@date,@transaction_value,@transaction_type,@balance,@cash)";
                            else if (tablename == "crdb")
                                cmd.CommandText = "INSERT INTO crdb (transaction_id,customer_id,customer_name,customer_id_type,customer_phone_no,date, transaction_value,transaction_type,balance,cash)  VALUES (@transaction_id, @customer_id,@customer_name,@customer_id_type,@customer_phone_no,@date,@transaction_value,@transaction_type,@balance,@cash)";


                            //more if statement for other tables here
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@transaction_id", this.transaction_id);
                            cmd.Parameters.AddWithValue("@customer_id", this.customer_id);
                            cmd.Parameters.AddWithValue("@customer_name", this.customer_name);
                            cmd.Parameters.AddWithValue("@customer_id_type", this.customer_id_type);
                            cmd.Parameters.AddWithValue("@customer_phone_no", this.customer_phone_no);
                            cmd.Parameters.AddWithValue("@date", this.date);

                            cmd.Parameters.AddWithValue("@transaction_value", this.transaction_value);
                            cmd.Parameters.AddWithValue("@transaction_type", this.transaction_type);

                            if (tablename == "mpesa")
                                cmd.Parameters.AddWithValue("@balance", this.balance);
                            else if (tablename == "tigopesa")
                                cmd.Parameters.AddWithValue("@balance", this.balance);
                            else if (tablename == "airtel")
                                cmd.Parameters.AddWithValue("@balance", this.balance);
                            else if (tablename == "ezypesa")
                                cmd.Parameters.AddWithValue("@balance", this.balance);
                            else if (tablename == "crdb")
                                cmd.Parameters.AddWithValue("@balance", this.balance);
                            //more if statement for other tables


                            cmd.Parameters.AddWithValue("@cash", this.cash);
                            cmd.ExecuteNonQuery();

                            this.sqlite.Close();


                            //end
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            //important connection ends here


        }

        public ArrayList Cutomername()
        {
            return customerName;

        }

        public ArrayList TransactionId()
        {
            return transactionID;

        }


        public ArrayList Transaction_value()
        {
            return transactionValue;

        }

        public ArrayList Balance()
        {
            return Bnlc;

        }
        public ArrayList dates()
        {
            return datte;

        }
        public ArrayList customerphoneno()
        {
            return customerPhoneNo;

        }
        public ArrayList customeridtype()
        {
            return customerIdType;

        }
        public ArrayList transactiontype()
        {
            return transactionType;

        }
        public ArrayList cashIn()
        {
            return Cash_in;

        }
        public ArrayList customerId()
        {
            return customerID;
        }

        public String lastestdate(String tn)
        {

            this.tablename = tn;
            
            using (SQLiteConnection con = new SQLiteConnection(conn))
            {

                
                switch (tablename)
                {
                    case "mpesa":
                        stm = "select date from mpesa where date = ( select max(date) from mpesa)";
                        break;

                    case "tigopesa":
                        stm = "select date from tigopesa where date = ( select max(date) from tigopesa)";
                        break;

                    case "airtel":
                        stm = " select date from airtel where date = ( select max(date) from airtel)";
                        break;

                    case "ezypesa":
                        stm = "select date from ezypesa where date = ( select max(date) from ezypesa)";
                        break;

                    case "crdb":
                        stm = "select date from crdb where date = ( select max(date) from crdb)";
                        break;


                }




                con.Open();


                using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {

                        try
                        {

                            while (rdr.Read())
                            {



                                lastdate = (rdr.GetString(10));



                            }
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show("error in connection");

                        }





                    }
                }

                con.Close();
                //end of the f(*)

               

            }
            return lastdate;

//end of function
        }

    }
}
