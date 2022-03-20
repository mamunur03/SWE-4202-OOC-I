using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> employeelist = new List<Employee>();

        private void ADD_OnClick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Manager")
            {
                string name = tb_name.Text;
                string id = Manager.account_id.ToString() + "100";
                Manager.account_id++;
                string contact = tb_contact.Text;
                int salary = Convert.ToInt32(tb_salary.Text);
                string joining_date = Dt_addTime.Text;
                string leave = (tb_leave.Text);
                Manager dummy = new Manager(name, id, contact, salary, joining_date, leave);
                employeelist.Add(dummy);
                MessageBox.Show("Employee Has been Added");
            }
            else if (comboBox1.Text == "Salesperson")
            {

                string name = tb_name.Text;
                string id = Salesperson.account_id.ToString() + "200";
                Manager.account_id++;
                string contact = tb_contact.Text;
                int salary = Convert.ToInt32(tb_salary.Text);
                string joining_date = Dt_addTime.Text;
                string leave = (tb_leave.Text);
                Salesperson dummy = new Salesperson(name, id, contact, salary, joining_date, leave);
                employeelist.Add(dummy);
                MessageBox.Show("Employee Has been Added");

            }
            else if(comboBox1.Text =="Typewriter")
            {
                string name = tb_name.Text;
                string id = Typewriter.account_id.ToString() + "300";
                Typewriter.account_id++;
                string contact = tb_contact.Text;
                int salary = Convert.ToInt32(tb_salary.Text);
                string joining_date = Dt_addTime.Text;
                string leave = (tb_leave.Text);
                Typewriter dummy = new Typewriter(name, id, contact, salary, joining_date, leave);
                employeelist.Add(dummy);
                MessageBox.Show("employee has been added");
            }
        }

        private void Search_OnClick(object sender, EventArgs e)
        {

            string id = tb_ID.Text;
            if (Convert.ToInt32(id) %100 != 0)
            { throw new ExceptionID("ID is out of Range"); }
            foreach (Employee dummy in employeelist)
            { if(dummy.id==id)
                { lb_name.Text = dummy.name;
                    lb_date.Text = dummy.joining_date;
                    lb_contact.Text = dummy.contact;
                    lb_salary.Text = Convert.ToString(dummy.salary);
                    lb_leave.Text = dummy.leave;

                }
                MessageBox.Show("Updated");
            }

        }

        private void Update_onClick(object sender, EventArgs e)
        {
            string id = tb_editID.Text;
            foreach (Employee dummy in employeelist)
            {
                if (dummy.id == id)
                {
                    dummy.name = tb_editName.Text ;
                    dummy.contact = tb_editContact.Text;
                    dummy.salary = Convert.ToInt32(tb_editSalary.Text);
                    dummy.leave = tb_editLeave.Text;

                }
            }

        }
    }
}

