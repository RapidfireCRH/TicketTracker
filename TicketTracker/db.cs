using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketTracker
{
    class db
    {
        public int version_major = 1;
        public int version_minor = 0;
        public struct _user
        {
            public string name;
            public int sd;
            public int sd_change;
            public int ml;
            public int ml_change;
            public int email;
            public int email_change;
        }
        public static _user[] userdb = new _user[3];
        public bool initialize(string location)
        {
            try
            {
                if (!File.Exists(location))
                    File.WriteAllText(location, "");
                string writer = "TicketTracker Version " + version_major + "." + version_minor + Environment.NewLine;
                writer += "Name, SD Tickets, ML Tickets, Emails, SD Ticket Change, ML Ticket Change, Email Change" + Environment.NewLine;
                int i = 0;
                foreach (_user x in userdb)
                {
                    writer += "User" + (i++ + 1) + ", " + x.sd + ", " + x.ml + ", " + x.email + ", " + x.sd_change + ", " + x.ml_change + ", " + x.email_change + Environment.NewLine;
                }
                File.WriteAllText(location, writer);
                load(location);
                return true;
            }
            catch (Exception e)
            {
                errorlogging(e);
                return false;
            }
        }
        public bool load(string location)
        {
            try
            {
                if (!File.Exists(location))
                    return false;
                int i = 0;
                using (var reader = new StreamReader(location))//https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] delimiter = { ", " };
                        var values = line.Split(delimiter, StringSplitOptions.None);
                        if (values.Count() == 1 || values[1] == "SD Tickets")
                            continue;
                        _user temp = new _user();
                        temp.name = values[0];
                        temp.sd = Int32.Parse(values[1]);
                        temp.ml = Int32.Parse(values[2]);
                        temp.email = Int32.Parse(values[3]);
                        temp.sd_change = Int32.Parse(values[4]);
                        temp.ml_change = Int32.Parse(values[5]);
                        temp.email_change = Int32.Parse(values[6]);
                        userdb[i++] = temp;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                errorlogging(e);
                return false;
            }
        }
        public bool save(string location)
        {
            try
            {
                if (!File.Exists(location))
                    File.WriteAllText(location,"");
                string writer = "TicketTracker Version " + version_major + "." + version_minor + Environment.NewLine;
                writer += "Name, SD Tickets, ML Tickets, Emails, SD Ticket Change, ML Ticket Change, Email Change" + Environment.NewLine;
                foreach(_user x in userdb)
                {
                    writer += x.name + ", " + x.sd + ", " + x.ml + ", " + x.email + ", " + x.sd_change + ", " + x.ml_change + ", " + x.email_change + Environment.NewLine;
                }
                File.WriteAllText(location, writer);
                return true;
            }
            catch(Exception e)
            {
                errorlogging(e);
                return false;
            }
        }
        private void errorlogging(Exception e)
        {
            try
            {
                if (File.Exists("dberror.log"))
                    File.Create("dberror.log");
                File.AppendAllText("dberror.log",
                    "< Begin Error Log >---" + Environment.NewLine + 
                    DateTime.Now.ToLongDateString() + Environment.NewLine + 
                    DateTime.Now.ToLongTimeString() + Environment.NewLine + 
                    e.Message + Environment.NewLine + 
                    e.StackTrace + Environment.NewLine +
                    "---<End Error Log>" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("DB Error: " + e.Message + ". StackTrace: " + e.StackTrace);
            }

        }
    }
}
