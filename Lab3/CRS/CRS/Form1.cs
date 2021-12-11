using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rental_dependency;

namespace Car_Rental_System_102
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void rentCarOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(user_id_name_box.Text);
            string car_name = Convert.ToString(car_name_rent_box.Text);

            foreach(User user in users)
            {
                if(id == user.id)
                {
                    user.rentCar();

                    foreach(Car car in cars)
                    {
                        if (car_name == car.name)
                        {
                            car.rented();
                        }
                    }
                }
            }
        }

        private void save_userOnClick(object sender, EventArgs e)
        {
            string name = Convert.ToString(userName_box.Text);
            string address = Convert.ToString(user_address_box.Text);
            string destination = Convert.ToString(user_dest_box.Text);
            int id = Convert.ToInt32(id_box.Text);
            User user = new User(name, id, address, destination);
            users.Add(user);
            userName_box.Clear();
            user_address_box.Clear();
            user_dest_box.Clear();
            id_box.Clear();
        }

        private void save_car_OnClick(object sender, EventArgs e)
        {
            string name = Convert.ToString(car_name_box.Text);
            string model = Convert.ToString(car_model_box.Text);
            int num = Convert.ToInt32(car_num_box.Text);

            Car car = new Car(name, num, model);
            cars.Add(car);
            car_name_box.Clear();
            car_model_box.Clear();
            car_num_box.Clear();
        }

        private void show_userOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(his_id_box.Text);
            foreach(User user in users)
            {
                if (id == user.id)
                {

                    his_name_box.Text = user.name;
                    his_add_box.Text = user.address;
                    his_dest_box.Text = user.destination;
                    his_rent_box.Text = Convert.ToString(user.rentedNum);
                }
            }
        }

        private void show_CarOnClick(object sender, EventArgs e)
        {
            string name = Convert.ToString(his_carName.Text);
            foreach(Car car in cars)
            {
                if(name == car.name)
                {
                    his_carModel.Text = car.model;
                    his_carUnit.Text = Convert.ToString(car.number);
                }
            }
        }
    }
}
