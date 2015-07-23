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
    public partial class Tigo_Pesa : Form
    {
        public HomeMenu tigotohome;
        public EntryForm tigoform;
        private const int CP_NOCLOSE_BUTTON = 0x200;//for the close (x)
        private Databasecon dr;
        public Tigo_Pesa()
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
        private void BackButton_Click(object sender, EventArgs e)
        {
            tigotohome.setVisibility("on");
            this.Close();
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            tigotohome.setVisibility("on");
            this.Close();
        }

        private void NewEntry_Click_1(object sender, EventArgs e)
        {
            tigoform = new EntryForm();
            tigoform.formtotigo = this;
            tigoform.setBelonging("tigo");
            tigoform.ShowDialog();

        }

        private void Tigo_Pesa_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata() {


            int i;
            int a = 1;

            try
            {

                dr.selectdata("tigopesa");
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
                    TigoListView.Items.Add(datas);



                    




                }

            }
            catch (Exception e)
            {

                MessageBox.Show("-->" + e);
            }


        
        
        
        
        }

        private void Report_Click(object sender, EventArgs e)
        {
            tigotohome.setVisibility("on");
            tigotohome.openreport();
            this.Close();
        }

        private void addfloatvoda_Click(object sender, EventArgs e)
        {
            AddingMoney tigo = new AddingMoney();
            tigo.addtotigo = this;
            tigo.frm = "tigo";
            tigo.addchange = "add";
            tigo.addon();
            tigo.ShowDialog();
        }

        private void Tigo_Pesa_Activated(object sender, EventArgs e)
        {
            for (int i = TigoListView.Items.Count - 1; i >= 0; i--)
            { TigoListView.Items[i].Remove(); }
            loaddata();
        }
    }
}
