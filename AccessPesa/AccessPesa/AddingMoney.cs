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
    public partial class AddingMoney : Form
    {
        public string addchange = "";
        public HomeMenu addtocash;
        public Airtel_Money addtoairtel;
        public Ezy_Pesa addtoezy;
        public Tigo_Pesa addtotigo;
        public CRDB_Bank addtocrdb;
        public Vodacom_Mpesa addtovoda;
        public String frm;
        private int floatblnc;
        private int newbalance = 0;
        public AddingMoney()
        {
            InitializeComponent();
        }

        private void AddingFloat_Load(object sender, EventArgs e)
        {


            if (addchange == "add")
            {
                addon();
            load();
            }
            else if (addchange == "change")
            {
                changeon();
                hela.Visible = false;
            loadc();
            }





        }

        private void load()
        {


            XDocument mulla = XDocument.Load(@"RuntimeData.xml");
            switch (frm)
            {


                case "airtel":
                    this.BackColor = Color.DarkRed;
                    floatlabel.Text = "AIRTEL MONEY FLOAT BALANCE";
                    var user1 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("afloat").Value,

                                };
                    foreach (var use in user1)
                    {

                        hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                    }
                    break;
                case "ezy":
                    this.BackColor = Color.DarkGreen;
                    floatlabel.Text = "EZYPESA FLOAT BALANCE";
                    var user2 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("efloat").Value,

                                };
                    foreach (var use in user2)
                    {

                        hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                    }
                    break;
                case "tigo":
                    this.BackColor = Color.SteelBlue;
                    floatlabel.Text = "TIGO PESA FLOAT BALANCE";
                    var user3 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("tfloat").Value,

                                };
                    foreach (var use in user3)
                    {

                        hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                    }
                    break;
                case "voda":
                    this.BackColor = Color.DarkRed;
                    floatlabel.Text = "VODACOM M-PESA FLOAT BALANCE";
                    var user4 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("mfloat").Value,

                                };
                    foreach (var use in user4)
                    {

                        hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + " Tshs.  +";
                    }
                    break;
                case "crdb":
                    this.BackColor = Color.SeaGreen;
                    floatlabel.Text = "CRDB BANK FLOAT BALANCE";
                    var user5 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("cfloat").Value,

                                };
                    foreach (var use in user5)
                    {

                        hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                    }

                    break;
                case "cash":
                    this.BackColor = Color.Maroon;
                    floatlabel.Text = "ADD CASH BALANCE";
                    var user6 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("cashIn").Value,

                                };
                    foreach (var use in user6)
                    {

                        hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                    }

                    break;

            }



        }

        private void loadc()
        {


            XDocument mulla = XDocument.Load(@"RuntimeData.xml");
            switch (frm)
            {


                case "airtel":
                    this.BackColor = Color.DarkRed;
                    floatlabel.Text = "AIRTEL MONEY FLOAT BALANCE";
                    var user1 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("afloat").Value,

                                };
                    foreach (var use in user1)
                    {

                        Changetext.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl));
                    }
                    break;
                case "ezy":
                    this.BackColor = Color.DarkGreen;
                    floatlabel.Text = "EZYPESA FLOAT BALANCE";
                    var user2 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("efloat").Value,

                                };
                    foreach (var use in user2)
                    {

                        Changetext.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl));
                    }
                    break;
                case "tigo":
                    this.BackColor = Color.SteelBlue;
                    floatlabel.Text = "TIGO PESA FLOAT BALANCE";
                    var user3 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("tfloat").Value,

                                };
                    foreach (var use in user3)
                    {

                        hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                    }
                    break;
                case "voda":
                    this.BackColor = Color.DarkRed;
                    floatlabel.Text = "VODACOM M-PESA FLOAT BALANCE";
                    var user4 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("mfloat").Value,

                                };
                    foreach (var use in user4)
                    {

                        Changetext.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl));
                    }
                    break;
                case "crdb":
                    this.BackColor = Color.SeaGreen;
                    floatlabel.Text = "CRDB BANK FLOAT BALANCE";
                    var user5 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("cfloat").Value,

                                };
                    foreach (var use in user5)
                    {

                        Changetext.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl));
                    }

                    break;
                case "cash":
                    this.BackColor = Color.Maroon;
                    floatlabel.Text = "CASH BALANCE";
                    var user6 = from usr in mulla.Descendants("settings")
                                select new
                                {

                                    labl = usr.Element("cashIn").Value,

                                };
                    foreach (var use in user6)
                    {

                        Changetext.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl));
                    }

                    break;

            }



        }

        private void back_Click(object sender, EventArgs e)
        {
            if (addchange == "change")
            {
                addtocash.added = false;
            }
                this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("please input your new balance");
                newbalance = floatblnc + 0;
            }

            else
            {
                int a;
                bool isNumeric = int.TryParse(input.Text, out a);


                if (isNumeric == false)
                {

                    MessageBox.Show("Number invalid");

                }

                else
                {
                    XDocument mulla = XDocument.Load(@"RuntimeData.xml");
                    switch (frm)
                    {


                        case "airtel":

                            var user1 = from usr in mulla.Descendants("settings")
                                        select new
                                        {

                                            labl = usr.Element("afloat").Value,

                                        };
                            foreach (var use in user1)
                            {
                                floatblnc = int.Parse(use.labl);

                            }

                            newbalance = floatblnc + int.Parse(input.Text);
                            DialogResult dr = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (dr == DialogResult.Yes)
                            {
                                XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                XElement element =
                                  Doc.Root.Elements("settings").Where(r => (string)r.Element("afloat") == floatblnc.ToString()).FirstOrDefault();
                                if (element != null)
                                {

                                    element.SetElementValue("afloat", newbalance.ToString());
                                    //    element.SetElementValue("cashIn", cashIn.ToString());


                                }

                                Doc.Save("RuntimeData.xml");
                                load();
                            }
                            else
                            {
                                Close();
                            }
                            break;

                        case "ezy":
                            this.BackColor = Color.DarkGreen;
                            floatlabel.Text = "EZYPESA FLOAT BALANCE";
                            var user2 = from usr in mulla.Descendants("settings")
                                        select new
                                        {
                                            labl = usr.Element("efloat").Value,
                                        };
                            foreach (var use in user2)
                            {
                                floatblnc = int.Parse(use.labl);
                                // hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                            }
                            // newbalance = 0;
                            //input.Text = newbalance.ToString();
                            if (input.Text != "")
                                newbalance = floatblnc + int.Parse(input.Text);
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }

                            DialogResult de = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (de == DialogResult.Yes)
                            {
                                XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                XElement element =
                                  Doc.Root.Elements("settings").Where(r => (string)r.Element("efloat") == floatblnc.ToString()).FirstOrDefault();
                                if (element != null)
                                {
                                    element.SetElementValue("efloat", newbalance.ToString());
                                    //    element.SetElementValue("cashIn", cashIn.ToString());
                                }

                                Doc.Save("RuntimeData.xml");
                                load();
                            }
                            else
                            {

                                Close();
                            }
                            break;

                        case "tigo":


                            var user3 = from usr in mulla.Descendants("settings")
                                        select new
                                        {

                                            labl = usr.Element("tfloat").Value,

                                        };
                            foreach (var use in user3)
                            {
                                floatblnc = int.Parse(use.labl);
                                // hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                            }
                            // newbalance = 0;
                            //input.Text = newbalance.ToString();
                            if (input.Text != "")
                                newbalance = floatblnc + int.Parse(input.Text);
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }

                            DialogResult dt = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (dt == DialogResult.Yes)
                            {
                                XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                XElement element =
                                  Doc.Root.Elements("settings").Where(r => (string)r.Element("tfloat") == floatblnc.ToString()).FirstOrDefault();
                                if (element != null)
                                {

                                    element.SetElementValue("tfloat", newbalance.ToString());
                                    //    element.SetElementValue("cashIn", cashIn.ToString());
                                }

                                Doc.Save("RuntimeData.xml");
                                load();
                            }
                            else
                            {

                                Close();
                            }
                            break;
                        case "voda":

                            var user4 = from usr in mulla.Descendants("settings")
                                        select new
                                        {

                                            labl = usr.Element("mfloat").Value,

                                        };
                            foreach (var use in user4)
                            {
                                floatblnc = int.Parse(use.labl);
                                // hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                            }
                            // newbalance = 0;
                            //input.Text = newbalance.ToString();
                            if (input.Text != "")
                                newbalance = floatblnc + int.Parse(input.Text);
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }

                            DialogResult dv = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (dv == DialogResult.Yes)
                            {
                                XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                XElement element =
                                  Doc.Root.Elements("settings").Where(r => (string)r.Element("mfloat") == floatblnc.ToString()).FirstOrDefault();
                                if (element != null)
                                {
                                    element.SetElementValue("mfloat", newbalance.ToString());
                                    //    element.SetElementValue("cashIn", cashIn.ToString());
                                }

                                Doc.Save("RuntimeData.xml");
                                load();
                            }
                            else
                            {

                                //Close();
                            }



                            break;
                        case "crdb":

                            var user5 = from usr in mulla.Descendants("settings")
                                        select new
                                        {

                                            labl = usr.Element("cfloat").Value,

                                        };
                            foreach (var use in user5)
                            {
                                floatblnc = int.Parse(use.labl);
                                // hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                            }
                            // newbalance = 0;
                            //input.Text = newbalance.ToString();
                            if (input.Text != "")
                                newbalance = floatblnc + int.Parse(input.Text);
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }

                            DialogResult dc = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (dc == DialogResult.Yes)
                            {
                                XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                XElement element =
                                  Doc.Root.Elements("settings").Where(r => (string)r.Element("cfloat") == floatblnc.ToString()).FirstOrDefault();
                                if (element != null)
                                {

                                    element.SetElementValue("cfloat", newbalance.ToString());
                                    //    element.SetElementValue("cashIn", cashIn.ToString());

                                }

                                Doc.Save("RuntimeData.xml");
                                load();
                            }
                            else
                            {

                                //Close();
                            }

                            break;
                        case "cash":

                            var user6 = from usr in mulla.Descendants("settings")
                                        select new
                                        {

                                            labl = usr.Element("cashIn").Value,

                                        };
                            foreach (var use in user6)
                            {
                                floatblnc = int.Parse(use.labl);
                                // hela.Text = string.Format("{0:#,###0.#}", int.Parse(use.labl)) + "Tshs.  +";
                            }
                            // newbalance = 0;
                            //input.Text = newbalance.ToString();
                            if (input.Text != "")
                                newbalance = floatblnc + int.Parse(input.Text);
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }

                            DialogResult da = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (da == DialogResult.Yes)
                            {
                                XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                XElement element =
                                  Doc.Root.Elements("settings").Where(r => (string)r.Element("cashIn") == floatblnc.ToString()).FirstOrDefault();
                                if (element != null)
                                {

                                    element.SetElementValue("cashIn", newbalance.ToString());
                                    //    element.SetElementValue("cashIn", cashIn.ToString());
                                }

                                Doc.Save("RuntimeData.xml");
                                load();
                                addtocash.refreshreport();
                            }
                            else
                            {

                                //Close();
                            }
                            break;

                    }
                }
            }


        }

        public void addon()
        {
            add.Visible = true;
            change.Visible = false;
            hela.Visible = true;
            input.Visible = true;
            Changetext.Visible = false;
        }

        public void changeon()
        {
            add.Visible = false;
            change.Visible = true;
            hela.Visible = false;
            input.Visible = false;
            Changetext.Visible = true;
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (Changetext.Text == "" || int.Parse(Changetext.Text, NumberStyles.AllowThousands) <= 0)
            {
                MessageBox.Show("please input your new balance");
                newbalance = floatblnc + 0;
                addtocash.added = false;
            }

            else
            {
                int a;
                bool isNumeric = int.TryParse(Changetext.Text, out a);


                if (isNumeric == false)
                {

                    MessageBox.Show("Number invalid");

                }

                else
                {
                    XDocument mulla = XDocument.Load(@"RuntimeData.xml");
                    switch (frm)
                    {


                        case "airtel":


                            if (Changetext.Text != "")
                            {
                                newbalance = int.Parse(Changetext.Text, NumberStyles.AllowThousands);
                                DialogResult dr = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                                if (dr == DialogResult.Yes)
                                {
                                    XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                    XElement element =
                                      Doc.Root.Elements("settings").Where(r => (string)r.Element("afloat") == floatblnc.ToString()).FirstOrDefault();
                                    if (element != null)
                                    {

                                        element.SetElementValue("afloat", int.Parse(newbalance.ToString()));
                                        //    element.SetElementValue("cashIn", cashIn.ToString());

                                    }

                                    Doc.Save("RuntimeData.xml");
                                    addtocash.added = true;
                                    this.Close();
                                }
                                else
                                {
                                    //Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }

                            break;

                        case "ezy":

                            if (Changetext.Text != "")
                            {
                                newbalance = int.Parse(Changetext.Text, NumberStyles.AllowThousands);

                                DialogResult de = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Airtel floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                                if (de == DialogResult.Yes)
                                {
                                    XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                    XElement element =
                                      Doc.Root.Elements("settings").Where(r => (string)r.Element("efloat") == floatblnc.ToString()).FirstOrDefault();
                                    if (element != null)
                                    {

                                        element.SetElementValue("efloat", int.Parse(newbalance.ToString()));

                                    }

                                    Doc.Save("RuntimeData.xml");
                                    addtocash.added = true;
                                    this.Close();
                                }
                                else
                                { Close(); }
                            }

                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }


                            break;

                        case "tigo":

                            if (Changetext.Text != "")
                            {
                                newbalance = int.Parse(Changetext.Text, NumberStyles.AllowThousands);

                                DialogResult dt = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Tigo floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                                if (dt == DialogResult.Yes)
                                {
                                    XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                    XElement element =
                                      Doc.Root.Elements("settings").Where(r => (string)r.Element("tfloat") == floatblnc.ToString()).FirstOrDefault();
                                    if (element != null)
                                    {
                                        element.SetElementValue("tfloat", int.Parse(newbalance.ToString()));
                                    }

                                    Doc.Save("RuntimeData.xml");

                                    addtocash.added = true;
                                    this.Close();
                                }
                                else
                                {
                                    //Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }


                            break;
                        case "voda":

                            if (Changetext.Text != "")
                            {
                                newbalance = int.Parse(Changetext.Text, NumberStyles.AllowThousands);

                                DialogResult dv = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Vodacom floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                                if (dv == DialogResult.Yes)
                                {
                                    XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                    XElement element =
                                      Doc.Root.Elements("settings").Where(r => (string)r.Element("mfloat") == floatblnc.ToString()).FirstOrDefault();
                                    if (element != null)
                                    {
                                        element.SetElementValue("mfloat", int.Parse(newbalance.ToString()));

                                    }

                                    Doc.Save("RuntimeData.xml");
                                    addtocash.added = true;
                                    this.Close();
                                }
                                else
                                {
                                    //Close();
                                }
                            }

                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }


                            break;
                        case "crdb":

                            if (Changetext.Text != "")
                            {
                                newbalance = int.Parse(Changetext.Text, NumberStyles.AllowThousands);
                                DialogResult dc = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "CRDB floatbalance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                                if (dc == DialogResult.Yes)
                                {
                                    XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                    XElement element =
                                      Doc.Root.Elements("settings").Where(r => (string)r.Element("cfloat") == floatblnc.ToString()).FirstOrDefault();
                                    if (element != null)
                                    {
                                        element.SetElementValue("cfloat", int.Parse(newbalance.ToString()));
                                    }

                                    Doc.Save("RuntimeData.xml");
                                    addtocash.added = true;
                                    this.Close();
                                }
                                else
                                {

                                    //Close();
                                }

                            }
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }



                            break;
                        case "cash":

                            if (Changetext.Text != "")
                            {
                                newbalance = int.Parse(Changetext.Text, NumberStyles.AllowThousands);
                                DialogResult da = MessageBox.Show("the new floatbalance is " + newbalance.ToString() + "would you like change", "Cash balance", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                                if (da == DialogResult.Yes)
                                {
                                    XDocument Doc = XDocument.Load(@"RuntimeData.xml");

                                    XElement element =
                                      Doc.Root.Elements("settings").Where(r => (string)r.Element("cashIn") == floatblnc.ToString()).FirstOrDefault();
                                    if (element != null)
                                    {
                                        element.SetElementValue("cashIn", string.Format("{0:#,###0.#}", int.Parse(newbalance.ToString())));


                                    }

                                    Doc.Save("RuntimeData.xml");
                                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                                    XElement eelement =
                                        xmlDoc.Root.Elements("services").Where(r => (string)r.Element("mwanzo") == "0").FirstOrDefault();
                                    if (element != null)
                                    {

                                        eelement.SetElementValue("mwanzo", "1");
                                    }


                                    xmlDoc.Save("RuntimeData.xml");
                                    addtocash.refreshreport();
                                }
                                else
                                {

                                    //Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("please input your new balance");
                                newbalance = floatblnc + 0;
                            }


                            break;
                    }
                }
            }
        }
    }
}
