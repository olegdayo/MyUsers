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
    /// Shop form.
    /// </summary>
    public partial class ShopForm : Form
    {
        // Media player and data.
        System.Media.SoundPlayer selected = new System.Media.SoundPlayer();
        DataTable dt = new DataTable();


        /// <summary>
        /// Initializing.
        /// </summary>
        public ShopForm()
        {
            InitializeComponent();
            // Shop theme.
            try
            {
                Tem tem = new Tem();
                tem.Show();
                selected.SoundLocation = "mus_temshop.wav";
                selected.PlayLooping();
            }
            catch
            {
            }
            // Adding info.
            shopCreation();
            dataGridView1.DataSource = dt;
            trackBar1.Maximum = Shop.Products.Count;
            trackBar1.Value = 0;
        }


        /// <summary>
        /// Creating products.
        /// </summary>
        public void shopCreation()
        {
            // Creating columns.
            dt.Columns.Add("Name");
            dt.Columns.Add("ID");
            dt.Columns.Add("Manufactorer");
            dt.Columns.Add("Country");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");
            // Adding products.
            for (int i = 0; i < 1000; i++)
            {
                dt.Rows.Add($"Product{i}", Math.Abs($"ID{i}".GetHashCode()), $"Manufactorer{i}", "Tuared", Math.Abs($"{i}".GetHashCode()), Math.Abs($"{i}".GetHashCode()));
                Shop.Products.Add(new Product($"Product{i}", Math.Abs($"ID{i}".GetHashCode()).ToString(), $"Manufactorer{i}", "Tuared", Math.Abs($"{i}".GetHashCode()).ToString(), Math.Abs($"{i}".GetHashCode()).ToString()));
            }
        }


        /// <summary>
        /// Paying.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pay_Click(object sender, EventArgs e)
        {
            // Addign paynment information.
            Cart.Refresh();
        }


        /// <summary>
        /// Adding products.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addproduct_Click(object sender, EventArgs e)
        {
            // Adding product to cart.
            Product product = new Product(dt.Rows[trackBar1.Value][0].ToString(), dt.Rows[trackBar1.Value][1].ToString(), dt.Rows[trackBar1.Value][2].ToString(), dt.Rows[trackBar1.Value][3].ToString(), dt.Rows[trackBar1.Value][4].ToString(), dt.Rows[trackBar1.Value][5].ToString());
            Shop.Customers[Shop.Index].Cart.Add(product);
            cart.ReFresh();
        }


        // Lol why am I clicking everywhere?
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }


        // Cart form.
        public Cart cart = new Cart();


        /// <summary>
        /// Cart form openning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cart_Click(object sender, EventArgs e)
        {
            // Variable is for non-achivable previous forms.
            var playingCards = cart.ShowDialog();
        }


        // Really large oof.
        private void ShopForm_Load(object sender, EventArgs e)
        {
        }
    }
}