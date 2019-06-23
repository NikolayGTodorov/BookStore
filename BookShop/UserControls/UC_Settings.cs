using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Data;
using BookShop.BusinessContext;

namespace BookShop.UserControls
{
    /// <summary>
    /// Settings controller.
    /// </summary>
    public partial class UC_Settings : UserControl
    {
        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business business = new Business();

        /// <summary>
        /// Settings controller component initializer.
        /// </summary>
        public UC_Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns all users from the database.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">contains the event data.</param>
        private void UC_Settings_Load(object sender, EventArgs e)
        {
            GetAndSetUsersInfoFromDb();          
        }

        /// <summary>
        /// Gets the current logged-in user info.
        /// </summary>
        private void GetAndSetUsersInfoFromDb()
        {            
            int id = Form_Login.us.Id;
            string Username = Form_Login.us.Username;
            string Password = Form_Login.us.Password;

            label_Id.Text = id.ToString();
            label_Username.Text = Username.ToString();
            label_Id.Visible = true;
            label_Username.Visible = true;
        }

        /// <summary>
        /// Changes the user password.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.Username = Form_Login.us.Username;
            user.Password = Form_Login.EncryptString(textBox_NewPass.Text);
            string new_Pass = textBox_NewPass.Text;
            string encNewPassTxtBoxText = Form_Login.EncryptString(new_Pass);
            string encForm1usPass = Form_Login.us.Password;

            if (encForm1usPass == encNewPassTxtBoxText  || string.IsNullOrWhiteSpace(textBox_NewPass.Text))
            {
                MessageBox.Show("Type new password!!!");
            }
            else
            {
                business.UpdateUserPass(user);
                MessageBox.Show("Successfully changed password!");
                Form_Login.us.Password = user.Password;                
            }
        }

        /// <summary>
        /// Shows/Hides new password change section.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_showchngpass_Click(object sender, EventArgs e)
        {
            if (label_newpass.Visible == false)
            {
                label_newpass.Visible = true;
                textBox_NewPass.Visible = true;
                button_ChangePass.Visible = true;
            }
            else
            {
                label_newpass.Visible = false;
                textBox_NewPass.Visible = false;
                button_ChangePass.Visible = false;
            }        
        }
    }
}
