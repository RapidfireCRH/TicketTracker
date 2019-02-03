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
        db _db = new db();
        settings _set = new settings();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _set.loadSettings();
            first_name_textbox.Text = _set.set.usernames[0];
            second_name_textbox.Text = _set.set.usernames[1];
            third_name_textbox.Text = _set.set.usernames[2];
            databaseloc_textbox.Text = _set.set.dbpath;
            line1_checkbox.Enabled = line2_checkbox.Enabled = line3_checkbox.Enabled = lock_checkbox.Checked = _set.set.lck;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _set.set.dbpath = databaseloc_textbox.Text;
            _set.set.lck = lock_checkbox.Checked;
            _set.set.usernames[0] = first_name_textbox.Text;
            _set.set.usernames[1] = second_name_textbox.Text;
            _set.set.usernames[2] = third_name_textbox.Text;
            _set.saveSettings();
            _db.save(databaseloc_textbox.Text);
        }

        private void updatedisplay()
        {
            first_name_textbox.Text = db.userdb[0].name;
            first_sd_tickets_textbox.Text = db.userdb[0].sd.ToString();
            first_sd_tickets_change.Text = "ΔToday: " + db.userdb[0].sd_change.ToString();
            first_ml_tickets_textbox.Text = db.userdb[0].ml.ToString();
            first_ml_tickets_change.Text = "ΔToday: " + db.userdb[0].ml_change.ToString();
            first_emails_textbox.Text = db.userdb[0].email.ToString();
            first_emails_change.Text = "ΔToday: " + db.userdb[0].email_change.ToString();


            second_name_textbox.Text = db.userdb[1].name;
            second_sd_tickets_textbox.Text = db.userdb[1].sd.ToString();
            second_sd_tickets_change.Text = "ΔToday: " + db.userdb[1].sd_change.ToString();
            second_ml_tickets_textbox.Text = db.userdb[1].ml.ToString();
            second_ml_tickets_change.Text = "ΔToday: " + db.userdb[1].ml_change.ToString();
            second_emails_textbox.Text = db.userdb[1].email.ToString();
            second_emails_change.Text = "ΔToday: " + db.userdb[1].email_change.ToString();

            third_name_textbox.Text = db.userdb[2].name;
            third_sd_tickets_textbox.Text = db.userdb[2].sd.ToString();
            third_sd_tickets_change.Text = "ΔToday: " + db.userdb[2].sd_change.ToString();
            third_ml_tickets_textbox.Text = db.userdb[2].ml.ToString();
            third_ml_tickets_change.Text = "ΔToday: " + db.userdb[2].ml_change.ToString();
            third_emails_textbox.Text = db.userdb[2].email.ToString();
            third_emails_change.Text = "ΔToday: " + db.userdb[2].email_change.ToString();
        }

        //--------------------------------------------------------------------------------------------------------------------BUTTONS
        private void databaseloc_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.DefaultExt = ".csv";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            FileInfo fInfo = new FileInfo(openFileDialog1.FileName);
            databaseloc_textbox.Text = Path.Combine(fInfo.Directory.FullName, openFileDialog1.FileName);
            
            lock_checkbox.Checked = true;
            lock_checkbox_Click(sender, e);
        }

        private void reset_delta_button_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------------------------------------------Checkboxes
        private void lock_checkbox_Click(object sender, EventArgs e)
        {
            if (lock_checkbox.Checked)
            {
                
                if (!File.Exists(databaseloc_textbox.Text))
                    if (!_db.initialize(databaseloc_textbox.Text))
                    {
                        MessageBox.Show("Unable to initialize database. Check DBError.log for details.");
                        databaseloc_textbox.Text = "";
                        lock_checkbox.Checked = false;
                        return;
                    }
                if (!_db.load(databaseloc_textbox.Text))
                {
                    MessageBox.Show("Unable to load database. Check DBError.log for details.");
                    databaseloc_textbox.Text = "";
                    lock_checkbox.Checked = false;
                    return;
                }
                databaseloc_textbox.Enabled = false;
            }
            else
            {
                databaseloc_textbox.Enabled = true;
            }
        }
        private void line1_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (line1_checkbox.Checked)
                first_group.Enabled = true;
            else
                first_group.Enabled = false;
        }
        private void line2_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (line2_checkbox.Checked)
                second_group.Enabled = true;
            else
                second_group.Enabled = false;
        }
        private void line3_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (line3_checkbox.Checked)
                third_group.Enabled = true;
            else
                third_group.Enabled = false;
        }

        

    }
}
