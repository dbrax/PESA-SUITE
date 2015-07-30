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
    class DateServices
    {




        private DateTime releaseday, installdate, lactve;
       private  DateTime latestdate = DateTime.Now;

        int trialcount;

        public void getdatedata()
        {
            XDocument datexml = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in datexml.Descendants("config")
                        select new
                        {

                            release = usr.Element("releasedate").Value,
                            instalation = usr.Element("installdate").Value,
                            counting = usr.Element("trialcounter").Value
                        };


            foreach (var use in users)
            {

                releaseday = Convert.ToDateTime(use.release);
                installdate = Convert.ToDateTime(use.instalation);
                trialcount = int.Parse(use.counting);

            }

        }


        public void checkValidDate()
        {//latest date vs Release Date
            
           
           

            TimeSpan difference = latestdate - releaseday;
            MessageBox.Show(Math.Truncate(difference.TotalDays) + "   days apart");
        }

        public void checkTemperDate()
        {//latest date vs lastactivitydate
            //work here


            String conv;
            XDocument cash = XDocument.Load(@"RuntimeData.xml");

            var users = from usr in cash.Descendants("config")
                        select new
                        {

                            lact = usr.Element("lactivity").Value

                        };


            foreach (var use in users)
            {
               conv = use.lact;
               lactve = Convert.ToDateTime(conv);
               
            }
            TimeSpan difference = latestdate - lactve;
            MessageBox.Show(Math.Truncate(difference.TotalDays) + "   days apart");

        }

        public int countDate()
        {//Latest date vs install date
            int dayss,left;
            TimeSpan countdays = latestdate - installdate;
            dayss = Convert.ToInt32(Math.Truncate(countdays.TotalDays));
            left = 30 - dayss;

            //Saving..........
            XDocument xmlDoc = XDocument.Load(@"RuntimeData.xml");

            XElement element =
                xmlDoc.Root.Elements("config").Where(r => (string)r.Element("releasedate") == releaseday.ToString()).FirstOrDefault();
            if (element != null)
            {

                element.SetElementValue("daysleft", left.ToString());
               // MessageBox.Show("Changed");
             
               }

            xmlDoc.Save("RuntimeData.xml");
           
            return left;
        }




    }
}
