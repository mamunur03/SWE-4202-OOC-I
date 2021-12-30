using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Medicine> medicine = new List<Medicine>();
        List<Balance> balance = new List<Balance>();
        int balance1;

        private void AddOnClick(object sender, EventArgs e)
        {
            string name = tb_medicine.Text;
            int price = Convert.ToInt32(tb_price.Text);
            int quantity = Convert.ToInt32(tb_quantity.Text);

            int stprice = Convert.ToInt32(tb_stprice.Text);
            string type = tb_type.Text;
            int sold_quantity = 0;

            Medicine medicines = new Medicine(name, price, quantity, stprice, type, sold_quantity);
            medicine.Add(medicines);
            int cost1 = quantity * stprice;
            int cost2 = 0;
            Balance balances = new Balance(name, cost1, cost2);
            balance.Add(balances);
            comboBox1.Items.Add(name);
            MessageBox.Show("Medicine Saved!");


        }

        private void SellOnClick(object sender, EventArgs e)
        {
            string name = tb_sellname.Text;
            int quantity = Convert.ToInt32(tb_sellquantity.Text);
            foreach (Medicine medicines in medicine)
            {
                if (medicines.name == name)
                {
                    MessageBox.Show(quantity.ToString());
                    medicines.quantity -= quantity;
                    medicines.sold_quantity = quantity;
                }

            foreach (Balance balances in balance)
                    {
                        if (balances.name == name)
                        {
                            balances.cost2 = quantity * medicines.price;
                        }
                    }
               


            }
        }

        private void ShowBalanceOnClick(object sender, EventArgs e)
        {

            foreach (Balance balances in balance)
            {
                balance1 = 100 - balances.cost1 + balances.cost2;
            }
            MessageBox.Show(Convert.ToString(balance1));


        }

        private void ShowhistoryOnClick(object sender, EventArgs e)
        {
            
            

            foreach (Medicine medicines in medicine)
            {
                string name = comboBox1.Text;
                if (medicines.name == name)
                {
                    
                    tb_historyleft.Text = Convert.ToString(medicines.quantity);
                    tb_historysold.Text = Convert.ToString(medicines.sold_quantity);
                }

            }
        }
    }
}
