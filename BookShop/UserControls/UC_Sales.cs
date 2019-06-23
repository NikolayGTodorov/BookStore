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
using System.Drawing.Drawing2D;
using BookShop.BusinessContext;

namespace BookShop.UserControls
{
    /// <summary>
    /// Sales controller.
    /// </summary>
    public partial class UC_Sales : UserControl
    {
        /// <value>Contains the purchased books.</value>
        public static List<book> books = new List<book>();

        /// <value>Contains the quantities of every purchased book.</value>
        public static List<int> quantity = new List<int>();

        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business business = new Business();

        /// <value>Contains the current searched book.</value>
        private book book = null;

        /// <value>Sets the amount to 0.</value>
        private static float amount = 0;

        /// <value>The total amount value.</value>
        public float amountValue
        {
            get
            {
                return amount;
            }
        }

        /// <value>Sales controller component initializer.</value>
        public UC_Sales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finishes the order if possible.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_Finish_Click(object sender, EventArgs e)
        {
            if (listViewCart.Items.Count == 0)
            {
                MessageBox.Show("Add books to cart please!");
            }
            else
            {
                foreach (ListViewItem item in listViewCart.Items)
                {
                    books.Add(business.GetBookByBarcode(int.Parse(item.SubItems[3].Text)));
                    quantity.Add(int.Parse(item.SubItems[1].Text));
                }

                using (Form_FinishOrder uf = new Form_FinishOrder())
                {
                    uf.ShowDialog();
                    
                }

                listViewCart.Items.Clear();
                books = new List<book>();
                quantity = new List<int>();
                label_Amount.Text = "0.00 $";
            }
        }

        /// <summary>
        /// Finds book by barcode id.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_FindByBarcode_Click(object sender, EventArgs e)
        {         
            if (string.IsNullOrWhiteSpace(textBox_Barcode.Text))
            {
                MessageBox.Show("Barcode can't be null or whitespace");
                return;
            }

            int parsedValue;

            if (!int.TryParse(textBox_Barcode.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            int barcodeInt = int.Parse(textBox_Barcode.Text);
            button_AddToCart.Enabled = false;

            if (barcodeInt >= business.GetAllBooks().First().barcodeId && barcodeInt <= business.GetAllBooks().Last().barcodeId)
            {
                book = business.GetBookByBarcode(barcodeInt);
                textBox_BookTitle.Text = book.Book1;
                textBox_Author.Text = book.Author;
                textBox_Price.Text = book.Price.ToString("N2");
                textBox_Publisher.Text = book.Publisher;
                button_AddToCart.Enabled = true;
            } 
            else
            {
                MessageBox.Show("Barcode is invalid, try another one.");
            }
        }

        /// <summary>
        /// Adds books to the cart.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_AddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Barcode.Text))
            {
                MessageBox.Show("Barcode can't be null or whitespace");
                return;
            }

            int parsedValue;

            if (!int.TryParse(textBox_Barcode.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            int quantity = business.GetBookByBarcode(int.Parse(textBox_Barcode.Text)).Number;

            if (quantity < 1)
            {
                MessageBox.Show("There are no books left...");
                return;
            }
            else if (listViewCart.FindItemWithText(textBox_BookTitle.Text) != null)
            {
                if (int.Parse(listViewCart.FindItemWithText(textBox_BookTitle.Text).SubItems[1].Text) == quantity)
                {
                    MessageBox.Show("Can't add more than available!");
                    return;
                }
            }

            string[] row = { textBox_BookTitle.Text, "1", textBox_Price.Text, textBox_Barcode.Text };

            var listViewItem = new ListViewItem(row);

            if (listViewCart.FindItemWithText(textBox_BookTitle.Text) != null)
            {
                amount = 0;
                listViewCart.FindItemWithText(textBox_BookTitle.Text).SubItems[1].Text = int.Parse(listViewCart.FindItemWithText(textBox_BookTitle.Text).SubItems[1].Text) + 1 + "";
                CalculateAmount();
            }
            else
            {
                listViewCart.Items.Add(listViewItem);
                CalculateAmount();
            }
        }

        /// <summary>
        /// Sets the listViewCart row selection to true and the total amount to 0.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void UC_Sales_Load(object sender, EventArgs e)
        {
            listViewCart.FullRowSelect = true;
            amount = 0;
        }

        /// <summary>
        /// Clears all textboxes information.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void textBox_Barcode_TextChanged(object sender, EventArgs e)
        {
            textBox_BookTitle.Clear();
            textBox_Author.Clear();
            textBox_Price.Clear();
            textBox_Publisher.Clear();
            button_AddToCart.Enabled = false;
        }

        /// <summary>
        /// Clears the cart.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_ClearCart_Click(object sender, EventArgs e)
        {
            if (listViewCart.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("Your cart will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    listViewCart.Items.Clear();
                    books = new List<book>();
                    quantity = new List<int>();
                    amount = 0;
                    CalculateAmount();
                    
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
            else
            {
                MessageBox.Show("There are no items to be deleted!");
            }
        }

        /// <summary>
        /// Calculates the total purchase sum.
        /// </summary>
        public void CalculateAmount()
        {
            amount = 0;

            for (int i = 0; i < listViewCart.Items.Count; i++)
            {
                amount += float.Parse(listViewCart.Items[i].SubItems[2].Text) * float.Parse(listViewCart.Items[i].SubItems[1].Text);
            }

            label_Amount.Text = amount.ToString("N2") + " $";
        }

        /// <summary>
        /// Removes the selected items from the cart.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_DeleteSelectedItem_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewCart.SelectedItems[0];
                item.Remove();
                CalculateAmount();
            }
            else
            {
                MessageBox.Show("Select row...");
            }
        }

        /// <summary>
        /// On selected book increases the quantity by one.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_IncreaseAmount_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select row...");
                return;
            }

            int quantity = business.GetBookByBarcode(int.Parse(textBox_Barcode.Text)).Number;

            if (quantity <= 0)
            {
                MessageBox.Show("There are no books left...");
                return;
            }
            else if (listViewCart.FindItemWithText(textBox_BookTitle.Text) != null)
            {
                if (int.Parse(listViewCart.FindItemWithText(textBox_BookTitle.Text).SubItems[1].Text) == quantity)
                {
                    MessageBox.Show("Can't add more than available!");
                    return;
                }
            }

            if (listViewCart.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewCart.SelectedItems[0];
                amount = 0;
                item.SubItems[1].Text = int.Parse(item.SubItems[1].Text) + 1 + "";
                CalculateAmount();
            }
            else
            {
                MessageBox.Show("Select row...");
                return;
            }
        }

        /// <summary>
        /// Decreases the quantity of selected book by one.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_DecreaseAmount_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewCart.SelectedItems[0];
                amount = 0;
               
                if (int.Parse(item.SubItems[1].Text) > 1) { item.SubItems[1].Text = int.Parse(item.SubItems[1].Text) - 1 + ""; CalculateAmount(); }
                else
                {
                    MessageBox.Show("Amount can't be less than 1");
                    item.SubItems[1].Text = 1 + "";
                }
            }
            else
            {
                MessageBox.Show("Select row...");
            }
        }
    }
}
