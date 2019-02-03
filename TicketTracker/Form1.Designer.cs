using System;
using System.ComponentModel;

namespace TicketTracker
{
    partial class Form1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.databaseloc_textbox = new System.Windows.Forms.TextBox();
            this.lock_checkbox = new System.Windows.Forms.CheckBox();
            this.line1_checkbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.line1_sd_ticket_down = new System.Windows.Forms.Button();
            this.line1_sd_ticket_up = new System.Windows.Forms.Button();
            this.first_sd_tickets_textbox = new System.Windows.Forms.TextBox();
            this.first_ml_tickets_textbox = new System.Windows.Forms.TextBox();
            this.line1_ml_ticket_up = new System.Windows.Forms.Button();
            this.line1_ml_ticket_down = new System.Windows.Forms.Button();
            this.first_emails_textbox = new System.Windows.Forms.TextBox();
            this.line1_email_count_up = new System.Windows.Forms.Button();
            this.line1_email_count_down = new System.Windows.Forms.Button();
            this.first_group = new System.Windows.Forms.GroupBox();
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.first_ml_tickets_change = new System.Windows.Forms.Label();
            this.first_emails_change = new System.Windows.Forms.Label();
            this.first_sd_tickets_change = new System.Windows.Forms.Label();
            this.second_group = new System.Windows.Forms.GroupBox();
            this.second_ml_tickets_change = new System.Windows.Forms.Label();
            this.second_emails_change = new System.Windows.Forms.Label();
            this.second_sd_tickets_change = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.second_name_textbox = new System.Windows.Forms.TextBox();
            this.second_emails_textbox = new System.Windows.Forms.TextBox();
            this.second_ml_tickets_textbox = new System.Windows.Forms.TextBox();
            this.second_sd_tickets_textbox = new System.Windows.Forms.TextBox();
            this.line2_checkbox = new System.Windows.Forms.CheckBox();
            this.third_group = new System.Windows.Forms.GroupBox();
            this.third_ml_tickets_change = new System.Windows.Forms.Label();
            this.third_emails_change = new System.Windows.Forms.Label();
            this.third_sd_tickets_change = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.third_name_textbox = new System.Windows.Forms.TextBox();
            this.third_emails_textbox = new System.Windows.Forms.TextBox();
            this.third_ml_tickets_textbox = new System.Windows.Forms.TextBox();
            this.third_sd_tickets_textbox = new System.Windows.Forms.TextBox();
            this.line3_checkbox = new System.Windows.Forms.CheckBox();
            this.reset_delta_button = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.first_group.SuspendLayout();
            this.second_group.SuspendLayout();
            this.third_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(200, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 13);
            label2.TabIndex = 5;
            label2.Text = "SD Tickets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database File Location:";
            // 
            // databaseloc_textbox
            // 
            this.databaseloc_textbox.Location = new System.Drawing.Point(139, 10);
            this.databaseloc_textbox.Name = "databaseloc_textbox";
            this.databaseloc_textbox.Size = new System.Drawing.Size(245, 20);
            this.databaseloc_textbox.TabIndex = 1;
            this.databaseloc_textbox.Click += new System.EventHandler(this.databaseloc_click);
            // 
            // lock_checkbox
            // 
            this.lock_checkbox.AutoSize = true;
            this.lock_checkbox.Location = new System.Drawing.Point(391, 13);
            this.lock_checkbox.Name = "lock_checkbox";
            this.lock_checkbox.Size = new System.Drawing.Size(50, 17);
            this.lock_checkbox.TabIndex = 2;
            this.lock_checkbox.Text = "Lock";
            this.lock_checkbox.UseVisualStyleBackColor = true;
            this.lock_checkbox.CheckedChanged += new System.EventHandler(this.lock_checkbox_Click);
            // 
            // line1_checkbox
            // 
            this.line1_checkbox.AutoSize = true;
            this.line1_checkbox.Checked = true;
            this.line1_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.line1_checkbox.Location = new System.Drawing.Point(12, 82);
            this.line1_checkbox.Name = "line1_checkbox";
            this.line1_checkbox.Size = new System.Drawing.Size(15, 14);
            this.line1_checkbox.TabIndex = 3;
            this.line1_checkbox.UseVisualStyleBackColor = true;
            this.line1_checkbox.CheckedChanged += new System.EventHandler(this.line1_checkbox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ML Tickets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emails";
            // 
            // line1_sd_ticket_down
            // 
            this.line1_sd_ticket_down.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.line1_sd_ticket_down.Location = new System.Drawing.Point(161, 13);
            this.line1_sd_ticket_down.Name = "line1_sd_ticket_down";
            this.line1_sd_ticket_down.Size = new System.Drawing.Size(18, 23);
            this.line1_sd_ticket_down.TabIndex = 8;
            this.line1_sd_ticket_down.Text = "<";
            this.line1_sd_ticket_down.UseVisualStyleBackColor = true;
            // 
            // line1_sd_ticket_up
            // 
            this.line1_sd_ticket_up.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.line1_sd_ticket_up.Location = new System.Drawing.Point(213, 13);
            this.line1_sd_ticket_up.Name = "line1_sd_ticket_up";
            this.line1_sd_ticket_up.Size = new System.Drawing.Size(18, 23);
            this.line1_sd_ticket_up.TabIndex = 11;
            this.line1_sd_ticket_up.Text = ">";
            this.line1_sd_ticket_up.UseVisualStyleBackColor = true;
            // 
            // first_sd_tickets_textbox
            // 
            this.first_sd_tickets_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.first_sd_tickets_textbox.Enabled = false;
            this.first_sd_tickets_textbox.Location = new System.Drawing.Point(176, 14);
            this.first_sd_tickets_textbox.Name = "first_sd_tickets_textbox";
            this.first_sd_tickets_textbox.Size = new System.Drawing.Size(39, 20);
            this.first_sd_tickets_textbox.TabIndex = 12;
            this.first_sd_tickets_textbox.Text = "0";
            this.first_sd_tickets_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // first_ml_tickets_textbox
            // 
            this.first_ml_tickets_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.first_ml_tickets_textbox.Location = new System.Drawing.Point(264, 14);
            this.first_ml_tickets_textbox.Name = "first_ml_tickets_textbox";
            this.first_ml_tickets_textbox.Size = new System.Drawing.Size(39, 20);
            this.first_ml_tickets_textbox.TabIndex = 15;
            this.first_ml_tickets_textbox.Text = "0";
            this.first_ml_tickets_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line1_ml_ticket_up
            // 
            this.line1_ml_ticket_up.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.line1_ml_ticket_up.Location = new System.Drawing.Point(301, 13);
            this.line1_ml_ticket_up.Name = "line1_ml_ticket_up";
            this.line1_ml_ticket_up.Size = new System.Drawing.Size(18, 23);
            this.line1_ml_ticket_up.TabIndex = 14;
            this.line1_ml_ticket_up.Text = ">";
            this.line1_ml_ticket_up.UseVisualStyleBackColor = true;
            // 
            // line1_ml_ticket_down
            // 
            this.line1_ml_ticket_down.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.line1_ml_ticket_down.Location = new System.Drawing.Point(249, 13);
            this.line1_ml_ticket_down.Name = "line1_ml_ticket_down";
            this.line1_ml_ticket_down.Size = new System.Drawing.Size(18, 23);
            this.line1_ml_ticket_down.TabIndex = 13;
            this.line1_ml_ticket_down.Text = "<";
            this.line1_ml_ticket_down.UseVisualStyleBackColor = true;
            // 
            // first_emails_textbox
            // 
            this.first_emails_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.first_emails_textbox.Location = new System.Drawing.Point(344, 14);
            this.first_emails_textbox.Name = "first_emails_textbox";
            this.first_emails_textbox.Size = new System.Drawing.Size(39, 20);
            this.first_emails_textbox.TabIndex = 18;
            this.first_emails_textbox.Text = "0";
            this.first_emails_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line1_email_count_up
            // 
            this.line1_email_count_up.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.line1_email_count_up.Location = new System.Drawing.Point(381, 13);
            this.line1_email_count_up.Name = "line1_email_count_up";
            this.line1_email_count_up.Size = new System.Drawing.Size(18, 23);
            this.line1_email_count_up.TabIndex = 17;
            this.line1_email_count_up.Text = ">";
            this.line1_email_count_up.UseVisualStyleBackColor = true;
            // 
            // line1_email_count_down
            // 
            this.line1_email_count_down.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.line1_email_count_down.Location = new System.Drawing.Point(329, 13);
            this.line1_email_count_down.Name = "line1_email_count_down";
            this.line1_email_count_down.Size = new System.Drawing.Size(18, 23);
            this.line1_email_count_down.TabIndex = 16;
            this.line1_email_count_down.Text = "<";
            this.line1_email_count_down.UseVisualStyleBackColor = true;
            // 
            // first_group
            // 
            this.first_group.Controls.Add(this.first_name_textbox);
            this.first_group.Controls.Add(this.first_ml_tickets_change);
            this.first_group.Controls.Add(this.first_emails_change);
            this.first_group.Controls.Add(this.first_sd_tickets_change);
            this.first_group.Controls.Add(this.line1_email_count_up);
            this.first_group.Controls.Add(this.line1_email_count_down);
            this.first_group.Controls.Add(this.line1_ml_ticket_up);
            this.first_group.Controls.Add(this.line1_ml_ticket_down);
            this.first_group.Controls.Add(this.line1_sd_ticket_up);
            this.first_group.Controls.Add(this.line1_sd_ticket_down);
            this.first_group.Controls.Add(this.first_emails_textbox);
            this.first_group.Controls.Add(this.first_ml_tickets_textbox);
            this.first_group.Controls.Add(this.first_sd_tickets_textbox);
            this.first_group.Location = new System.Drawing.Point(32, 64);
            this.first_group.Name = "first_group";
            this.first_group.Size = new System.Drawing.Size(404, 60);
            this.first_group.TabIndex = 19;
            this.first_group.TabStop = false;
            // 
            // first_name_textbox
            // 
            this.first_name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.first_name_textbox.Location = new System.Drawing.Point(6, 14);
            this.first_name_textbox.Name = "first_name_textbox";
            this.first_name_textbox.Size = new System.Drawing.Size(140, 20);
            this.first_name_textbox.TabIndex = 22;
            this.first_name_textbox.Text = "Tony";
            // 
            // first_ml_tickets_change
            // 
            this.first_ml_tickets_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.first_ml_tickets_change.AutoSize = true;
            this.first_ml_tickets_change.Location = new System.Drawing.Point(254, 39);
            this.first_ml_tickets_change.Name = "first_ml_tickets_change";
            this.first_ml_tickets_change.Size = new System.Drawing.Size(56, 13);
            this.first_ml_tickets_change.TabIndex = 21;
            this.first_ml_tickets_change.Text = "ΔToday: 0";
            // 
            // first_emails_change
            // 
            this.first_emails_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.first_emails_change.AutoSize = true;
            this.first_emails_change.Location = new System.Drawing.Point(335, 39);
            this.first_emails_change.Name = "first_emails_change";
            this.first_emails_change.Size = new System.Drawing.Size(56, 13);
            this.first_emails_change.TabIndex = 20;
            this.first_emails_change.Text = "ΔToday: 0";
            // 
            // first_sd_tickets_change
            // 
            this.first_sd_tickets_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.first_sd_tickets_change.AutoSize = true;
            this.first_sd_tickets_change.Location = new System.Drawing.Point(167, 39);
            this.first_sd_tickets_change.Name = "first_sd_tickets_change";
            this.first_sd_tickets_change.Size = new System.Drawing.Size(56, 13);
            this.first_sd_tickets_change.TabIndex = 19;
            this.first_sd_tickets_change.Text = "ΔToday: 0";
            // 
            // second_group
            // 
            this.second_group.Controls.Add(this.second_ml_tickets_change);
            this.second_group.Controls.Add(this.second_emails_change);
            this.second_group.Controls.Add(this.second_sd_tickets_change);
            this.second_group.Controls.Add(this.button1);
            this.second_group.Controls.Add(this.button2);
            this.second_group.Controls.Add(this.button3);
            this.second_group.Controls.Add(this.button4);
            this.second_group.Controls.Add(this.button5);
            this.second_group.Controls.Add(this.button6);
            this.second_group.Controls.Add(this.second_name_textbox);
            this.second_group.Controls.Add(this.second_emails_textbox);
            this.second_group.Controls.Add(this.second_ml_tickets_textbox);
            this.second_group.Controls.Add(this.second_sd_tickets_textbox);
            this.second_group.Location = new System.Drawing.Point(32, 130);
            this.second_group.Name = "second_group";
            this.second_group.Size = new System.Drawing.Size(404, 60);
            this.second_group.TabIndex = 22;
            this.second_group.TabStop = false;
            // 
            // second_ml_tickets_change
            // 
            this.second_ml_tickets_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.second_ml_tickets_change.AutoSize = true;
            this.second_ml_tickets_change.Location = new System.Drawing.Point(254, 39);
            this.second_ml_tickets_change.Name = "second_ml_tickets_change";
            this.second_ml_tickets_change.Size = new System.Drawing.Size(56, 13);
            this.second_ml_tickets_change.TabIndex = 21;
            this.second_ml_tickets_change.Text = "ΔToday: 0";
            // 
            // second_emails_change
            // 
            this.second_emails_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.second_emails_change.AutoSize = true;
            this.second_emails_change.Location = new System.Drawing.Point(335, 39);
            this.second_emails_change.Name = "second_emails_change";
            this.second_emails_change.Size = new System.Drawing.Size(56, 13);
            this.second_emails_change.TabIndex = 20;
            this.second_emails_change.Text = "ΔToday: 0";
            // 
            // second_sd_tickets_change
            // 
            this.second_sd_tickets_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.second_sd_tickets_change.AutoSize = true;
            this.second_sd_tickets_change.Location = new System.Drawing.Point(167, 39);
            this.second_sd_tickets_change.Name = "second_sd_tickets_change";
            this.second_sd_tickets_change.Size = new System.Drawing.Size(56, 13);
            this.second_sd_tickets_change.TabIndex = 19;
            this.second_sd_tickets_change.Text = "ΔToday: 0";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(381, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(329, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(301, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(249, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.Location = new System.Drawing.Point(213, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(18, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.Location = new System.Drawing.Point(161, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(18, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // second_name_textbox
            // 
            this.second_name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.second_name_textbox.Location = new System.Drawing.Point(6, 14);
            this.second_name_textbox.Name = "second_name_textbox";
            this.second_name_textbox.Size = new System.Drawing.Size(140, 20);
            this.second_name_textbox.TabIndex = 4;
            this.second_name_textbox.Text = "David";
            // 
            // second_emails_textbox
            // 
            this.second_emails_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.second_emails_textbox.Location = new System.Drawing.Point(344, 14);
            this.second_emails_textbox.Name = "second_emails_textbox";
            this.second_emails_textbox.Size = new System.Drawing.Size(39, 20);
            this.second_emails_textbox.TabIndex = 18;
            this.second_emails_textbox.Text = "0";
            this.second_emails_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // second_ml_tickets_textbox
            // 
            this.second_ml_tickets_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.second_ml_tickets_textbox.Location = new System.Drawing.Point(264, 14);
            this.second_ml_tickets_textbox.Name = "second_ml_tickets_textbox";
            this.second_ml_tickets_textbox.Size = new System.Drawing.Size(39, 20);
            this.second_ml_tickets_textbox.TabIndex = 15;
            this.second_ml_tickets_textbox.Text = "0";
            this.second_ml_tickets_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // second_sd_tickets_textbox
            // 
            this.second_sd_tickets_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.second_sd_tickets_textbox.Enabled = false;
            this.second_sd_tickets_textbox.Location = new System.Drawing.Point(176, 14);
            this.second_sd_tickets_textbox.Name = "second_sd_tickets_textbox";
            this.second_sd_tickets_textbox.Size = new System.Drawing.Size(39, 20);
            this.second_sd_tickets_textbox.TabIndex = 12;
            this.second_sd_tickets_textbox.Text = "0";
            this.second_sd_tickets_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line2_checkbox
            // 
            this.line2_checkbox.AutoSize = true;
            this.line2_checkbox.Checked = true;
            this.line2_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.line2_checkbox.Location = new System.Drawing.Point(12, 147);
            this.line2_checkbox.Name = "line2_checkbox";
            this.line2_checkbox.Size = new System.Drawing.Size(15, 14);
            this.line2_checkbox.TabIndex = 3;
            this.line2_checkbox.UseVisualStyleBackColor = true;
            this.line2_checkbox.CheckedChanged += new System.EventHandler(this.line2_checkbox_CheckedChanged);
            // 
            // third_group
            // 
            this.third_group.Controls.Add(this.third_ml_tickets_change);
            this.third_group.Controls.Add(this.third_emails_change);
            this.third_group.Controls.Add(this.third_sd_tickets_change);
            this.third_group.Controls.Add(this.button7);
            this.third_group.Controls.Add(this.button8);
            this.third_group.Controls.Add(this.button9);
            this.third_group.Controls.Add(this.button10);
            this.third_group.Controls.Add(this.button11);
            this.third_group.Controls.Add(this.button12);
            this.third_group.Controls.Add(this.third_name_textbox);
            this.third_group.Controls.Add(this.third_emails_textbox);
            this.third_group.Controls.Add(this.third_ml_tickets_textbox);
            this.third_group.Controls.Add(this.third_sd_tickets_textbox);
            this.third_group.Location = new System.Drawing.Point(32, 196);
            this.third_group.Name = "third_group";
            this.third_group.Size = new System.Drawing.Size(404, 60);
            this.third_group.TabIndex = 22;
            this.third_group.TabStop = false;
            // 
            // third_ml_tickets_change
            // 
            this.third_ml_tickets_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.third_ml_tickets_change.AutoSize = true;
            this.third_ml_tickets_change.Location = new System.Drawing.Point(254, 39);
            this.third_ml_tickets_change.Name = "third_ml_tickets_change";
            this.third_ml_tickets_change.Size = new System.Drawing.Size(56, 13);
            this.third_ml_tickets_change.TabIndex = 21;
            this.third_ml_tickets_change.Text = "ΔToday: 0";
            // 
            // third_emails_change
            // 
            this.third_emails_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.third_emails_change.AutoSize = true;
            this.third_emails_change.Location = new System.Drawing.Point(335, 39);
            this.third_emails_change.Name = "third_emails_change";
            this.third_emails_change.Size = new System.Drawing.Size(56, 13);
            this.third_emails_change.TabIndex = 20;
            this.third_emails_change.Text = "ΔToday: 0";
            // 
            // third_sd_tickets_change
            // 
            this.third_sd_tickets_change.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.third_sd_tickets_change.AutoSize = true;
            this.third_sd_tickets_change.Location = new System.Drawing.Point(167, 39);
            this.third_sd_tickets_change.Name = "third_sd_tickets_change";
            this.third_sd_tickets_change.Size = new System.Drawing.Size(56, 13);
            this.third_sd_tickets_change.TabIndex = 19;
            this.third_sd_tickets_change.Text = "ΔToday: 0";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button7.Location = new System.Drawing.Point(381, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(18, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.Location = new System.Drawing.Point(329, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(18, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button9.Location = new System.Drawing.Point(301, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(18, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button10.Location = new System.Drawing.Point(249, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(18, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "<";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button11.Location = new System.Drawing.Point(213, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(18, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = ">";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button12.Location = new System.Drawing.Point(161, 13);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(18, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "<";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // third_name_textbox
            // 
            this.third_name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.third_name_textbox.Location = new System.Drawing.Point(6, 14);
            this.third_name_textbox.Name = "third_name_textbox";
            this.third_name_textbox.Size = new System.Drawing.Size(140, 20);
            this.third_name_textbox.TabIndex = 4;
            this.third_name_textbox.Text = "Michela";
            // 
            // third_emails_textbox
            // 
            this.third_emails_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.third_emails_textbox.Location = new System.Drawing.Point(344, 14);
            this.third_emails_textbox.Name = "third_emails_textbox";
            this.third_emails_textbox.Size = new System.Drawing.Size(39, 20);
            this.third_emails_textbox.TabIndex = 18;
            this.third_emails_textbox.Text = "0";
            this.third_emails_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // third_ml_tickets_textbox
            // 
            this.third_ml_tickets_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.third_ml_tickets_textbox.Location = new System.Drawing.Point(264, 14);
            this.third_ml_tickets_textbox.Name = "third_ml_tickets_textbox";
            this.third_ml_tickets_textbox.Size = new System.Drawing.Size(39, 20);
            this.third_ml_tickets_textbox.TabIndex = 15;
            this.third_ml_tickets_textbox.Text = "0";
            this.third_ml_tickets_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // third_sd_tickets_textbox
            // 
            this.third_sd_tickets_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.third_sd_tickets_textbox.Enabled = false;
            this.third_sd_tickets_textbox.Location = new System.Drawing.Point(176, 14);
            this.third_sd_tickets_textbox.Name = "third_sd_tickets_textbox";
            this.third_sd_tickets_textbox.Size = new System.Drawing.Size(39, 20);
            this.third_sd_tickets_textbox.TabIndex = 12;
            this.third_sd_tickets_textbox.Text = "0";
            this.third_sd_tickets_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line3_checkbox
            // 
            this.line3_checkbox.AutoSize = true;
            this.line3_checkbox.Checked = true;
            this.line3_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.line3_checkbox.Location = new System.Drawing.Point(11, 213);
            this.line3_checkbox.Name = "line3_checkbox";
            this.line3_checkbox.Size = new System.Drawing.Size(15, 14);
            this.line3_checkbox.TabIndex = 3;
            this.line3_checkbox.UseVisualStyleBackColor = true;
            this.line3_checkbox.CheckedChanged += new System.EventHandler(this.line3_checkbox_CheckedChanged);
            // 
            // reset_delta_button
            // 
            this.reset_delta_button.Location = new System.Drawing.Point(13, 36);
            this.reset_delta_button.Name = "reset_delta_button";
            this.reset_delta_button.Size = new System.Drawing.Size(75, 23);
            this.reset_delta_button.TabIndex = 23;
            this.reset_delta_button.Text = "New Day";
            this.reset_delta_button.UseVisualStyleBackColor = true;
            this.reset_delta_button.Click += new System.EventHandler(this.reset_delta_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 269);
            this.Controls.Add(this.reset_delta_button);
            this.Controls.Add(this.third_group);
            this.Controls.Add(this.second_group);
            this.Controls.Add(this.first_group);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.lock_checkbox);
            this.Controls.Add(this.databaseloc_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line1_checkbox);
            this.Controls.Add(this.line3_checkbox);
            this.Controls.Add(this.line2_checkbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.first_group.ResumeLayout(false);
            this.first_group.PerformLayout();
            this.second_group.ResumeLayout(false);
            this.second_group.PerformLayout();
            this.third_group.ResumeLayout(false);
            this.third_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox databaseloc_textbox;
        private System.Windows.Forms.CheckBox lock_checkbox;
        private System.Windows.Forms.CheckBox line1_checkbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button line1_sd_ticket_down;
        private System.Windows.Forms.Button line1_sd_ticket_up;
        private System.Windows.Forms.TextBox first_sd_tickets_textbox;
        private System.Windows.Forms.TextBox first_ml_tickets_textbox;
        private System.Windows.Forms.Button line1_ml_ticket_up;
        private System.Windows.Forms.Button line1_ml_ticket_down;
        private System.Windows.Forms.TextBox first_emails_textbox;
        private System.Windows.Forms.Button line1_email_count_up;
        private System.Windows.Forms.Button line1_email_count_down;
        private System.Windows.Forms.GroupBox first_group;
        private System.Windows.Forms.Label first_ml_tickets_change;
        private System.Windows.Forms.Label first_emails_change;
        private System.Windows.Forms.Label first_sd_tickets_change;
        private System.Windows.Forms.GroupBox second_group;
        private System.Windows.Forms.Label second_ml_tickets_change;
        private System.Windows.Forms.Label second_emails_change;
        private System.Windows.Forms.Label second_sd_tickets_change;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox second_name_textbox;
        private System.Windows.Forms.CheckBox line2_checkbox;
        private System.Windows.Forms.TextBox second_emails_textbox;
        private System.Windows.Forms.TextBox second_ml_tickets_textbox;
        private System.Windows.Forms.TextBox second_sd_tickets_textbox;
        private System.Windows.Forms.GroupBox third_group;
        private System.Windows.Forms.Label third_ml_tickets_change;
        private System.Windows.Forms.Label third_emails_change;
        private System.Windows.Forms.Label third_sd_tickets_change;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox third_name_textbox;
        private System.Windows.Forms.CheckBox line3_checkbox;
        private System.Windows.Forms.TextBox third_emails_textbox;
        private System.Windows.Forms.TextBox third_ml_tickets_textbox;
        private System.Windows.Forms.TextBox third_sd_tickets_textbox;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.Button reset_delta_button;
    }
}

