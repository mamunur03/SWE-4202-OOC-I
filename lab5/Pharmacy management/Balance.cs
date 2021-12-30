using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_management
{
    internal class Balance
    {
        public string name;
        
        public int cost1;
        public int cost2;
        public Balance(string name,int cost1,int cost2)
        {
            this.name = name;
            this.cost1 = cost1;
            this.cost2 = cost2;
        }
        
    }
}
