using System;
using System.Collections.Generic;
using System.Text;

namespace MyUsers
{
    /// <summary>
    /// The user of shop.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Stats.
        /// </summary>
        public string Name { get; private set; }
        public Basket Cart { get; private set; }
        public string Phone { get; private set; }
        public string Username { get; private set; }
        public int Password { get; private set; }
        public string Address { get; private set; }
        public List<Order> Orders { get; private set; } = new List<Order>();


        /// <summary>
        /// Creating.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cart"></param>
        /// <param name="phone"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="address"></param>
        public Customer(string name, Basket cart, string phone, string userName, string password, string address)
        {
            Name = name;
            Cart = cart;
            Phone = Phone;
            Username = userName;
            // The hash.
            Password = password.GetHashCode();
            Address = address;
        }
    }
}
