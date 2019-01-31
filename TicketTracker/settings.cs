using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracker
{
    
    class settings
    {
        public struct _settingsfile
        {
            public string dbpath;
            public bool lck;
        }
        string appdatapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DTVSD", "TicketTracker");
        public _settingsfile loadSettings()
        {
            throw new NotImplementedException();
        }
        public bool saveSettings(_settingsfile save)
        {
            throw new NotImplementedException();
        }
    }
}
