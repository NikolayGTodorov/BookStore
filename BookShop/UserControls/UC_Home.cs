using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Forms;
using BookShop.BusinessContext;

namespace BookShop.UserControls
{
    /// <summary>
    /// Home controller.
    /// </summary>
    public partial class UC_Home : UserControl
    {
        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business bs = new Business();

        /// <summary>
        /// Home controller component initializer.
        /// </summary>
        public UC_Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the current users and books count.
        /// </summary>
        private void LoadAvailableBooksAndUsersCount()
        {
            label_Customers_Registered.Text = bs.GetAllUsers().Count().ToString();
            label_Amount_Available.Text = bs.GetAllBooks().Count().ToString();
        }

        /// <summary>
        /// Calls the LoadAvailableBooksAndUsersCount method.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void UC_Home_Load(object sender, EventArgs e)
        {
            LoadAvailableBooksAndUsersCount();
        }

        /// <summary>
        /// Refreshes the application info.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            LoadAvailableBooksAndUsersCount();
        }
    }
}
