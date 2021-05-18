using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyUsers
{
    /// <summary>
    /// The form which shows cart.
    /// </summary>
    public partial class Cart : Form
    {
        // Table of products.
        public DataTable dt;


        /// <summary>
        /// Initializing.
        /// </summary>
        public Cart()
        {
            InitializeComponent();
            // Creating source for DGV.
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("ID");
            dt.Columns.Add("Manufactorer");
            dt.Columns.Add("Country");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");
            dt.Columns.Add("Processed");
            dt.Columns.Add("Paid");
            dt.Columns.Add("Shipped");
            dt.Columns.Add("Executed");
            dataGridView1.DataSource = dt;
            try
            {
                dtFill();
            }
            catch
            {
            }
        }


        /// <summary>
        /// Updates products in table.
        /// </summary>
        public void ReFresh()
        {
            // Clearing.
            dt.Clear();
            // And reinserting.
            foreach (Product product in Shop.Customers[Shop.Index].Cart.Products)
            {
                dt.Rows.Add(product.Name, product.ID, product.Manufactorer, product.Country, product.Quantity, product.Price, false, true, false, false);
            }
        }


        // Filling.
        public void dtFill()
        {
            // Adding every product of user.
            foreach(Product product in Shop.Customers[Shop.Index].Cart.Products)
            {
                dt.Rows.Add(product.Name, product.ID, product.Manufactorer, product.Country, product.Quantity, product.Price, false, false, false, false);
            }
        }


        // Unexpected mouseclick.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
