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
    /// The dashboard (home) form.
    /// </summary>
    public partial class Form_Dashboard : Form
    {
        /// <value>Contains the database and the methods for books and users processing.</value>
        private Business business = new Business();

        /// <value>Contains the width of the content part of the form (Sales
        /// and Purchase Overview).</value>
        int PanelWidth;

        /// <value>Determines whether the left navigation is collapsed or not.</value>
        bool isCollapsed;

        /// <summary>
        /// Dashboard form initializer.
        /// </summary>
        public Form_Dashboard()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;     
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
            label_Username.Text = Form_Login.us.Username;
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Exposes/hides the side navigation.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void timer_Collapse_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 140;

                if (panelLeft.Width >= PanelWidth)
                {
                    timer_Collapse.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 140;

                if (panelLeft.Width <= 57)
                {
                    timer_Collapse.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        /// <summary>
        /// Hides the side navigation.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void button_MenuHide_Click(object sender, EventArgs e)
        {
            timer_Collapse.Start();
        }

        /// <summary>
        /// Moves the little white block to the clicked button.
        /// </summary>
        /// <param name="c"></param>
        private void moveSidePanel(Control c)
        {
            panelSide.Top = c.Top;
            panelSide.Height = c.Height;
        }

        /// <summary>
        /// Add controls to the panel and navigates to the corresponding to the button
        /// UserControl.
        /// </summary>
        /// <param name="c">The current form's control.</param>
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        /// <summary>
        /// Sends the user to the home page (dashboard).
        /// Shows the current books count and the count of the registered users.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        /// <summary>
        /// Sends the user to the Sale Books panel.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void btnSaleBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSaleBooks);
            UC_Sales ucs = new UC_Sales();
            AddControlsToPanel(ucs);
        }

        /// <summary>
        /// Sends the user to the form with the books.
        /// There can be created new books.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void btnPurchaseItems_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPurchaseItems);
            UC_PurchaseDetails ucpd = new UC_PurchaseDetails();
            AddControlsToPanel(ucpd);
        }

        /// <summary>
        /// Sends the user to the form with the registered users.
        /// There can be created new user.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            UC_ManageUser ucmu = new UC_ManageUser();
            AddControlsToPanel(ucmu);
        }

        /// <summary>
        /// Opens the settings panel.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
            UC_Settings ucset = new UC_Settings();
            AddControlsToPanel(ucset);
        }

        /// <summary>
        /// Updates the current time.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_TimeNow.Text = dt.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Opens the dashboard (home) form of the app and starts the current time now timer.
        /// </summary>
        /// <param name="sender">Contains a reference to the control that raised the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            timerTimeNow.Start();
        }
    }
}
