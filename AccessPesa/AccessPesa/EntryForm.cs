using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AccessPesa
{
    public partial class EntryForm : Form
    {
        //public Vodacom_Mpesa vodz = null;
        private int dif;
        public Boolean turn = false;
        private Boolean error;
        public Airtel_Money formtoairtel;
        public Ezy_Pesa formtoezy;
        public Tigo_Pesa formtotigo;
        public CRDB_Bank formtocrdb;
        public Vodacom_Mpesa formtovoda;
        public String from;
        String tablename;
        private float balance;
        private float cash;
        public EntryForm()
        {
            InitializeComponent();
        }

        public void setBelonging(String f){
            from = f;
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {
            switch (from)
            {
                case "airtel":
                    label1.Text = "AIRTEL MONEY FORM";
                    this.BackColor = Color.DarkRed;
                    break;
                case "ezy":
                    label1.Text = "EZY PESA FORM";
                    this.BackColor = Color.DarkGreen;
                    break;
                case "tigo":
                    label1.Text = "TIGO PESA FORM";
                    this.BackColor = Color.SteelBlue;
                    break;
                case "voda":
                    label1.Text = "VODACOM M-PESA FORM";
                    this.BackColor = Color.DarkRed;
                    break;
                case "crdb":
                    label1.Text = "CRDB BANK FORM";
                    this.BackColor = Color.SeaGreen;
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            
            
            DialogResult dialogResult = MessageBox.Show("Reset your Form?", "Reset?", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                TransactionId_TextBox.Text = "";
                TransactionValue_TextBox.Text = "";
                CustomerCellPhone_TextBox.Text = "";
                CustomerIdNo_TextBox.Text = "";
                CustomerIdType_TextBox.Text = "";
                CustomerName_TextBox.Text = "";
                PokeaButton.Checked = false;
                ToaButton.Checked = false;
                resetlabels();
            }
            
            
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {//ErrorHandling
            resetlabels();
            error = false;
            int cassh;
            

            ErrorHandling();
            if (error == true)
            {
                AlertMain.Visible = true;
                //AlertMain.ForeColor = System.Drawing.Color.White;
            }
            else if (error == false)
            { //connect
                //  MessageBox.Show("Success");\

                XDocument hela = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in hela.Descendants("settings")
                            select new
                            {
                                       
                                csh = usr.Element("cashIn").Value
                            };


                foreach (var use in users)
                {
                    cassh = int.Parse(use.csh);

                    dif = cassh - int.Parse(TransactionValue_TextBox.Text);
                }




                if (dif < 0) 
                {
                    MessageBox.Show("Balance insufficient");
                }


                else
                {

                    if (CustomerIdNo_TextBox.Text == "") { CustomerIdNo_TextBox.Text = "000000000"; }
                    if (CustomerIdType_TextBox.Text == "") { CustomerIdType_TextBox.Text = ""; }
                    CustomerCellPhone_TextBox.Text = CustomerCellPhone_TextBox.Text;
                    String trans_id = TransactionId_TextBox.Text;
                    float trans_value = float.Parse(TransactionValue_TextBox.Text);
                    String cust_name = CustomerName_TextBox.Text;
                    int customer_phone_no = int.Parse(CustomerCellPhone_TextBox.Text);
                    int customer_id = int.Parse(CustomerIdNo_TextBox.Text);
                    String customer_id_type = CustomerIdType_TextBox.Text;

                    String trans_type = "";
                    if (PokeaButton.Checked)
                    {
                        trans_type = "Pokea";

                    }
                    else if (ToaButton.Checked)
                    {
                        trans_type = "Toa";
                    }

                    //

                    switch (label1.Text)
                    {

                        case "VODACOM M-PESA FORM":
                            tablename = "mpesa";
                            Databasecon inserting = new Databasecon();
                            BussinessLogic calc = new BussinessLogic();
                            //BussinessLogic cashInhand = new BussinessLogic();

                            if (trans_type == "Pokea")
                            {
                                balance = calc.pokea(trans_value, "mpesa");
                                cash = calc.getCash();
                            }
                            else if (trans_type == "Toa")
                            {
                                balance = calc.Toa(trans_value, "mpesa");
                                cash = calc.getCash();

                            }

                            inserting.Insertdata(tablename, trans_id, trans_type, trans_value, cust_name, customer_phone_no, customer_id, customer_id_type, balance, cash);
                            // turn = true;
                            //vodz.reload();


                            Close();
                            //this.DialogResult = DialogResult.OK;
                            break;
                        case "TIGO PESA FORM":
                            tablename = "tigopesa";
                            Databasecon insertin = new Databasecon();
                            BussinessLogic calculation = new BussinessLogic();
                            //BussinessLogic cashInhand = new BussinessLogic();

                            if (trans_type == "Pokea")
                            {
                                balance = calculation.pokea(trans_value, "tigopesa");
                                cash = calculation.getCash();
                            }
                            else if (trans_type == "Toa")
                            {
                                balance = calculation.Toa(trans_value, "tigopesa");
                                cash = calculation.getCash();

                            }
                            insertin.Insertdata(tablename, trans_id, trans_type, trans_value, cust_name, customer_phone_no, customer_id, customer_id_type, balance, cash);
                            // turn = true;
                            //vodz.reload();


                            Close();
                            //this.DialogResult = DialogResult.OK;
                            break;
                        case "EZY PESA FORM":
                            tablename = "ezypesa";
                            Databasecon insert = new Databasecon();
                            BussinessLogic calculate = new BussinessLogic();
                            //BussinessLogic cashInhand = new BussinessLogic();

                            if (trans_type == "Pokea")
                            {
                                balance = calculate.pokea(trans_value, "ezypesa");
                                cash = calculate.getCash();
                            }
                            else if (trans_type == "Toa")
                            {
                                balance = calculate.Toa(trans_value, "ezypesa");
                                cash = calculate.getCash();

                            }
                            insert.Insertdata(tablename, trans_id, trans_type, trans_value, cust_name, customer_phone_no, customer_id, customer_id_type, balance, cash);
                            // turn = true;
                            //vodz.reload();


                            Close();
                            //this.DialogResult = DialogResult.OK;
                            break;
                        case "CRDB BANK FORM":
                            tablename = "crdb";
                            Databasecon insertt = new Databasecon();
                            BussinessLogic calculatt = new BussinessLogic();
                            //BussinessLogic cashInhand = new BussinessLogic();

                            if (trans_type == "Pokea")
                            {
                                balance = calculatt.pokea(trans_value, "crdb");
                                cash = calculatt.getCash();
                            }
                            else if (trans_type == "Toa")
                            {
                                balance = calculatt.Toa(trans_value, "crdb");
                                cash = calculatt.getCash();

                            }
                            insertt.Insertdata(tablename, trans_id, trans_type, trans_value, cust_name, customer_phone_no, customer_id, customer_id_type, balance, cash);
                            // turn = true;
                            //vodz.reload();


                            Close();
                            //this.DialogResult = DialogResult.OK;
                            break;

                        case "AIRTEL MONEY FORM":
                            tablename = "airtel";
                            Databasecon inserttt = new Databasecon();
                            BussinessLogic calculattt = new BussinessLogic();
                            //BussinessLogic cashInhand = new BussinessLogic();

                            if (trans_type == "Pokea")
                            {
                                balance = calculattt.pokea(trans_value, "airtel");
                                cash = calculattt.getCash();
                            }
                            else if (trans_type == "Toa")
                            {
                                balance = calculattt.Toa(trans_value, "airtel");
                                cash = calculattt.getCash();

                            }
                            inserttt.Insertdata(tablename, trans_id, trans_type, trans_value, cust_name, customer_phone_no, customer_id, customer_id_type, balance, cash);
                            // turn = true;
                            //vodz.reload();


                            Close();
                            //this.DialogResult = DialogResult.OK;
                            break;

                    }
                }
            }


            /*  Connection to database
             
             * String tablename = "mpesa";
            Databasecon inserting = new Databasecon();
            
             */
            
            //kazi kwako kupitisha variable checki mfumo wa function yangu Insertdata
          //inserting.Insertdata(tablename,  990, "toa", 10000,"sele", 091475533, 4, "passport",2000);
          //inserting.selectdata();

        }

        private void resetlabels()
        {
            custnumerror.Visible = false;
            AlertMain.Visible = false;
            Alert1.Visible = false;
            Alert2.Visible = false;
            Alert3.Visible = false;
            Alert4.Visible = false;
            Alert5.Visible = false;
            Alert6.Visible = false;
            Alert7.Visible = false;
        }
        private void ErrorHandling()
        {
            bool mb = false;
            String messagenumber = "";
            if (TransactionId_TextBox.Text.Length < 7)
            {
                error = true;
                Alert1.Visible = true;
            }

            if (!PokeaButton.Checked && !ToaButton.Checked)
            {
                error = true;
                Alert2.Visible = true;
            }
            float ch;
            bool isNumericch = float.TryParse(TransactionValue_TextBox.Text, out ch);
            if (isNumericch == false)
            {

               
                error = true;
                Alert3.Visible = true;

            }

            else if (isNumericch == true)
            {
                if (TransactionValue_TextBox.Text.Length < 1)
                { error = true;
                    Alert3.Visible = true;
                }
            }
           

            if (CustomerName_TextBox.Text.Length < 1)
            {
                error = true;
                Alert4.Visible = true;
            }
            
            int a;
            bool isNumeric = int.TryParse(CustomerCellPhone_TextBox.Text, out a);
                
                
                if (isNumeric == false)
                {
                    
                        mb = true;
                        custnumerror.Visible = true;
                   // messagenumber = "Customer Cell Phone is not a number Check Again";
                    error = true;
                    Alert5.Visible = true;
                    
                }
                
                else if (isNumeric == true)
                {
                    if (CustomerCellPhone_TextBox.Text.Length < 9)
                    {
                        mb = true;
                        custnumerror.Visible = true;
                        messagenumber = "Customer Cell Phone is not full (10digits)";
                    error = true;
                    Alert5.Visible = true;
                    }
                }
                   /*
                    int b;
                  bool  isNumericb = int.TryParse(CustomerIdNo_TextBox.Text, out b);
                    if (isNumericb == false)
                    {
                        
                            mb = true;
                            messagenumber = "Customer Id is not a number Check Again";
                        error = true;
                        Alert6.Visible = true;
                        
                    }


                    else if(isNumericb == true)
                    {
                        if (CustomerIdNo_TextBox.Text.Length < 1)
                        {
                        error = true;
                        Alert6.Visible = true;
                        }
                    }
           if (CustomerIdType_TextBox.Text.Length < 1)
            {
                error = true;
                Alert7.Visible = true;
            }

            if (mb == true)
            {
                MessageBox.Show(messagenumber);
                mb = false;
            }
            */
           
        }
    }
}
