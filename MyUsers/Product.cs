using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyUsers
{
    class Product
    {
        public string Name { get; private set; }
        public string ID { get; private set; }
        public string Manufactorer { get; private set; }
        public string Country { get; private set; }
        public int Quantity { get; private set; }
        public int Price { get; private set; }


        public Product(string name, string id, string manufactorer, string country, string quantity, string price)
        {
            Name = name;
            ID = id;
            Manufactorer = manufactorer;
            Country = country;
            Random generator = new Random();
            try
            {
                Quantity = int.Parse(quantity);
            }
            catch
            {
                MessageBox.Show("Looks like quantity is enered incorrectly, gonna put random number then.");
                Quantity = generator.Next(1, 1000000);
            }
            try
            {
                Price = int.Parse(price);
            }
            catch
            {
                MessageBox.Show("Looks like price is enered incorrectly, gonna put random number then.");
                Price = generator.Next(1, 1000000);
            }
        }
    }
}