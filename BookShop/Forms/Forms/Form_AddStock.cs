using BookShop;
using BookShop.Data;
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

namespace BookShopManagement.Forms
{
    /// <summary>
    /// Form to restock the books quantity.
    /// </summary>
    public partial class Form_AddStock : Form
    {
        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business business = new Business();

        /// <summary>
        /// AddStock form initializer.
        /// </summary>
        public Form_AddStock()
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
            
            if (!int.TryParse(textBoxQuantityAmount.Text, out parsedValue) || !int.TryParse(textBoxBarcode.Text, out parsedValue) || int.Parse(textBoxBarcode.Text) <= 0 || int.Parse(textBoxQuantityAmount.Text) <=0)
            {
                MessageBox.Show("Quantity and  Barcode are postive numbers!!!", "Warning");
                return;
            }
            int barcodeInt = int.Parse(textBoxBarcode.Text);
            if (barcodeInt < business.GetAllBooks().First().barcodeId || barcodeInt > business.GetAllBooks().Last().barcodeId)
            {
                MessageBox.Show("Barcode is invalid, try another one.");
            }
            else
            {
                int currQuantity = business.GetBookByBarcode(int.Parse(textBoxBarcode.Text)).Number;
                int QuantityAfterAdd = currQuantity + int.Parse(textBoxQuantityAmount.Text);
                business.UpdateBookQuantity(business.GetBookByBarcode(int.Parse(textBoxBarcode.Text)), QuantityAfterAdd);
                MessageBox.Show("Success.");
                this.Close();
            }
        }

        /// <summary>
        /// Closes the AddStock form.
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
