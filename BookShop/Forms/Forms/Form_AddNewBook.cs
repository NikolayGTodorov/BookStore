using BookShop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.BusinessContext;

namespace BookShop.Forms
{
    /// <summary>
    /// Form for adding new books.
    /// </summary>
    public partial class Form_AddNewBook : Form
    {
        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business business = new Business();

        /// <summary>
        /// AddNewBook form initializer.
        /// </summary>
        public Form_AddNewBook()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds new book into the database.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Fields can't be empty");
                        return;
                    }
                }
            }

            int parsedValue;
            float parsedValue2;

            if (!int.TryParse(textBoxQuantity.Text, out parsedValue) || !float.TryParse(textBoxPrice.Text, out parsedValue2) || float.Parse(textBoxPrice.Text) <= 0 || int.Parse(textBoxQuantity.Text) <= 0)
            {
                MessageBox.Show("Quantity and Price are positive numbers!!!", "Warning");
                return;
            }

            else
            {
                string BookTitle = textBoxTitle.Text;
                string Author = textBoxAuthor.Text;
                int Quantity = int.Parse(textBoxQuantity.Text);
                string Publisher = textBoxPublisher.Text;
                float CostPrice = float.Parse(textBoxPrice.Text);
                float SellingPrice = CostPrice + 7;
                string ComboBoxTxt = comboBoxGenres.Text;

                if (comboBoxGenres.Text == "")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 101);
                }
                else if (comboBoxGenres.Text == "Action")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 102);
                }
                else if (comboBoxGenres.Text == "Adventure")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 103);
                }
                else if (comboBoxGenres.Text == "Crime")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 104);
                }
                else if (comboBoxGenres.Text == "Drama")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 105);
                }
                else if (comboBoxGenres.Text == "Fantasy")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 106);
                }
                else if (comboBoxGenres.Text == "Horror")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 107);
                }
                else if (comboBoxGenres.Text == "Thriller")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 108);
                }
                else if (comboBoxGenres.Text == "Science Fiction")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 109);
                }
                else if (comboBoxGenres.Text == "Guide")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 110);
                }
                else if (comboBoxGenres.Text == "Health")
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 111);
                }
                else
                {
                    business.AddBook(BookTitle, Author, Publisher, Quantity, CostPrice, SellingPrice, 112);
                }

                MessageBox.Show("Successfully Added", "Success");
                
                this.Close();
            }
        }

        /// <summary>
        /// Clears all input fields.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxQuantity.Text = "";
            textBoxPublisher.Text = "";
            textBoxPrice.Text = "";
        }

        /// <summary>
        /// Closes the form for adding books.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("There is unsaved work. Are you sure you want to leave?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                return;
            }            
        }
    }
}
