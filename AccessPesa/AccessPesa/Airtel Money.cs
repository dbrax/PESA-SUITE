using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AccessPesa
{
    public partial class Airtel_Money : Form
    {
        public HomeMenu airteltohome;
        public Ezy_Pesa ezy;
        public Vodacom_Mpesa voda;
        public CRDB_Bank crdb;
        public EntryForm airtelform;
        private const int CP_NOCLOSE_BUTTON = 0x200;//for the close (x)
        private Databasecon dr;
        public Airtel_Money()
        {
            
            InitializeComponent();
            dr = new Databasecon();
        }
        //Closes the (x)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void Airtel_Money_Activated(object sender, EventArgs e)
        {
            //airteltohome.setVisibility("off");
            for (int i = AirtelListView.Items.Count - 1; i >= 0; i--)
            { AirtelListView.Items[i].Remove(); }
            loaddata();
            //Connect to Database(Load from it)
        }

        private void loaddata()
        {


            int i;
            int a = 1;

            try
            {

                dr.selectdata("airtel");
                //MessageBox.Show(dr.TransactionId().Count.ToString());
                for (i = 0; i < dr.TransactionId().Count; i++)
                {
                    ListViewItem datas = new ListViewItem(a++.ToString());
                    datas.SubItems.Add(dr.dates()[i].ToString());
                    datas.SubItems.Add(dr.cashIn()[i].ToString());

                    datas.SubItems.Add(dr.Balance()[i].ToString());
                    datas.SubItems.Add(dr.TransactionId()[i].ToString());
                    datas.SubItems.Add(dr.transactiontype()[i].ToString());
                    datas.SubItems.Add(dr.Transaction_value()[i].ToString());
                    datas.SubItems.Add(dr.Cutomername()[i].ToString());
                    datas.SubItems.Add(dr.customerphoneno()[i].ToString());
                    datas.SubItems.Add(dr.customeridtype()[i].ToString());
                    datas.SubItems.Add(dr.customerId()[i].ToString());
                    AirtelListView.Items.Add(datas);

                }

            }
            catch (Exception e)
            {

                MessageBox.Show("-->" + e);
            }






        }
        


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void BackButton_Click(object sender, EventArgs e)
        {
            airteltohome.setVisibility("on");
            this.Close();
       
        }

        private void CrdbBank_Click(object sender, EventArgs e)
        {
            crdb = new CRDB_Bank();
            crdb.airtel = this;
            crdb.Show();
            this.Close();
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            airtelform = new EntryForm();
            airtelform.formtoairtel = this;
            airtelform.setBelonging("airtel");
            airtelform.ShowDialog();
        }

        private void EzyPesaButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            airteltohome.setVisibility("on");
            airteltohome.openreport();
            this.Close();
        }

        private void addfloatairtel_Click(object sender, EventArgs e)
        {
            AddingMoney airtl = new AddingMoney();
            airtl.addtoairtel = this;
            airtl.frm = "airtel";
            airtl.addchange = "add";
           // airtl.addon();
            airtl.ShowDialog();
        }

        

       /* private void BackButton_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }*/
    }
}
