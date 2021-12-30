using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_management
{
    internal class Medicine
    {
        public string name;
        public int price ;
        public int quantity;
        public int stprice;
        public string type;
        public int sold_quantity;
       

        public Medicine(string name, int price, int quantity, int stprice, string type,int sold_quantity)
        { this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.stprice = stprice;
            this.type = type;
            this.sold_quantity = sold_quantity;
        }

    }
}
