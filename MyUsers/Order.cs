using System;
using System.Collections.Generic;
using System.Text;

namespace MyUsers
{
    class Order
    {
        public string ID { get; private set; }
        public DateTime Time { get; private set; }
        public bool Processed { get; private set; }
        public bool Paid { get; private set; }
        public bool Shipped { get; private set; }
        public bool Executed { get; private set; }
        public List<Product> Products { get; private set; } = new List<Product>();
    }
}