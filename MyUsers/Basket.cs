using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyUsers
{
    /// <summary>
    /// The basket of products class.
    /// </summary>
    class Basket
    {
        // Products themselves.
        public List<Product> Products { get; private set; } = new List<Product>();


        // Adding a product.
        public void Add(Product product)
        {
            Products.Add(product);
        }


        // Removing a product. Currently unavailable.
        public void Remove(Product product)
        {
            try
            {
                Products.Add(product);
            }
            catch
            {
                MessageBox.Show("There is no such a product");
            }
        }
    }
}
