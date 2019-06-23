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
using BookShop.Data;
using BookShopManagement.Forms;
using BookShop.BusinessContext;

namespace BookShop.UserControls
{
    /// <summary>
    /// PurchaseDetails controller.
    /// </summary>
    public partial class UC_PurchaseDetails : UserControl
    {
        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business b = new Business();

        /// <summary>
        /// PurchaseDetails controller component initializer.
        /// </summary>
        public UC_PurchaseDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the form for adding books.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddNewBook abn = new Form_AddNewBook())
            {
                abn.ShowDialog();

            }

            dataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        /// <summary>
        /// Calls LoadDataGridView method and disables the search box.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void UC_PurchaseDetails_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            textBoxSearchBox.Enabled = false;
        }

        /// <summary>
        /// Loads the gridview with the info for all books from the database
        /// and their child information.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void LoadDataGridView()
        {
            List<book> booksList = b.GetAllBooks();
            int n = b.GetAllBarcodesCount();
            dataGridView1.Rows.Add(n);

            for (int i = 0; i < n; i++)
            {
                booktype booktype = b.GetBookType(booksList.ElementAt(i));

                dataGridView1.Rows[i].Cells[0].Value = booksList.ElementAt(i).Book1;
                dataGridView1.Rows[i].Cells[1].Value = booksList.ElementAt(i).Author;
                dataGridView1.Rows[i].Cells[2].Value = booksList.ElementAt(i).Publisher;
                dataGridView1.Rows[i].Cells[3].Value = booksList.ElementAt(i).Number;
                dataGridView1.Rows[i].Cells[4].Value = booksList.ElementAt(i).Price.ToString("N2") + " $";
                dataGridView1.Rows[i].Cells[5].Value = (booksList.ElementAt(i).Price + 7).ToString("N2") + " $";
                dataGridView1.Rows[i].Cells[7].Value = booksList.ElementAt(i).barcodeId;
                dataGridView1.Rows[i].Cells[6].Value = booktype.Type;
            }
        }

        /// <summary>
        /// Checks if there is selected item of the checkbox and enables the text field.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSearchBy.SelectedIndex == 0 || comboBoxSearchBy.SelectedIndex == 1 || comboBoxSearchBy.SelectedIndex == 2 || comboBoxSearchBy.SelectedIndex == 3)
            {
                textBoxSearchBox.Enabled = true;
            }
        }

        /// <summary>
        /// The book searcher by book title, author, barcode and publisher criterias.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_Search_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)//book title
            {
                string searchValue = textBoxSearchBox.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowIndex;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[rowIndex].Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (comboBoxSearchBy.SelectedIndex == 1)//Author
            {
                string searchValue = textBoxSearchBox.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowIndex;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;

                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[rowIndex].Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (comboBoxSearchBy.SelectedIndex == 2)//Barcode
            {
                string searchValue = textBoxSearchBox.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowIndex;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[7].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;

                        rowIndex = row.Index;
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[rowIndex].Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        dataGridView1.Focus();
                        break;
                    }
                }
            }
            else if (comboBoxSearchBy.SelectedIndex == 3)//Publisher
            {
                string searchValue = textBoxSearchBox.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                int rowIndex;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[2].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;

                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[rowIndex].Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        /// <summary>
        /// Opens the form for book restocking.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonRestock_Click(object sender, EventArgs e)
        {
            using (Form_AddStock abn = new Form_AddStock())
            {
                abn.ShowDialog();
            }
            dataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        /// <summary>
        /// Refreshes the application info.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
