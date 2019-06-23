using BookShop.Data;
using BookShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.BusinessContext;

namespace BookShop
{
    /// <summary>
    /// The login form.
    /// Contains info about the current avaible books and registered users.
    /// </summary>
    public partial class Form_Login : Form
    {
        /// <value>The logged-in user.</value>
        public static user us;

        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business business = new Business();

        /// <value>Total users count from the database.</value>
        public static int usersCount;

        /// <value>Total books count from the database.</value>
        public static int booksCount;

        /// <summary>
        /// Login form initializer.
        /// </summary>
        public Form_Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Encrypts the user password.
        /// </summary>
        /// <returns>
        /// Returns the encrypted password.
        /// </returns>
        /// <param name="strEncryped">The password for encryption.</param>
        public static string EncryptString(string strEncryped)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncryped);
            string encryptedPassword = Convert.ToBase64String(b);
            return encryptedPassword;
        }

        /// <summary>
        /// Decrypts the user password.
        /// </summary>
        /// <returns>
        /// Returns the decrypted password.
        /// </returns>
        /// <param name="strEncryped">The password for decryption.</param>
        public static string DecryptString(string encrString)
        {
            byte[] b = Convert.FromBase64String(encrString);
            string decryptedPassword = System.Text.ASCIIEncoding.ASCII.GetString(b);
            return decryptedPassword;
        }

        /// <summary>
        /// Logs-in users.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_Login_Click(object sender, EventArgs e)
        {
            string Username = textBox_Username.Text;
            string password = textBox_Password.Text;
            us = business.GetUser(Username);
            usersCount = business.GetAllUsers().Count();
            booksCount = business.GetAllBooks().Count();

            try
            {
                if (us.Password == EncryptString(password))
                {
                    MessageBox.Show("Welcome " + Username, "Welcome");
                    Form_Dashboard fd = new Form_Dashboard();
                    fd.Show();
                    fd.FormClosing += (obj, args) => { this.Show(); };
                    this.Hide();
                    textBox_Username.Clear();
                    textBox_Password.Clear();
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong. Try again.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Username or Password is wrong. Try again.");
            }
        }

        /// <summary>
        /// Creates new user.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_Register_Click(object sender, EventArgs e)
        {
            string Username = textBox_Username.Text;
            string password = textBox_Password.Text;
            
            if (string.IsNullOrWhiteSpace(textBox_Username.Text) || string.IsNullOrWhiteSpace(textBox_Password.Text)) { MessageBox.Show("Username or Password can't be whitespace!!!"); return; }
            else  
            {
                if (business.GetUser(Username) == null)
                {
                    EncryptString(password);
                    business.AddUser(Username, EncryptString(password));
                    MessageBox.Show("You can now log in your account!");
                }
                else
                {
                    MessageBox.Show("Username already exists. Try again.");
                }
            }
        }

        /// <summary>
        /// Hides the user password.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_HideShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
            this.button_HideShowPass.Image = BookShop.Properties.Resources.visible_30px_blue;
        }

        /// <summary>
        /// Exposes the user password.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_HideShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = false;
            this.button_HideShowPass.Image = BookShop.Properties.Resources.invisible_30px_blue;
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_TurnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
