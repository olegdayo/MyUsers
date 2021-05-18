using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MyUsers
{
    static class Shop
    {
        public static List<Customer> Customers { get; private set; } = new List<Customer>();
        public static List<Product> Products { get; private set; } = new List<Product>();
        public static int Index { get; private set; }


        static Shop()
        {
            Load();
        }


        public static bool IsHere(Customer customer)
        {
            int counter = 0;
            foreach(Customer thisCustomer in Customers)
            {
                if(customer.Username == thisCustomer.Username)
                {
                    Index = counter;
                    return true;
                }
                counter++;
            }
            Index = counter;
            return customer.Username + customer.Password.GetHashCode() == Admin.Username + Admin.Password;
        }


        public static void AddCustomer(string name, Basket cart, string phone, string userName, string password, string address)
        {
            if (!IsHere(new Customer(name, cart, phone, userName, password, address)))
            {
                Customers.Add(new Customer(name, cart, phone, userName, password, address));
            }
            else
            {
                MessageBox.Show("Log in denied!");
            }
        }


        public static void Load()
        {
            try
            {
                Customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("Info.json"), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            }
            catch
            {
                Customers = new List<Customer>();
                MessageBox.Show("Cannot load");
            }
        }


        public static void Save()
        {
            try
            {
                File.WriteAllText("Info.json", JsonConvert.SerializeObject(Customers, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All }));
            }
            catch
            {
                MessageBox.Show("Cannot save");
            }
        }
    }
}