using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_116
{
    internal class Manager : Employee
    {
        public static int account_id = 1;
        public Manager(string name, string id, string contact, int salary, string joining_date, string leave)
        {
            this.name = name;
            this.id = id;
            this.contact = contact;
            this.salary = salary;
            this.joining_date = joining_date;
            this.leave = leave;
        }

    }
}
    
