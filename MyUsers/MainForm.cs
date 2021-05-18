using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyUsers
{
    /// <summary>
    /// Registration form.
    /// </summary>
    public partial class SignForm : Form
    {
        // Initialization.
        public SignForm()
        {
            InitializeComponent();
            // Oh yes.
            try
            {
                System.Media.SoundPlayer selected = new System.Media.SoundPlayer();
                selected.SoundLocation = "mus_OhYes.wav";
                selected.Play();
            }
            catch
            {
            }
        }


        /// <summary>
        /// Logging in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInClick(object sender, EventArgs e)
        {
            // Owner log in.
            if(logInUN.Text + logInPass.Text.GetHashCode() == Admin.Username + Admin.Password)
            {
                Temmie temmie = new Temmie();
                var tem = temmie.ShowDialog();
                try
                {
                    Process.Start(".\\Info.exe");
                }
                catch
                {
                    MessageBox.Show("OOF");
                }
                return;
            }
            // User log in.
            if(Shop.IsHere(new Customer("", new Basket(), "", logInUN.Text, logInPass.Text, "")))
            {
                ShopForm sf = new ShopForm();
                var mediocorVariableName = sf.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no such a user!");
            }
        }


        /// <summary>
        /// Registration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpClick(object sender, EventArgs e)
        {
            Shop.AddCustomer(regName.Text, new Basket(), regPhone.Text, regUN.Text, regPass.Text, regAddress.Text);
        }


        /// <summary>
        /// Saving changes on closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Shop.Save();
        }


        // Accidently added.
        private void SignForm_Load(object sender, EventArgs e)
        {
        }
    }
}