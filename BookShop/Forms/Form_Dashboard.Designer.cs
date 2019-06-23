namespace BookShop.Forms
{
    partial class Form_Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnSaleBooks = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPurchaseItems = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMenuHide = new System.Windows.Forms.Panel();
            this.button_MenuHide = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelHeaderAndExit = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_Header = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label_TimeNow = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.timer_Collapse = new System.Windows.Forms.Timer(this.components);
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelMenuHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelHeaderAndExit.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.btnSaleBooks);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnUsers);
            this.panelLeft.Controls.Add(this.btnPurchaseItems);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Controls.Add(this.panelMenuHide);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(191, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(0, 134);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 67);
            this.panelSide.TabIndex = 3;
            // 
            // btnSaleBooks
            // 
            this.btnSaleBooks.FlatAppearance.BorderSize = 0;
            this.btnSaleBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleBooks.ForeColor = System.Drawing.Color.White;
            this.btnSaleBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleBooks.Image")));
            this.btnSaleBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleBooks.Location = new System.Drawing.Point(3, 203);
            this.btnSaleBooks.Name = "btnSaleBooks";
            this.btnSaleBooks.Size = new System.Drawing.Size(171, 67);
            this.btnSaleBooks.TabIndex = 3;
            this.btnSaleBooks.Text = "   Sale Books";
            this.btnSaleBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaleBooks.UseVisualStyleBackColor = true;
            this.btnSaleBooks.Click += new System.EventHandler(this.btnSaleBooks_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 422);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(171, 67);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(3, 349);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(171, 67);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "   Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPurchaseItems
            // 
            this.btnPurchaseItems.FlatAppearance.BorderSize = 0;
            this.btnPurchaseItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseItems.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseItems.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchaseItems.Image")));
            this.btnPurchaseItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseItems.Location = new System.Drawing.Point(3, 276);
            this.btnPurchaseItems.Name = "btnPurchaseItems";
            this.btnPurchaseItems.Size = new System.Drawing.Size(171, 67);
            this.btnPurchaseItems.TabIndex = 3;
            this.btnPurchaseItems.Text = "   Purchase";
            this.btnPurchaseItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchaseItems.UseVisualStyleBackColor = true;
            this.btnPurchaseItems.Click += new System.EventHandler(this.btnPurchaseItems_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 131);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 67);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "   Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMenuHide
            // 
            this.panelMenuHide.Controls.Add(this.button_MenuHide);
            this.panelMenuHide.Controls.Add(this.label_Title);
            this.panelMenuHide.Controls.Add(this.pictureBoxIcon);
            this.panelMenuHide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHide.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHide.Name = "panelMenuHide";
            this.panelMenuHide.Size = new System.Drawing.Size(191, 128);
            this.panelMenuHide.TabIndex = 1;
            // 
            // button_MenuHide
            // 
            this.button_MenuHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MenuHide.FlatAppearance.BorderSize = 0;
            this.button_MenuHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MenuHide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MenuHide.ForeColor = System.Drawing.Color.White;
            this.button_MenuHide.Image = ((System.Drawing.Image)(resources.GetObject("button_MenuHide.Image")));
            this.button_MenuHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_MenuHide.Location = new System.Drawing.Point(145, 4);
            this.button_MenuHide.Name = "button_MenuHide";
            this.button_MenuHide.Size = new System.Drawing.Size(40, 40);
            this.button_MenuHide.TabIndex = 3;
            this.button_MenuHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_MenuHide.UseVisualStyleBackColor = true;
            this.button_MenuHide.Click += new System.EventHandler(this.button_MenuHide_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(47, 67);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(130, 18);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "North Book Store";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(82, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 52);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelHeaderAndExit
            // 
            this.panelHeaderAndExit.Controls.Add(this.button_Close);
            this.panelHeaderAndExit.Controls.Add(this.label_Header);
            this.panelHeaderAndExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderAndExit.Location = new System.Drawing.Point(191, 0);
            this.panelHeaderAndExit.Name = "panelHeaderAndExit";
            this.panelHeaderAndExit.Size = new System.Drawing.Size(1009, 50);
            this.panelHeaderAndExit.TabIndex = 2;
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.Location = new System.Drawing.Point(952, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(57, 50);
            this.button_Close.TabIndex = 3;
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Header
            // 
            this.label_Header.AutoSize = true;
            this.label_Header.BackColor = System.Drawing.Color.White;
            this.label_Header.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Header.Location = new System.Drawing.Point(13, 16);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(130, 18);
            this.label_Header.TabIndex = 3;
            this.label_Header.Text = "North Book Store";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelInfo.Controls.Add(this.label_TimeNow);
            this.panelInfo.Controls.Add(this.label_Username);
            this.panelInfo.Controls.Add(this.label_Welcome);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(191, 50);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1009, 78);
            this.panelInfo.TabIndex = 2;
            // 
            // label_TimeNow
            // 
            this.label_TimeNow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_TimeNow.AutoSize = true;
            this.label_TimeNow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeNow.ForeColor = System.Drawing.Color.White;
            this.label_TimeNow.Location = new System.Drawing.Point(873, 31);
            this.label_TimeNow.Name = "label_TimeNow";
            this.label_TimeNow.Size = new System.Drawing.Size(112, 25);
            this.label_TimeNow.TabIndex = 4;
            this.label_TimeNow.Text = "HH:MM:SS";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(131, 32);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(94, 18);
            this.label_Username.TabIndex = 3;
            this.label_Username.Text = "(Username)";
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Welcome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Welcome.Location = new System.Drawing.Point(40, 31);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(84, 18);
            this.label_Welcome.TabIndex = 3;
            this.label_Welcome.Text = "Welcome:";
            // 
            // timer_Collapse
            // 
            this.timer_Collapse.Interval = 1;
            this.timer_Collapse.Tick += new System.EventHandler(this.timer_Collapse_Tick);
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Interval = 1;
            this.timerTimeNow.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(191, 128);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1009, 592);
            this.panelControls.TabIndex = 3;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeaderAndExit);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelMenuHide.ResumeLayout(false);
            this.panelMenuHide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelHeaderAndExit.ResumeLayout(false);
            this.panelHeaderAndExit.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelMenuHide;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelHeaderAndExit;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnPurchaseItems;
        private System.Windows.Forms.Button btnSaleBooks;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button button_MenuHide;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Timer timer_Collapse;
        private System.Windows.Forms.Timer timerTimeNow;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label_TimeNow;
    }
}