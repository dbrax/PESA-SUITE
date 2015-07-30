using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AccessPesa
{
    class Data
    {

        protected String customer_name;
        protected String transaction_id;
        protected float transaction_value;
        protected float balance;
        protected String date;
        protected int customer_phone_no;
        protected String customer_id_type;
        protected int customer_id;
        protected String transaction_type;
        protected float  cash;
        protected ArrayList customerName;
        protected ArrayList transactionID;
        protected ArrayList transactionValue;
        protected ArrayList Bnlc;

        //other vendors will come here
        protected ArrayList datte;
        protected ArrayList customerPhoneNo;
        protected ArrayList customerIdType;
        protected ArrayList customerID;
        protected ArrayList transactionType;
        protected ArrayList Cash_in;



        public Data()
        {

        }
        public Data(String cn, int fb)
        {
            this.customer_name = cn;
            this.balance = fb;





        }



    }
}
