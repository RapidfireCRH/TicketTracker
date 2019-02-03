using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketTracker
{
    
    class settings
    {
        public struct _settingsfile
        {
            public string dbpath;
            public bool lck;
            public string[] usernames;
        }
        public _settingsfile set = new _settingsfile();
        int version_major = 1;
        int version_minor = 0;
        string appdatapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DTVSD", "TicketTracker");

        public bool loadSettings()
        {
            try
            {
                //version,dbpath,lck,usernames
                if (!File.Exists(Path.Combine(appdatapath, "settings.dat")))
                    init();
                string line = File.ReadAllText(Path.Combine(appdatapath, "settings.dat"));
                string[] delimit = line.Split(',');
                set.dbpath = delimit[1];
                set.lck = (delimit[2]=="0"?false:true);
                set.usernames = new string[3];
                set.usernames[0] = delimit[3];
                set.usernames[1] = delimit[4];
                set.usernames[2] = delimit[5];
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to load settings file: " + e.Message + Environment.NewLine + "Stack trace: " + e.StackTrace);
                return false;
            }
        }
        public bool saveSettings()
        {
            try
            {
                //version,dbpath,lck,usernames
                string writer = version_major + "." + version_minor + "," + set.dbpath + "," + (set.lck ? 1 : 0);
                foreach (string x in set.usernames)
                {
                    writer += "," + x;
                }
                if (!Directory.Exists(appdatapath))
                    Directory.CreateDirectory(appdatapath);
                File.WriteAllText(Path.Combine(appdatapath,"settings.dat"), writer);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Unable to write settings file: " + e.Message + Environment.NewLine + "Stack trace: " + e.StackTrace);
                return false;
            }
        }
        private void init()
        {
            set.dbpath = Path.Combine(Directory.GetCurrentDirectory(), "localdb.csv");
            set.lck = false;
            set.usernames = new string[3];
            set.usernames[0] = "User1";
            set.usernames[1] = "User2";
            set.usernames[2] = "User3";
            saveSettings();
        }
    }
}
