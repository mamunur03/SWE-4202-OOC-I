using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_116
{
    public class ExceptionID : ApplicationException
    {
        public ExceptionID(string message) : base(message)
        {

        }
    }
    internal class Employee
    {
        
        public string id;
        public string name;
        public string contact;
        public int salary;
        public string joining_date;
        public string leave;

    }
}
