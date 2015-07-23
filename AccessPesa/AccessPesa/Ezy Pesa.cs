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
    public partial class Ezy_Pesa : Form
    {
        public HomeMenu ezytohome;
        public EntryForm ezyform;
        private const int CP_NOCLOSE_BUTTON = 0x200;//for the close (x)

        private Databasecon de;
       
        public Ezy_Pesa()
        {
            de = new Databasecon();
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
            ezytohome.setVisibility("on");
            this.Close();
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            ezyform = new EntryForm();
            ezyform.formtoezy = this;
            ezyform.setBelonging("ezy");
            ezyform.ShowDialog();
        }

        private void Ezy_Pesa_Load(object sender, EventArgs e)
        {
            
            //loaddata();
        }

        private void loaddata() {
            

            int i;
            int a = 1;

            try
            {

                de.selectdata("ezypesa");
                //MessageBox.Show(dr.TransactionId().Count.ToString());
                for (i = 0; i < de.TransactionId().Count; i++)
                {
                    ListViewItem datas = new ListViewItem(a++.ToString());
                    datas.SubItems.Add(de.dates()[i].ToString());
                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(de.cashIn()[i].ToString())));

                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(de.Balance()[i].ToString())));
                    datas.SubItems.Add(de.TransactionId()[i].ToString());
                    datas.SubItems.Add(de.transactiontype()[i].ToString());
                    datas.SubItems.Add(string.Format("{0:#,###0.#}", int.Parse(de.Transaction_value()[i].ToString())));
                    datas.SubItems.Add(de.Cutomername()[i].ToString());
                    datas.SubItems.Add(de.customerphoneno()[i].ToString());
                    datas.SubItems.Add(de.customeridtype()[i].ToString());
                    datas.SubItems.Add(de.customerId()[i].ToString());
                   EzyPesaListView.Items.Add(datas);

                }

            }
            catch (Exception e)
            {

                MessageBox.Show("-->" + e);
            }




        
        
        
        
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ezytohome.setVisibility("on");
            ezytohome.openreport();
            this.Close();
        }

        private void addfloatvoda_Click(object sender, EventArgs e)
        {
            AddingMoney ezypesa = new AddingMoney();
            ezypesa.addtoezy = this;
            ezypesa.frm = "ezy";
            ezypesa.addchange = "add";
            ezypesa.addon();
            ezypesa.ShowDialog();
        }

        private void ReloadBttn_Click(object sender, EventArgs e)
        {
            EzyPesaListView.Clear();
              loaddata();
        }

        private void Ezy_Pesa_Activated(object sender, EventArgs e)
        {
           // EzyPesaListView.Clear();
            for (int i = EzyPesaListView.Items.Count - 1; i >= 0; i--)
            { EzyPesaListView.Items[i].Remove(); }
                loaddata();
        }

       



    }
}
