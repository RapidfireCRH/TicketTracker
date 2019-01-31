using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketTracker
{
    public partial class Form1 : Form
    {
        db database = new db();
        public Form1()
        {
            InitializeComponent();

        }

        private void databaseloc_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            FileInfo fInfo = new FileInfo(openFileDialog1.FileName);
            if (!File.Exists(Path.Combine(fInfo.Directory.FullName, openFileDialog1.FileName)))
                db.initialize();
            databaseloc_textbox.Text = Path.Combine(fInfo.Directory.FullName, openFileDialog1.FileName);
        }

        private void lock_checkbox_Click(object sender, EventArgs e)
        {
            if (lock_checkbox.Checked)
            {
                databaseloc_textbox.Enabled = false;
            }
            else
            {
                databaseloc_textbox.Enabled = true;
            }
        }
    }
}
