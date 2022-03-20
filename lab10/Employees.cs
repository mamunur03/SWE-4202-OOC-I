using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Employees
    {
        public int EMPLOYEE_ID;

        public string FIRST_NAME;
        public string LAST_NAME;
        public string EMAIL;
        public string PHONE_NUMBER;
        public string HIRE_DATE;
        public string JOB_ID;
        public int SALARY;
        public int MANAGER_ID;
        public int DEPARTMENT_ID;


        public Employees(int EMPLOYEE_ID, string FIRST_NAME, string LAST_NAME, string EMAIL,string PHONE_NUMBER, string HIRE_DATE, string JOB_ID, int SALARY, int MANAGER_ID, int DEPARTMENT_ID)
        { this.EMPLOYEE_ID = EMPLOYEE_ID;
            this.FIRST_NAME = FIRST_NAME;
            this.LAST_NAME = LAST_NAME;
            this.EMAIL = EMAIL;
            this.PHONE_NUMBER = PHONE_NUMBER;
            this.HIRE_DATE = HIRE_DATE;
            this.JOB_ID = JOB_ID;
            this.SALARY = SALARY;
            this.MANAGER_ID = MANAGER_ID;
            this.DEPARTMENT_ID = DEPARTMENT_ID;
        }

    }
}
