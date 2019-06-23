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
    /// ManageUser controller.
    /// </summary>
    public partial class UC_ManageUser : UserControl
    {
        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business bs = new Business();

        /// <summary>
        /// ManageUser controller component initializer.
        /// </summary>
        public UC_ManageUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the form.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void UC_ManageUser_Load(object sender, EventArgs e)
        {
            LoadDataGridViewInUsersSection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Creates new datagrid view and fills it with info from the database.
        /// </summary>
        private void LoadDataGridViewInUsersSection()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<user> usersList = bs.GetAllUsers();
            int n = usersList.Count();
            dataGridView1.Rows.Add(n);
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = usersList.ElementAt(i).Id;
                dataGridView1.Rows[i].Cells[1].Value = usersList.ElementAt(i).Username;
                dataGridView1.Rows[i].Cells[2].Value = usersList.ElementAt(i).Password;
            }
        }

        /// <summary>
        /// Deletes users except the logged one.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<user> usersList = bs.GetAllUsers();
            int n = usersList.Count();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == Form_Login.us.Username)
                {
                    MessageBox.Show("Can't delete logged users");
                    return;
                }
                else
                {
                    bs.RemoveUser(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            //MessageBox.Show("Successfully deleted user.");
        }

        /// <summary>
        /// Refreshesh the info in the gridview.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadDataGridViewInUsersSection();
        }

        /// <summary>
        /// Clears the text fields.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxUsername.Clear();
        }

        /// <summary>
        /// Saves new account if possible.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text)) { MessageBox.Show("Username or Password can't be whitespace!!!"); return; }
            else
            {
                if (bs.GetUser(Username) == null)
                {
                    bs.AddUser(Username, Form_Login.EncryptString(Password));
                    MessageBox.Show("Account Added");
                    dataGridView1.Rows.Clear();
                    LoadDataGridViewInUsersSection();
                }

                else
                {
                    MessageBox.Show("Username already exists. Try with another one.");
                }
            }
        }
    }
}
