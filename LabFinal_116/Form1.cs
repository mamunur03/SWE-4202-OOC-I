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

namespace LabFinal_116
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            
            InitializeComponent();
            using (var reader = new StreamReader(@"D:\2nd sem\LabFinal_116\SWE4201MarkSheet1.csv"))
            {
              

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student dummy = new Student();

                    dummy.id = values[0];
                    dummy.name = values[1];
                    if (values[2] == "")
                    {
                        dummy.attendance = 0;

                    }
                    else
                    {
                        dummy.attendance = Convert.ToInt32(values[2]);
                    }
                    if (values[3] == "")
                    {
                        dummy.Quiz1 = 0;

                    }
                    else
                    {
                        dummy.Quiz1 = Convert.ToInt32(values[3]);
                    }
                    if (values[4] == "")
                    {
                        dummy.Quiz2 = 0;

                    }
                    else
                    {
                        dummy.Quiz2 = Convert.ToInt32(values[4]);
                    }
                    if (values[5] == "")
                    {
                        dummy.Quiz3 = 0;

                    }
                    else
                    {
                        dummy.Quiz3 = Convert.ToInt32(values[5]);
                    }
                    if (values[6] == "")
                    {
                        dummy.Quiz4 = 0;

                    }
                    else
                    {
                        dummy.Quiz4 = Convert.ToInt32(values[6]);
                    }
                    if (values[7] == "")
                    {
                        dummy.Mid = 0;

                    }
                    else
                    {
                        dummy.Mid = Convert.ToInt32(values[7]);
                    }
                    if (values[8] == "")
                    {
                        dummy.Final = 0;

                    }
                    else
                    {
                        dummy.Final = Convert.ToInt32(values[8]);
                    }
                    if (values[9] == "")
                    {
                        dummy.Viva = 0;

                    }
                    else
                    {
                        dummy.Viva = Convert.ToInt32(values[9]);
                    }
                    
                    dummy.CalcQuiz();
                    dummy.CalcTotal();
                    dummy.CalcPercentage();
                    dummy.CalcGrade();

                    students.Add(dummy);

                }
                //reader.Close();

                var student1 = from student in students
                               select student;

                foreach (var dummy1 in student1)
                {
                    StudentInfo.Items.Add(dummy1.id + "\t" + dummy1.name + "\t" + dummy1.percentage + "%\t" + dummy1.grade);

                }


            }
        }

        private void SearchOn_Click(object sender, EventArgs e)
        {
            string ID = tb_ID.Text;

            var student2 = from student in students
                           where student.id == ID
                           select student;

            foreach (var dummy2 in student2)
            {
               

                label1.Text = Convert.ToString("Attendance:\t" + dummy2.attendance);
                label2.Text = Convert.ToString("Quiz 1:\t" + dummy2.Quiz1);
                label3.Text = Convert.ToString("Quiz 2:\t" + dummy2.Quiz2);
                label4.Text = Convert.ToString("Quiz 3:\t" + dummy2.Quiz3);
                label5.Text = Convert.ToString("Quiz 4:\t" + dummy2.Quiz4);
                label6.Text = Convert.ToString("Quiz Total(Best 3):\t" + dummy2.quizresult);
                label7.Text = Convert.ToString("Mid:\t" + dummy2.Mid);
                label8.Text = Convert.ToString("Final:\t" + dummy2.Final);
                label9.Text = Convert.ToString("Viva:\t" + dummy2.Viva);
                label10.Text = Convert.ToString("Total (Out of 300):\t" + dummy2.total);
                label11.Text = Convert.ToString("Percentage:\t" + dummy2.percentage + "%");
                label12.Text = Convert.ToString("Grade:\t" + dummy2.grade);

            }

        }

        
    }
}
