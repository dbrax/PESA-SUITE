using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using System.Globalization;
namespace AccessPesa
{
    public partial class HomeMenu : Form
    {
        private int max;
        public Airtel_Money airtel;
        public Vodacom_Mpesa voda;
        public String onoff = "";
        public Boolean newitem, added;
        public int mpesa, zanp, tigop, crdbm, airtelm;
        private EventArgs e;
        private object sender;
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            setVisibility("on");
            
            
            AirtelMoneyButton.BackColor = Color.White;
            AirtelMoneyButton.Enabled = false;
            tigobutton.BackColor = Color.White;
            tigobutton.Enabled = false;
            vodacombutton.BackColor = Color.White;
            vodacombutton.Enabled = false;
            EzyPesaButton.BackColor = Color.White;
            EzyPesaButton.Enabled = false;
            CRDBBUTTON.BackColor = Color.White;
            CRDBBUTTON.Enabled = false;


            HomePanel.Visible = false;
            LogsPanel.Visible = false;
            reportpanel.Visible = false;
            availableservice();
            

            DateServices tar = new DateServices();
            tar.getdatedata();

            int siku = tar.countDate();
            days.Text = siku + " Days Left";
            //tar.checkValidDate();
            tar.checkTemperDate();

        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            CRDB_Bank crdbform = new CRDB_Bank();
            crdbform.home = this;
            this.Visible = false;
            crdbform.Show();
            //this.Close();
        }

        private void AirtelMoneyButton_Click(object sender, EventArgs e)
        {
            airtel = new Airtel_Money();
            airtel.airteltohome = this;
            this.Visible = false;
            airtel.Show();
            //this.Close();
        }


        private void EzyPesaButton_Click(object sender, EventArgs e)
        {
            Ezy_Pesa ezypesa = new Ezy_Pesa();
            ezypesa.ezytohome = this;
            this.Visible = false;
            ezypesa.Show();

        }

        private void tigobutton_Click(object sender, EventArgs e)
        {
            Tigo_Pesa tigo = new Tigo_Pesa();
            tigo.tigotohome = this;
            this.Visible = false;
            tigo.Show();
        }

        private void vodacombutton_Click(object sender, EventArgs e)
        {
            voda = new Vodacom_Mpesa();
            voda.vodatohome = this;
            this.Visible = true;
            voda.Show();
            voda.setvisible();
        }

        public void setVisibility(String onoff)
        {


            if (onoff == "on")
            {
                this.Visible = true;
            }

            else if (onoff == "off")
            {
                this.Visible = false;
            }
        }

        //SOME CONTROLS ON NAVIGATION....................................................................

        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            int s;
            
            HomePanel.Visible = true;
            LogsPanel.Visible = false;
            reportpanel.Visible = false;
            labels.Visible = true;
            wpanel.Visible = false;
            labels.Text = "HOME";


            XDocument cash = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in cash.Descendants("services")
                        select new
                        {

                            mwnz = usr.Element("mwanzo").Value
                            
                        };


            foreach (var use in users)
            {
                s=  int.Parse(use.mwnz);
                if (s == 0)
                {
                    AddingMoney mpya = new AddingMoney();
                    mpya.addtocash = this;
                    mpya.frm = "cash";
                    mpya.addchange = "change";
                    mpya.changeon();
                    mpya.ShowDialog();
                }
            }
            


        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            HomeLabel.ForeColor = Color.Red;

