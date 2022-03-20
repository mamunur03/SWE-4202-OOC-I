namespace lab10
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
            this.EmployeeInfo = new System.Windows.Forms.ListBox();
            this.tb_seachID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_JobID = new System.Windows.Forms.Label();
            this.lb_salary = new System.Windows.Forms.Label();
            this.lb_managerID = new System.Windows.Forms.Label();
            this.lb_deptID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.FormattingEnabled = true;
            this.EmployeeInfo.ItemHeight = 16;
            this.EmployeeInfo.Location = new System.Drawing.Point(136, 62);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(319, 404);
            this.EmployeeInfo.TabIndex = 0;
            // 
            // tb_seachID
            // 
            this.tb_seachID.Location = new System.Drawing.Point(765, 62);
            this.tb_seachID.Name = "tb_seachID";
            this.tb_seachID.Size = new System.Drawing.Size(158, 22);
            this.tb_seachID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Job ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salary";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(872, 109);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Department ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Manager ID";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(810, 182);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(0, 16);
            this.lb_name.TabIndex = 11;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(810, 215);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(0, 16);
            this.lb_ID.TabIndex = 12;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(810, 251);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(0, 16);
            this.lb_phone.TabIndex = 13;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(810, 289);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(0, 16);
            this.lb_date.TabIndex = 14;
            // 
            // lb_JobID
            // 
            this.lb_JobID.AutoSize = true;
            this.lb_JobID.Location = new System.Drawing.Point(808, 323);
            this.lb_JobID.Name = "lb_JobID";
            this.lb_JobID.Size = new System.Drawing.Size(0, 16);
            this.lb_JobID.TabIndex = 15;
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.Location = new System.Drawing.Point(810, 354);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(0, 16);
            this.lb_salary.TabIndex = 16;
            // 
            // lb_managerID
            // 
            this.lb_managerID.AutoSize = true;
            this.lb_managerID.Location = new System.Drawing.Point(810, 388);
            this.lb_managerID.Name = "lb_managerID";
            this.lb_managerID.Size = new System.Drawing.Size(0, 16);
            this.lb_managerID.TabIndex = 17;
            // 
            // lb_deptID
            // 
            this.lb_deptID.AutoSize = true;
            this.lb_deptID.Location = new System.Drawing.Point(810, 421);
            this.lb_deptID.Name = "lb_deptID";
            this.lb_deptID.Size = new System.Drawing.Size(0, 16);
            this.lb_deptID.TabIndex = 18;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(652, 450);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(40, 16);
            this.Name.TabIndex = 19;
            this.Name.Text = "email";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(797, 450);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(0, 16);
            this.lb_email.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 503);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.lb_deptID);
            this.Controls.Add(this.lb_managerID);
            this.Controls.Add(this.lb_salary);
            this.Controls.Add(this.lb_JobID);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_seachID);
            this.Controls.Add(this.EmployeeInfo);
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeInfo;
        private System.Windows.Forms.TextBox tb_seachID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_JobID;
        private System.Windows.Forms.Label lb_salary;
        private System.Windows.Forms.Label lb_managerID;
        private System.Windows.Forms.Label lb_deptID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label lb_email;
    }
}

