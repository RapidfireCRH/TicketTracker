﻿using System;
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.line1_sd_ticket_down = new System.Windows.Forms.Button();
            this.line1_sd_ticket_up = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.line1_ml_ticket_up = new System.Windows.Forms.Button();
            this.line1_ml_ticket_down = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.line1_email_count_up = new System.Windows.Forms.Button();
            this.line1_email_count_down = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.databaseloc_textbox.Size = new System.Drawing.Size(276, 20);
            this.databaseloc_textbox.TabIndex = 1;
            this.databaseloc_textbox.Click += new System.EventHandler(this.databaseloc_click);
            // 
            // lock_checkbox
            // 
            this.lock_checkbox.AutoSize = true;
            this.lock_checkbox.Location = new System.Drawing.Point(422, 13);
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
            this.line1_checkbox.Location = new System.Drawing.Point(5, 17);
            this.line1_checkbox.Name = "line1_checkbox";
            this.line1_checkbox.Size = new System.Drawing.Size(15, 14);
            this.line1_checkbox.TabIndex = 3;
            this.line1_checkbox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Tony";
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
            this.label4.Location = new System.Drawing.Point(383, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emails";
            // 
            // line1_sd_ticket_down
            // 
            this.line1_sd_ticket_down.Location = new System.Drawing.Point(182, 13);
            this.line1_sd_ticket_down.Name = "line1_sd_ticket_down";
            this.line1_sd_ticket_down.Size = new System.Drawing.Size(18, 23);
            this.line1_sd_ticket_down.TabIndex = 8;
            this.line1_sd_ticket_down.Text = "<";
            this.line1_sd_ticket_down.UseVisualStyleBackColor = true;
            // 
            // line1_sd_ticket_up
            // 
            this.line1_sd_ticket_up.Location = new System.Drawing.Point(234, 13);
            this.line1_sd_ticket_up.Name = "line1_sd_ticket_up";
            this.line1_sd_ticket_up.Size = new System.Drawing.Size(18, 23);
            this.line1_sd_ticket_up.TabIndex = 11;
            this.line1_sd_ticket_up.Text = ">";
            this.line1_sd_ticket_up.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(197, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "7";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(285, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line1_ml_ticket_up
            // 
            this.line1_ml_ticket_up.Location = new System.Drawing.Point(322, 13);
            this.line1_ml_ticket_up.Name = "line1_ml_ticket_up";
            this.line1_ml_ticket_up.Size = new System.Drawing.Size(18, 23);
            this.line1_ml_ticket_up.TabIndex = 14;
            this.line1_ml_ticket_up.Text = ">";
            this.line1_ml_ticket_up.UseVisualStyleBackColor = true;
            // 
            // line1_ml_ticket_down
            // 
            this.line1_ml_ticket_down.Location = new System.Drawing.Point(270, 13);
            this.line1_ml_ticket_down.Name = "line1_ml_ticket_down";
            this.line1_ml_ticket_down.Size = new System.Drawing.Size(18, 23);
            this.line1_ml_ticket_down.TabIndex = 13;
            this.line1_ml_ticket_down.Text = "<";
            this.line1_ml_ticket_down.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "22";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line1_email_count_up
            // 
            this.line1_email_count_up.Location = new System.Drawing.Point(402, 13);
            this.line1_email_count_up.Name = "line1_email_count_up";
            this.line1_email_count_up.Size = new System.Drawing.Size(18, 23);
            this.line1_email_count_up.TabIndex = 17;
            this.line1_email_count_up.Text = ">";
            this.line1_email_count_up.UseVisualStyleBackColor = true;
            // 
            // line1_email_count_down
            // 
            this.line1_email_count_down.Location = new System.Drawing.Point(350, 13);
            this.line1_email_count_down.Name = "line1_email_count_down";
            this.line1_email_count_down.Size = new System.Drawing.Size(18, 23);
            this.line1_email_count_down.TabIndex = 16;
            this.line1_email_count_down.Text = "<";
            this.line1_email_count_down.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.line1_email_count_up);
            this.groupBox1.Controls.Add(this.line1_email_count_down);
            this.groupBox1.Controls.Add(this.line1_ml_ticket_up);
            this.groupBox1.Controls.Add(this.line1_ml_ticket_down);
            this.groupBox1.Controls.Add(this.line1_sd_ticket_up);
            this.groupBox1.Controls.Add(this.line1_sd_ticket_down);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.line1_checkbox);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 60);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ΔToday: 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ΔToday: 22";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "ΔToday: 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Location = new System.Drawing.Point(16, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 60);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "ΔToday: 5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ΔToday: 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ΔToday: 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(234, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(18, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(182, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(18, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 14);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "David";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(5, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(365, 14);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(39, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "5";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(285, 14);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(39, 20);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "12";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(197, 14);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(39, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "4";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Location = new System.Drawing.Point(16, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 60);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "ΔToday: 15";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(356, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "ΔToday: 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "ΔToday: 1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(402, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(18, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(350, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(18, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(322, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(18, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(270, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(18, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "<";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(234, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(18, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = ">";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(182, 13);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(18, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "<";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(27, 14);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(140, 20);
            this.textBox9.TabIndex = 4;
            this.textBox9.Text = "Michela";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(5, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(365, 14);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(39, 20);
            this.textBox10.TabIndex = 18;
            this.textBox10.Text = "4";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(285, 14);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(39, 20);
            this.textBox11.TabIndex = 15;
            this.textBox11.Text = "9001";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(197, 14);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(39, 20);
            this.textBox12.TabIndex = 12;
            this.textBox12.Text = "3";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 375);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.lock_checkbox);
            this.Controls.Add(this.databaseloc_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button line1_sd_ticket_down;
        private System.Windows.Forms.Button line1_sd_ticket_up;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button line1_ml_ticket_up;
        private System.Windows.Forms.Button line1_ml_ticket_down;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button line1_email_count_up;
        private System.Windows.Forms.Button line1_email_count_down;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
    }
}

