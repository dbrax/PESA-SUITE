using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.ComponentModel;

namespace AccessPesa
{


    class BussinessLogic
    {
        private float TransVal;
        private String log;
        private String cash;
        private float cashIn;
        private String floatBlnc;
        private float Blnc;
        public BussinessLogic()
        { 
        
        }

        public float pokea(float TransValue,String lg) {
            this.log = lg;

            if (log == "mpesa")
            {
                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                             {
                                 MpesaFloat = usr.Element("mfloat").Value,
                                 cashInHand = usr.Element("cashIn").Value

                             };

           
                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                   }
                //end of selecting

         

                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc)< 20000  ) {
                    MessageBox.Show("your float balance is low please change it soon");
                
                
                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if(float.Parse(floatBlnc)>500 ){
                //update value here

                     Blnc =float.Parse(floatBlnc) - TransVal;
                     this.cashIn = float.Parse(cash) + TransVal;
                XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");
              
                XElement element =
                    xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("mfloat") == floatBlnc).FirstOrDefault();
                if (element != null)
                {




                    element.SetElementValue("mfloat",Blnc.ToString());
                    element.SetElementValue("cashIn", cashIn.ToString());
                




                }

                xmlDoc.Save("RuntimeData.xml");
                

                }
                else{

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }  //tigo begins here you can comment from here
            else if (log == "tigopesa")
            {
                MessageBox.Show(log);
                
                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("tfloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) - TransVal;
                    this.cashIn = float.Parse(cash) + TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("tfloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {


                        element.SetElementValue("tfloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());


                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }//ezypesa begins here
            else if (log == "ezypesa")
            {
                MessageBox.Show(log);

                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("efloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) - TransVal;
                    this.cashIn = float.Parse(cash) + TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("efloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("efloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }//crdb entry begins here

            else if (log == "crdb")
            {
                MessageBox.Show(log);

                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("cfloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) - TransVal;
                    this.cashIn = float.Parse(cash) + TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("cfloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("cfloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }//airtel

            else if (log == "airtel")
            {
                MessageBox.Show(log);

                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("afloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) - TransVal;
                    this.cashIn = float.Parse(cash) + TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("afloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("afloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }

        return Blnc;
        }
        public float Toa(float TransValue, String lg)
        {
            this.log = lg;

            if (log == "mpesa")
            {
                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("mfloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) + TransVal;
                    this.cashIn = float.Parse(cash) - TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("mfloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("mfloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }  //tigo begins here you can comment from here
            else if (log == "tigopesa")
            {
                MessageBox.Show(log);

                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("tfloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) +TransVal;
                    this.cashIn = float.Parse(cash) - TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("tfloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("tfloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }//ezypesa begins here
            else if (log == "ezypesa")
            {
                MessageBox.Show(log);

                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("efloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) + TransVal;
                    this.cashIn = float.Parse(cash) - TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("efloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("efloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }//crdb entry begins here

            else if (log == "crdb")
            {
                MessageBox.Show(log);

                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("cfloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) + TransVal;
                    this.cashIn = float.Parse(cash) - TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("cfloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("cfloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }//airtel

            else if (log == "airtel")
            {
                MessageBox.Show(log);

                this.TransVal = TransValue;
                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {
                                MpesaFloat = usr.Element("afloat").Value,
                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                    cash = use.cashInHand;
                    floatBlnc = use.MpesaFloat;
                }
                //end of selecting



                if (float.Parse(floatBlnc) > 5000 && float.Parse(floatBlnc) < 20000)
                {
                    MessageBox.Show("your float balance is low please change it soon");


                }

                if (float.Parse(floatBlnc) > 1000 && float.Parse(floatBlnc) < 5000)
                {
                    MessageBox.Show("your float balance is very low please change it soon");


                }
                if (float.Parse(floatBlnc) > 500)
                {
                    //update value here

                    Blnc = float.Parse(floatBlnc) + TransVal;
                    this.cashIn = float.Parse(cash) - TransVal;
                    XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

                    XElement element =
                        xmlDoc.Root.Elements("settings").Where(r => (string)r.Element("afloat") == floatBlnc).FirstOrDefault();
                    if (element != null)
                    {




                        element.SetElementValue("afloat", Blnc.ToString());
                        element.SetElementValue("cashIn", cashIn.ToString());





                    }

                    xmlDoc.Save("RuntimeData.xml");


                }
                else
                {

                    MessageBox.Show("Sorry your funds are not enough to perform this transaction");
                }
            }

            return Blnc;
        }

        //public void checkFloat(String log) {

        //    this.log = log;



        //    if (log == "mpesa")
        //    {

        //        XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

        //        var users = from usr in usersxml.Descendants("settings")
        //                    select new
        //                    {
        //                        MpesaFloat = usr.Element("mfloat").Value

        //                    };


        //        foreach (var use in users)
        //        {


        //            floatBlnc = use.MpesaFloat;
        //        }


        //        Blnc = float.Parse(floatBlnc);
        //        if (Blnc < 10000) { MessageBox.Show("your float balance is low please change it "); }

        //    }
        //}

        public float getCash() {
           
            XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in usersxml.Descendants("settings")
                        select new
                        {
                           
                            cashInHand = usr.Element("cashIn").Value

                        };


            foreach (var use in users)
            {

                cash = use.cashInHand;
               
            }
            this.cashIn = float.Parse(cash);
            return cashIn;
        }


        public void checkCash()
        {





                XDocument usersxml = XDocument.Load(@"RuntimeData.xml");

                var users = from usr in usersxml.Descendants("settings")
                            select new
                            {

                                cashInHand = usr.Element("cashIn").Value

                            };


                foreach (var use in users)
                {

                       cash= use.cashInHand;
                }
                

                cashIn = float.Parse(cash);
                if (cashIn < 10000) { MessageBox.Show("your cash balance is low please add your cash balance "); }

          //end of checkcash function
        }
      


    }
}
