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
    public partial class CRDB_Bank : Form
    {
        public HomeMenu home;
        public Airtel_Money airtel;
        public EntryForm crdbform;

        private Databasecon  dr;
        private const int CP_NOCLOSE_BUTTON = 0x200;//for the close (x)
        public CRDB_Bank()
        {
            dr = new Databasecon();
            InitializeComponent();
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
        private void CRDB_Bank_Load(object sender, EventArgs e)
        {
            //connect to database
            loaddata();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loaddata()
        {
            int i;
            int a = 1;

            try
            {

                dr.selectdata("crdb");
                //MessageBox.Show(dr.TransactionId().Count.ToString());
                for (i = 0; i < dr.TransactionId().Count; i++)
                {
                    ListViewItem datas = new ListViewItem(a++.ToString());
                    datas.SubItems.Add(dr.dates()[i].ToString());
                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(dr.cashIn()[i].ToString())));

                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(dr.Balance()[i].ToString())));
                    datas.SubItems.Add(dr.TransactionId()[i].ToString());
                    datas.SubItems.Add(dr.transactiontype()[i].ToString());
                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(dr.Transaction_value()[i].ToString())));
                    datas.SubItems.Add(dr.Cutomername()[i].ToString());
                    datas.SubItems.Add(dr.customerphoneno()[i].ToString());
                    datas.SubItems.Add(dr.customeridtype()[i].ToString());
                    datas.SubItems.Add(dr.customerId()[i].ToString());
                    CrdbListView.Items.Add(datas);

                }

            }
            catch (Exception e)
            {

                MessageBox.Show("-->" + e);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            //home = new HomeMenu();
           // home.Visible = true;
            
            home.setVisibility("on");
            this.Close();
        }

        private void AirtelMoney_Click(object sender, EventArgs e)
        {
            home.airtel = new Airtel_Money();
            //home.airtel.home.Visible = false;
            //airtel = new Airtel_Money();
            //home.airtel.crdb = this;
            home.airtel.Show();
            
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EzyPesa_Click(object sender, EventArgs e)
        {

        }

        private void TigoPesa_Click(object sender, EventArgs e)
        {

        }

        private void VodacomMpesa_Click(object sender, EventArgs e)
        {

        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            crdbform = new EntryForm();
            crdbform.formtocrdb = this;
            crdbform.setBelonging("crdb");
            crdbform.ShowDialog();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            home.setVisibility("on");
            home.openreport();
            this.Close();
        }

        private void addfloatvoda_Click(object sender, EventArgs e)
        {
            AddingMoney crdb = new AddingMoney();
            crdb.addtocrdb = this;
            crdb.frm = "crdb";
            crdb.addchange = "add";
           // crdb.addon();
            crdb.ShowDialog();
        }

        private void CRDB_Bank_Activated(object sender, EventArgs e)
        {
            for (int i = CrdbListView.Items.Count - 1; i >= 0; i--)
            { CrdbListView.Items[i].Remove(); }
            loaddata();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

     
    }
}
