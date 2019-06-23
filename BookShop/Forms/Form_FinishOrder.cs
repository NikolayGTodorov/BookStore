using BookShop.Data;
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
    /// The form to finish the order.
    /// </summary>
    public partial class Form_FinishOrder : Form
    {
        /// <value>Contains the sales controller data.</value>
        UC_Sales ucs = new UC_Sales();

        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business business = new Business();

        /// <summary>
        /// FinishOrder form initializer.
        /// </summary>
        public Form_FinishOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charges discount from the cost.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void textBoxDiscCode_TextChanged(object sender, EventArgs e)
        {
            if(textBoxDiscCode.Text.ToUpper() == "FREE")
            {
                float amount = ucs.amountValue;
                float amountafterpromo = amount - (amount * 0.10f);
                textBoxTotalAm.Text = amountafterpromo.ToString("N2");
            }
            else
            {
                float amount = ucs.amountValue;
                textBoxTotalAm.Text = amount.ToString("N2"); 
            }
        }

        /// <summary>
        /// Loads the FinishOrder form to complete the purchase.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void Form_FinishOrder_Load(object sender, EventArgs e)
        {
            GetNetAmount();
            float amount = ucs.amountValue;
            textBoxTotalAm.Text = amount.ToString("N2");
            
        }

        /// <summary>
        /// Calculates the "Change amount" value.
        /// </summary>
        private void GetNetAmount()
        {
            string netamount = ucs.amountValue.ToString("N2");
            textBoxNetAmount.Text = netamount + " $";
        }

        /// <summary>
        /// Closes the purchase form.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to abort the purchase?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

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

        /// <summary>
        /// Completes the purchase.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void buttonPay_Click(object sender, EventArgs e)
        {
            float parsedValue;

            if (!float.TryParse(textBoxPaid.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPaid.Text))
            {
                MessageBox.Show("Paid amount should be filled!");
                return;
            }

            double textboxwithtotalamount = double.Parse(textBoxPaid.Text);        
            double textboxwithamountafterpromo = float.Parse(textBoxTotalAm.Text);

            if (textboxwithamountafterpromo > textboxwithtotalamount)
            {
                MessageBox.Show("Pay the needed amount, not less");
            }
            else
            {
                double changeAmount = textboxwithtotalamount - textboxwithamountafterpromo;
                
                labelChange.Text = changeAmount.ToString("N2") + " $";
                MessageBox.Show("Payment successful");
                this.Close();
                
                ReduceQuantityPerSoldBook(UC_Sales.books, UC_Sales.quantity);
            }
        }

        /// <summary>
        /// Reduces the quantity of every book purchased.
        /// </summary>
        /// <param name="books"></param>
        /// <param name="quantity"></param>
        public void ReduceQuantityPerSoldBook(List<book> books, List<int> quantity)
        {
            for (int i = 0; i < books.Count; i++)
            {
                business.UpdateBook(books.ElementAt(i), quantity.ElementAt(i));
            }
        }
    }
}
