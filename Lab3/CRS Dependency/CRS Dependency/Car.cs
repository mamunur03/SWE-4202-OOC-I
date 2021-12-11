using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_dependency
{
    public class Car
    {
        public string name;
        public string model;
        public int number;

        public Car(string name, int number, string model)
        {
            this.name = name;
            this.number = number;
            this.model = model;
        }

        public void rented()
        {
            this.number--;
        }
    }
}
