namespace BookShop.UserControls
{
    partial class UC_Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_AvailableBooks = new System.Windows.Forms.Panel();
            this.pictureBoxIco1 = new System.Windows.Forms.PictureBox();
            this.label_Amount_Available = new System.Windows.Forms.Label();
            this.labelAvailableBooks = new System.Windows.Forms.Label();
            this.panel_Customers = new System.Windows.Forms.Panel();
            this.pictureBoxIco2 = new System.Windows.Forms.PictureBox();
            this.label_Customers_Registered = new System.Windows.Forms.Label();
            this.label_Customers = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel_AvailableBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIco1)).BeginInit();
            this.panel_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIco2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Title.Location = new System.Drawing.Point(342, 36);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(314, 25);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Sales and Purchase Overview";
            // 
            // panel_AvailableBooks
            // 
            this.panel_AvailableBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_AvailableBooks.BackColor = System.Drawing.Color.Red;
            this.panel_AvailableBooks.Controls.Add(this.pictureBoxIco1);
            this.panel_AvailableBooks.Controls.Add(this.label_Amount_Available);
            this.panel_AvailableBooks.Controls.Add(this.labelAvailableBooks);
            this.panel_AvailableBooks.Location = new System.Drawing.Point(274, 133);
            this.panel_AvailableBooks.Name = "panel_AvailableBooks";
            this.panel_AvailableBooks.Size = new System.Drawing.Size(230, 110);
            this.panel_AvailableBooks.TabIndex = 1;
            // 
            // pictureBoxIco1
            // 
            this.pictureBoxIco1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIco1.Image")));
            this.pictureBoxIco1.Location = new System.Drawing.Point(166, 30);
            this.pictureBoxIco1.Name = "pictureBoxIco1";
            this.pictureBoxIco1.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxIco1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIco1.TabIndex = 2;
            this.pictureBoxIco1.TabStop = false;
            // 
            // label_Amount_Available
            // 
            this.label_Amount_Available.AutoSize = true;
            this.label_Amount_Available.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount_Available.ForeColor = System.Drawing.Color.White;
            this.label_Amount_Available.Location = new System.Drawing.Point(34, 59);
            this.label_Amount_Available.Name = "label_Amount_Available";
            this.label_Amount_Available.Size = new System.Drawing.Size(21, 23);
            this.label_Amount_Available.TabIndex = 0;
            this.label_Amount_Available.Text = "0";
            // 
            // labelAvailableBooks
            // 
            this.labelAvailableBooks.AutoSize = true;
            this.labelAvailableBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableBooks.ForeColor = System.Drawing.Color.White;
            this.labelAvailableBooks.Location = new System.Drawing.Point(17, 22);
            this.labelAvailableBooks.Name = "labelAvailableBooks";
            this.labelAvailableBooks.Size = new System.Drawing.Size(139, 19);
            this.labelAvailableBooks.TabIndex = 0;
            this.labelAvailableBooks.Text = "Available books:";
            // 
            // panel_Customers
            // 
            this.panel_Customers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Customers.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_Customers.Controls.Add(this.pictureBoxIco2);
            this.panel_Customers.Controls.Add(this.label_Customers_Registered);
            this.panel_Customers.Controls.Add(this.label_Customers);
            this.panel_Customers.Location = new System.Drawing.Point(555, 133);
            this.panel_Customers.Name = "panel_Customers";
            this.panel_Customers.Size = new System.Drawing.Size(188, 110);
            this.panel_Customers.TabIndex = 1;
            // 
            // pictureBoxIco2
            // 
            this.pictureBoxIco2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIco2.Image")));
            this.pictureBoxIco2.Location = new System.Drawing.Point(115, 30);
            this.pictureBoxIco2.Name = "pictureBoxIco2";
            this.pictureBoxIco2.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxIco2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIco2.TabIndex = 2;
            this.pictureBoxIco2.TabStop = false;
            // 
            // label_Customers_Registered
            // 
            this.label_Customers_Registered.AutoSize = true;
            this.label_Customers_Registered.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Customers_Registered.ForeColor = System.Drawing.Color.White;
            this.label_Customers_Registered.Location = new System.Drawing.Point(34, 59);
            this.label_Customers_Registered.Name = "label_Customers_Registered";
            this.label_Customers_Registered.Size = new System.Drawing.Size(21, 23);
            this.label_Customers_Registered.TabIndex = 0;
            this.label_Customers_Registered.Text = "0";
            
            // 
            // label_Customers
            // 
            this.label_Customers.AutoSize = true;
            this.label_Customers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Customers.ForeColor = System.Drawing.Color.White;
            this.label_Customers.Location = new System.Drawing.Point(17, 22);
            this.label_Customers.Name = "label_Customers";
            this.label_Customers.Size = new System.Drawing.Size(92, 19);
            this.label_Customers.TabIndex = 0;
            this.label_Customers.Text = "Customers:";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("button_Refresh.Image")));
            this.button_Refresh.Location = new System.Drawing.Point(926, 13);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(39, 39);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.panel_AvailableBooks);
            this.Controls.Add(this.panel_Customers);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1009, 592);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.panel_AvailableBooks.ResumeLayout(false);
            this.panel_AvailableBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIco1)).EndInit();
            this.panel_Customers.ResumeLayout(false);
            this.panel_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIco2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_AvailableBooks;
        private System.Windows.Forms.PictureBox pictureBoxIco1;
        private System.Windows.Forms.Label label_Amount_Available;
        private System.Windows.Forms.Label labelAvailableBooks;
        private System.Windows.Forms.Panel panel_Customers;
        private System.Windows.Forms.PictureBox pictureBoxIco2;
        private System.Windows.Forms.Label label_Customers_Registered;
        private System.Windows.Forms.Label label_Customers;
        private System.Windows.Forms.Button button_Refresh;
    }
}
