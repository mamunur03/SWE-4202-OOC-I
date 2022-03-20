namespace lab8_116
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_leave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_leave = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_salary = new System.Windows.Forms.Label();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_contact = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_editName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_editLeave = new System.Windows.Forms.TextBox();
            this.tb_editSalary = new System.Windows.Forms.TextBox();
            this.tb_editContact = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_editID = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Dt_addTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date joined";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Leave";
            // 
            // tb_contact
            // 
            this.tb_contact.Location = new System.Drawing.Point(164, 151);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(100, 22);
            this.tb_contact.TabIndex = 10;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(164, 213);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(100, 22);
            this.tb_salary.TabIndex = 12;
            // 
            // tb_leave
            // 
            this.tb_leave.Location = new System.Drawing.Point(164, 245);
            this.tb_leave.Name = "tb_leave";
            this.tb_leave.Size = new System.Drawing.Size(100, 22);
            this.tb_leave.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ADD_OnClick);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(164, 72);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 22);
            this.tb_name.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Salesperson",
            "Typewriter"});
            this.comboBox1.Location = new System.Drawing.Point(169, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(696, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Search";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(781, 73);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 22);
            this.tb_ID.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(707, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(698, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(696, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Leave";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(698, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Date joined";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(698, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Salary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(698, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Contact";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(820, 198);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(0, 16);
            this.lb_name.TabIndex = 38;
            // 
            // lb_leave
            // 
            this.lb_leave.AutoSize = true;
            this.lb_leave.Location = new System.Drawing.Point(818, 364);
            this.lb_leave.Name = "lb_leave";
            this.lb_leave.Size = new System.Drawing.Size(0, 16);
            this.lb_leave.TabIndex = 37;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(820, 302);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(0, 16);
            this.lb_date.TabIndex = 36;
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.Location = new System.Drawing.Point(820, 332);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(0, 16);
            this.lb_salary.TabIndex = 35;
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.Location = new System.Drawing.Point(820, 238);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(0, 16);
            this.lb_category.TabIndex = 34;
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Location = new System.Drawing.Point(820, 273);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(0, 16);
            this.lb_contact.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Search_OnClick);
            // 
            // tb_editName
            // 
            this.tb_editName.Location = new System.Drawing.Point(465, 72);
            this.tb_editName.Name = "tb_editName";
            this.tb_editName.Size = new System.Drawing.Size(100, 22);
            this.tb_editName.TabIndex = 52;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(365, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 16);
            this.label17.TabIndex = 51;
            this.label17.Text = "Name";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_onClick);
            // 
            // tb_editLeave
            // 
            this.tb_editLeave.Location = new System.Drawing.Point(465, 195);
            this.tb_editLeave.Name = "tb_editLeave";
            this.tb_editLeave.Size = new System.Drawing.Size(100, 22);
            this.tb_editLeave.TabIndex = 49;
            // 
            // tb_editSalary
            // 
            this.tb_editSalary.Location = new System.Drawing.Point(465, 151);
            this.tb_editSalary.Name = "tb_editSalary";
            this.tb_editSalary.Size = new System.Drawing.Size(100, 22);
            this.tb_editSalary.TabIndex = 48;
            // 
            // tb_editContact
            // 
            this.tb_editContact.Location = new System.Drawing.Point(465, 110);
            this.tb_editContact.Name = "tb_editContact";
            this.tb_editContact.Size = new System.Drawing.Size(100, 22);
            this.tb_editContact.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(366, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "Leave";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(365, 151);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 16);
            this.label20.TabIndex = 43;
            this.label20.Text = "Salary";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(365, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "Contact";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(355, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 29);
            this.label23.TabIndex = 40;
            this.label23.Text = "EDIT";
            // 
            // tb_editID
            // 
            this.tb_editID.Location = new System.Drawing.Point(465, 44);
            this.tb_editID.Name = "tb_editID";
            this.tb_editID.Size = new System.Drawing.Size(100, 22);
            this.tb_editID.TabIndex = 55;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(365, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 16);
            this.label24.TabIndex = 54;
            this.label24.Text = "ID";
            // 
            // Dt_addTime
            // 
            this.Dt_addTime.Location = new System.Drawing.Point(159, 179);
            this.Dt_addTime.Name = "Dt_addTime";
            this.Dt_addTime.Size = new System.Drawing.Size(164, 22);
            this.Dt_addTime.TabIndex = 56;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 450);
            this.Controls.Add(this.Dt_addTime);
            this.Controls.Add(this.tb_editID);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tb_editName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_editLeave);
            this.Controls.Add(this.tb_editSalary);
            this.Controls.Add(this.tb_editContact);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_leave);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_salary);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.lb_contact);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_leave);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_contact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox tb_leave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_leave;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_salary;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_editName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_editLeave;
        private System.Windows.Forms.TextBox tb_editSalary;
        private System.Windows.Forms.TextBox tb_editContact;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_editID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker Dt_addTime;
    }
}