            homeicon.Visible = true;
            

        }

        private void Logs_Click(object sender, EventArgs e)
        {
            
            LogsPanel.Visible = true;

            HomePanel.Visible = false;
            reportpanel.Visible = false;
            labels.Visible = true;
            wpanel.Visible = false;
            labels.Text = "LOGS";


        }

        private void HomeLabel_MouseLeave(object sender, EventArgs e)
        {
           // homeicon.Visible = false;
           // HomeLabel.Visible = true;
            HomeLabel.ForeColor = Color.White;
        }

        private void Logs_MouseHover(object sender, EventArgs e)
        {
            LogsLabel.ForeColor = Color.Red;
            logsicon.Visible = true;
        }

        private void LogsLabel_MouseLeave(object sender, EventArgs e)
        {
           // logsicon.Visible = false;
            LogsLabel.ForeColor = Color.White;
        }
        
        private void Report_Click(object sender, EventArgs e)
        {
            
            HomePanel.Visible = false;
            LogsPanel.Visible = false;
            labels.Visible = true;
            wpanel.Visible = false;
            labels.Text = "REPORTS";
            reportpanel.Visible = true;
            
        }

        private void Report_MouseHover(object sender, EventArgs e)
        {
            Report.ForeColor = Color.Red;
        }

        private void Report_MouseLeave(object sender, EventArgs e)
        {
            Report.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchlistbox();
            if (newitem == false)
            {
                MessageBox.Show("Service Already Added");
            }
            floatserv(Services.SelectedItem.ToString());
            if (added == true)
            {
                if (newitem == true)
                {

                    listBox1.Items.Add(Services.SelectedItem.ToString());
                    enableLogButtons();
                    serviceadding(Services.SelectedItem.ToString());
                    //Services.SelectedIndex = -1;
                }
                else if (newitem == false)
                {
                    MessageBox.Show("Service Already Added");
                }
            }

        }

        private void floatserv(string a)
        {
            XDocument hela = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in hela.Descendants("services")
                        select new
                        {

                            csh = usr.Element("mwanzo").Value,
                            voda = usr.Element("vodacom").Value,
                            ezy = usr.Element("zantel").Value,
                            airtel = usr.Element("airtel").Value,
                            tigo = usr.Element("tigo").Value,
                            crdb = usr.Element("crdb").Value
                        };


            foreach (var use in users)
            {
                if (use.csh == "0")
                {
                    AddingMoney mpya = new AddingMoney();
                    mpya.addtocash = this;
                    mpya.frm = "cash";
                    mpya.addchange = "change";
                    mpya.changeon();
                    mpya.ShowDialog();
                }
                    if (Services.SelectedItem.ToString() == "AIRTEL MONEY")
                    {
                        if (use.airtel == "0")
                        {
                            AddingMoney mpya = new AddingMoney();
                            mpya.addtocash = this;
                            mpya.frm = "airtel";
                            mpya.addchange = "change";
                            mpya.changeon();
                            mpya.ShowDialog();
                        }
                    }
                    else if (Services.SelectedItem.ToString() == "EZY PESA")
                    {
                        if (use.ezy == "0")
                        {
                            AddingMoney mpya = new AddingMoney();
                            mpya.addtocash = this;
                            mpya.frm = "ezy";
                            mpya.addchange = "change";
                            mpya.changeon();
                            mpya.ShowDialog();
                        }
                    }
                    else if (Services.SelectedItem.ToString() == "TIGO PESA")
                    {
                        if (use.tigo == "0")
                        {
                            AddingMoney mpya = new AddingMoney();
                            mpya.addtocash = this;
                            mpya.frm = "tigo";
                            mpya.addchange = "change";
                            mpya.changeon();
                            mpya.ShowDialog();
                        }
                    }
                    else if (Services.SelectedItem.ToString() == "VODACOM M-PESA")
                    {
                        if (use.voda == "0")
                        {
                            AddingMoney mpya = new AddingMoney();
                            mpya.addtocash = this;
                            mpya.frm = "voda";
                            mpya.addchange = "change";
                            mpya.changeon();
                            mpya.ShowDialog();
                        }
                    }
                    else if (Services.SelectedItem.ToString() == "CRDB BANK")
                    {
                        if (use.crdb == "0")
                        {
                            AddingMoney mpya = new AddingMoney();
                            mpya.addtocash = this;
                            mpya.frm = "crdb";
                            mpya.addchange = "change";
                            mpya.changeon();
                            mpya.ShowDialog();
                        }

                    }
                
            }
        }


        private void enableLogButtons()
        {

            if (Services.SelectedItem.ToString() == "AIRTEL MONEY")
            {
                AirtelMoneyButton.BackColor = Color.Transparent;
                AirtelMoneyButton.Enabled = true;
            }
            else if (Services.SelectedItem.ToString() == "EZY PESA")
            {
                EzyPesaButton.BackColor = Color.Transparent;
                EzyPesaButton.Enabled = true;
            }
            else if (Services.SelectedItem.ToString() == "TIGO PESA")
            {
                tigobutton.BackColor = Color.Transparent;
                tigobutton.Enabled = true;
            }
            else if (Services.SelectedItem.ToString() == "VODACOM M-PESA")
            {
                vodacombutton.BackColor = Color.Transparent;
                vodacombutton.Enabled = true;
            }
            else if (Services.SelectedItem.ToString() == "CRDB BANK")
            {
                CRDBBUTTON.BackColor = Color.Transparent;
                CRDBBUTTON.Enabled = true;
            }

        }

        private void searchlistbox()
        {
            // Set the search string:
            String searchString = "";
            searchString = Services.SelectedItem.ToString();
            // Search starting from index -1:
            int index = listBox1.FindString(searchString, -1);
            if (index != -1)
            {   //ItemFound AlreadyExist
                newitem = false;
            }
            else
            {
                newitem = true;
            }

        }


        //......................HOVER AND LEAVE!!...........................................
        private void AirtelMoneyButton_MouseHover(object sender, EventArgs e)
        {
            AirtelMoneyButton.BackColor = Color.DarkRed;


        }

        private void AirtelMoneyButton_MouseLeave(object sender, EventArgs e)
        {

            AirtelMoneyButton.BackColor = Color.Transparent;
        }




        private void LogsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vodacombutton_MouseHover(object sender, EventArgs e)
        {
            vodacombutton.BackColor = Color.DarkRed;
        }

        private void vodacombutton_MouseLeave(object sender, EventArgs e)
        {
            vodacombutton.BackColor = Color.Transparent;
        }

        private void EzyPesaButton_MouseHover(object sender, EventArgs e)
        {
            EzyPesaButton.BackColor = Color.DarkGreen;
        }

        private void EzyPesaButton_MouseLeave(object sender, EventArgs e)
        {
            EzyPesaButton.BackColor = Color.Transparent;
        }

        private void tigobutton_MouseHover(object sender, EventArgs e)
        {
            tigobutton.BackColor = Color.Orange;
        }

        private void tigobutton_MouseLeave(object sender, EventArgs e)
        {
            tigobutton.BackColor = Color.Transparent;
        }

        private void CRDBBUTTON_MouseHover(object sender, EventArgs e)
        {
            CRDBBUTTON.BackColor = Color.DarkGreen;
        }

        private void CRDBBUTTON_MouseLeave(object sender, EventArgs e)
        {
            CRDBBUTTON.BackColor = Color.Transparent;
        }



        // AddService...........................................................................
        private void serviceadding(string p)
        {
            XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

            XElement element =
                xmlDoc.Root.Elements("services").Where(r => (string)r.Element("mwanzo") == "1").FirstOrDefault();
            if (element != null)
            {
                switch (p)
                {

                    case "AIRTEL MONEY":
                        element.SetElementValue("airtel", "1");
                        break;

                    case "EZY PESA":
                        element.SetElementValue("zantel", "1");
                        break;

                    case "TIGO PESA":
                        element.SetElementValue("tigo", "1");
                        break;

                    case "VODACOM M-PESA":
                        element.SetElementValue("vodacom", "1");
                        break;

                    case "CRDB BANK":
                        element.SetElementValue("crdb", "1");
                        break;

                }
         }
            xmlDoc.Save("RuntimeData.xml");


        }

        private void availableservice()
        {
            


            XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in usersxml.Descendants("services")
                        select new
                        {

                            airtelz = usr.Element("airtel").Value,
                            vodacomz = usr.Element("vodacom").Value,
                            tigoz = usr.Element("tigo").Value,
                            zantelz = usr.Element("zantel").Value,
                            crdbz = usr.Element("crdb").Value,

                        };


            foreach (var use in users)
            {
                airtelm = int.Parse(use.airtelz);
                mpesa = int.Parse(use.vodacomz);
                tigop = int.Parse(use.tigoz);
                zanp = int.Parse(use.zantelz);
                crdbm = int.Parse(use.crdbz);
            }
            




            if (airtelm == 1)
            {
                listBox1.Items.Add("AIRTEL MONEY");
                AirtelMoneyButton.BackColor = Color.Transparent;
                AirtelMoneyButton.Enabled = true;
            }
            if (mpesa == 1)
            {
                listBox1.Items.Add("VODACOM M-PESA");
                vodacombutton.BackColor = Color.Transparent;
                vodacombutton.Enabled = true;
            }
            if (tigop == 1)
            {
                listBox1.Items.Add("TIGO PESA");
                tigobutton.BackColor = Color.Transparent;
                tigobutton.Enabled = true;
            }
            if (zanp == 1)
            {
                listBox1.Items.Add("EZY PESA");
                EzyPesaButton.BackColor = Color.Transparent;
                EzyPesaButton.Enabled = true;
                
            }
            if (crdbm == 1)
            {
                listBox1.Items.Add("CRDB BANK");
                CRDBBUTTON.BackColor = Color.Transparent;
                CRDBBUTTON.Enabled = true;
                
            }


        }
       
        public void openreport()
        {
            Report_Click(sender, e);
        }

        private void reportpanel_VisibleChanged(object sender, EventArgs e)
        {
            
            

            XDocument hela = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in hela.Descendants("settings")
                        select new
                        {

                            csh = usr.Element("cashIn").Value,
                            vodafl = usr.Element("mfloat").Value,
                            ezyfl = usr.Element("efloat").Value,
                            airtelfl = usr.Element("afloat").Value,
                            tigofl = usr.Element("tfloat").Value,
                            crdbfl = usr.Element("cfloat").Value
                        };


            foreach (var use in users)
            {

                airfloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.airtelfl, NumberStyles.AllowThousands));
                vodafloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.vodafl, NumberStyles.AllowThousands));
                ezyfloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.ezyfl, NumberStyles.AllowThousands));
                tigofloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.tigofl, NumberStyles.AllowThousands));
                crdbfloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.crdbfl, NumberStyles.AllowThousands));
                moneyxlabel.Text = string.Format("{0:#,###0.#}", int.Parse(use.csh, NumberStyles.AllowThousands));
               
            }
         //   load();

           

            
        }
       
        private void load() {

           





            XDocument hela = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in hela.Descendants("settings")
                        select new
                        {

                            csh = usr.Element("cashIn").Value,
                            vodafl = usr.Element("mfloat").Value,
                            ezyfl = usr.Element("efloat").Value,
                            airtelfl = usr.Element("afloat").Value,
                            tigofl = usr.Element("tfloat").Value,
                            crdbfl = usr.Element("cfloat").Value
                        };


            foreach (var use in users)
            {

                airfloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.airtelfl));
                vodafloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.vodafl));
                ezyfloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.ezyfl));
                tigofloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.tigofl));
                crdbfloatbox.Text = string.Format("{0:#,###0.#}", int.Parse(use.crdbfl));
                moneyxlabel.Text = string.Format("{0:#,###0.#}", int.Parse(use.csh));
            }




            //Databasecon datt = new Databasecon();
            //datt.selectdata("crdb");
            //max = datt.dates().Capacity-1;

            //crdbdatebox.Text = datt.dates()[max].ToString();
            //datt.selectdata("airtel");
            //max = 0;
            //max = datt.dates().Capacity - 1;
            //airdatebox.Text = datt.dates()[max].ToString();


            //datt.selectdata("ezypesa");
            //max = 0;
            //max = datt.dates().Capacity;
            //ezydatebox.Text = datt.dates()[max].ToString();

            //datt.selectdata("tigopesa");
            //max = 0;
            //max = datt.dates().Capacity - 1;
            //tigodatebox.Text = datt.dates()[max].ToString();

            //datt.selectdata("mpesa");
            //max = 0;
            //max = datt.dates().Capacity - 1;
            //vodadatebox.Text = datt.dates()[max].ToString();
          
            
           
      
        
        
        
        
        
        }


        private void addcashb_Click(object sender, EventArgs e)
        {
            AddingMoney cashb = new AddingMoney();
            cashb.addtocash = this;
            cashb.frm = "cash";
            cashb.addchange = "add";
            
            cashb.ShowDialog();
        }

        private void AddChange_Click(object sender, EventArgs e)
        {
            addhistory history = new addhistory();
            history.balancereport = this;
            history.ShowDialog();

        }

        public void refreshreport()
        {
            reportpanel.Visible = false;
            reportpanel.Visible = true;
        }

        

        
    }
}
