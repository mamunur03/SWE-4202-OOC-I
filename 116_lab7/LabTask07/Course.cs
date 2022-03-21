using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask07
{
    internal class Course
    {
        public string title;
        public double fee;
        public string level;

        public Course(string title, double fee, string level)
        {
            this.title = title;
            this.fee = fee;
            this.level = level;
        }
    }
}
