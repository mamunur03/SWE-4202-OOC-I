using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_dependency
{
    public class User
    {
        public string name;
        public int id;
        public string address;
        public string destination;
        public int rentedNum = 0;
        public User(string name, int id, string address, string destination)
        {
            this.name = name;
            this.id = id;
            this.address = address;
            this.destination = destination;

        }
        public void rentCar()
        {
            rentedNum++;
        }

    }
}

