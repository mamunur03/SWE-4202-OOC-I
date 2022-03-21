using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask07
{
    public partial class Form1 : Form
    {
        Course_Enrollment_System main_system = new Course_Enrollment_System();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Participant_OnClick(object sender, EventArgs e)
        {
            string name = Input_Participant_Name.Text;
            int reg_no = Convert.ToInt32(Input_Participant_Reg_No.Text);
            int contact_info = Convert.ToInt32(Input_Participant_Contact_No.Text);
            string email = Input_Participant_Email.Text;
            

            if (Student_Button.Checked == true)
            {
                if (Participant_Level_Beginner.Checked == true)
                {
                    Student dummy = new Student(reg_no, name, contact_info, email, Participant_Level_Beginner.Text);
                    main_system.Students_list.Add(dummy);
                    MessageBox.Show("Student has been added!");
                }    
                else if (Participant_Level_Intermediate.Checked == true)
                {
                    Student dummy = new Student(reg_no, name, contact_info, email, Participant_Level_Intermediate.Text);
                    main_system.Students_list.Add(dummy);
                    MessageBox.Show("Student has been added!");
                }
                else if (Participant_Level_Advanced.Checked == true)
                {
                    Student dummy = new Student(reg_no, name, contact_info, email, Participant_Level_Advanced.Text);
                    main_system.Students_list.Add(dummy);
                    MessageBox.Show("Student has been added!");
                }
                else MessageBox.Show("Select a level");
            }
            else if (Professional_Button.Checked == true)
            {
                if (Participant_Level_Beginner.Checked == true)
                {
                    Professional dummy = new Professional(reg_no, name, contact_info, email, Participant_Level_Beginner.Text);
                    main_system.professionals_list.Add(dummy);
                    MessageBox.Show("Professional has been added!");
                }
                else if (Participant_Level_Intermediate.Checked == true)
                {
                    Professional dummy = new Professional(reg_no, name, contact_info, email, Participant_Level_Intermediate.Text);
                    main_system.professionals_list.Add(dummy);
                    MessageBox.Show("Professional has been added!");
                }
                else if (Participant_Level_Advanced.Checked == true)
                {
                    Professional dummy = new Professional(reg_no, name, contact_info, email, Participant_Level_Advanced.Text);
                    main_system.professionals_list.Add(dummy);
                    MessageBox.Show("Professional has been added!");
                }
                else MessageBox.Show("Select a level");
            }
            else MessageBox.Show("Select a type");
            Dropdown_Student_ID.Items.Clear();
            foreach (Student dummy in main_system.Students_list)
            {
                Dropdown_Student_ID.Items.Add(dummy.reg_no);
            }
        }

        private void AddCourse_OnClick(object sender, EventArgs e)
        {
            string title = Input_Course_Title.Text;
            double fee = Convert.ToDouble(Input_Course_Fee.Text);

            if(Course_Level_Beginner.Checked == true)
            {
                Course dummy = new Course(title, fee, Course_Level_Beginner.Text);
                main_system.course_list.Add(dummy);
                MessageBox.Show("Course has been added");
            }
            else if (Course_Level_Intermediate.Checked == true)
            {
                Course dummy = new Course(title, fee, Course_Level_Intermediate.Text);
                main_system.course_list.Add(dummy);
                MessageBox.Show("Course has been added");
            }
            else if (Course_Level_Advanced.Checked == true)
            {
                Course dummy = new Course(title, fee, Course_Level_Advanced.Text);
                main_system.course_list.Add(dummy);
                MessageBox.Show("Course has been added");
            }
            else MessageBox.Show("Select a level");

            
        }

        private void Student_Selected(object sender, EventArgs e)
        {
            int reg = Convert.ToInt32(Dropdown_Student_ID.Text);
            foreach(Student dummy_student in main_system.Students_list)
            {
                if(reg == dummy_student.reg_no)
                {
                    Dropdown_Course_ID.Items.Clear();
                    foreach (Course dummy_course in main_system.course_list)
                    {
                        if(dummy_student.level == dummy_course.level)
                        {
                            Dropdown_Course_ID.Items.Add(dummy_course.title);
                        }
                    }
                }
            }
        }

        private void Course_Selected(object sender, EventArgs e)
        {
            string title = Dropdown_Course_ID.Text;
            foreach(Course dummy in main_system.course_list)
            {
                if(title == dummy.title)
                {
                    Amount_Label.Text = dummy.fee.ToString();
                }
            }
        }

        private void Enroll_OnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Dropdown_Student_ID.Text);
            string title = Dropdown_Course_ID.Text;
            string date = Enrollment_date.Text;
            foreach(Student dummy in main_system.Students_list)
            {
                if(id == dummy.reg_no)
                {
                    dummy.course = title;
                    dummy.date = date;
                    dummy.fee = 200;
                }
            }

            Student_Enrolled.Items.Clear();
            foreach (Student dummy in main_system.Students_list)
            {
                Student_Enrolled.Items.Add(dummy.reg_no);
            }

            MessageBox.Show("Ënrolled Successfully");
        }

        private void Show_OnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Student_Enrolled.Text);
            foreach (Student dummy in main_system.Students_list)
            {
                if (id == dummy.reg_no)
                {
                    Output_Enrolled_Courses.Items.Clear();
                    Output_Enrolled_Courses.Items.Add(dummy.getInfo());
                }
            }
        }
    }
}
