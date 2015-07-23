using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessPesa
{
    public partial class Vodacom_Mpesa : Form
    {
        public HomeMenu vodatohome;
        public EntryForm vodaform;
       private  Databasecon db;
        private const int CP_NOCLOSE_BUTTON = 0x200;//for the close (x)

        public Vodacom_Mpesa()
        {
          db = new Databasecon();
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
        private void BackButton_Click(object sender, EventArgs e)
        {
            vodatohome.setVisibility("on");
            this.Close();

        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            vodaform = new EntryForm();
            vodaform.formtovoda = this;
            vodaform.setBelonging("voda");
            vodaform.ShowDialog();
            
           // VodacomListView.Clear();
            //loaddata();
        }

        private void Vodacom_Mpesa_Load(object sender, EventArgs e)
        {
            
            loaddata();
            
           
            
        }
    
        private void loaddata() 
        {
            int i;
            int a=1;

            try
            {
               
                db.selectdata("mpesa");
               // MessageBox.Show(db.TransactionId().Count.ToString());
                for (i = 0; i < db.TransactionId().Count; i++)
                {
                    ListViewItem datas = new ListViewItem(a++.ToString());
                    datas.SubItems.Add(db.dates()[i].ToString());
                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(db.cashIn()[i].ToString())));

                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(db.Balance()[i].ToString())));
                    datas.SubItems.Add(db.TransactionId()[i].ToString());
                    datas.SubItems.Add(db.transactiontype()[i].ToString());
                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(db.Transaction_value()[i].ToString())));
                    datas.SubItems.Add(db.Cutomername()[i].ToString());
                    datas.SubItems.Add(db.customerphoneno()[i].ToString());
                    datas.SubItems.Add(db.customeridtype()[i].ToString());
                    datas.SubItems.Add(db.customerId()[i].ToString());
                    VodacomListView.Items.Add(datas);

                }

            }
            catch(Exception e){

                MessageBox.Show("-->"+e );
            }
          

        
        }

        private void Vodacom_Mpesa_Activated(object sender, EventArgs e)
        {
            for (int i = VodacomListView.Items.Count - 1; i >= 0; i--)
            { VodacomListView.Items[i].Remove(); }
            loaddata();
            
        }

        private void Vodacom_Mpesa_Enter(object sender, EventArgs e)
        {
            
            
        }
        public void reload()
        {
            //VodacomListView.Clear();
            //loaddata();
        }

        private void VodacomListView_Validated(object sender, EventArgs e)
        {
            

        }

        private void VodacomListView_Enter(object sender, EventArgs e)
        {
           

        }
        
        public void setvisible()
        {
            VodacomListView.Visible = true;
        }
        
        private void VodacomListView_VisibleChanged(object sender, EventArgs e)
        {
            BussinessLogic checkMpesa = new BussinessLogic();
            checkMpesa.checkCash();

        }

        private void VodacomListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {
            vodatohome.setVisibility("on");
            vodatohome.openreport();
            this.Close();
        }

        private void lastcall()
        {
            
        
        
        }

        private void addfloatvoda_Click(object sender, EventArgs e)
        {
            AddingMoney voda = new AddingMoney();
            voda.addtovoda = this;
            voda.frm = "voda";
            voda.addchange = "add";
           // voda.addon();
            voda.ShowDialog();
        }

        

    }
}
