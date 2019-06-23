namespace BookShop.UserControls
{
    partial class UC_Sales
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
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Barcode = new System.Windows.Forms.TextBox();
            this.button_AddToCart = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.listViewCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_Finish = new System.Windows.Forms.Button();
            this.button_ClearCart = new System.Windows.Forms.Button();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_IncreaseAmount = new System.Windows.Forms.Button();
            this.button_DeleteSelectedItem = new System.Windows.Forms.Button();
            this.button_DecreaseAmount = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Barcode = new System.Windows.Forms.Label();
            this.label_BookTitle = new System.Windows.Forms.Label();
            this.textBox_BookTitle = new System.Windows.Forms.TextBox();
            this.label_Author = new System.Windows.Forms.Label();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_Publisher = new System.Windows.Forms.Label();
            this.textBox_Publisher = new System.Windows.Forms.TextBox();
            this.button_FindByBarcode = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(309, 79);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(111, 25);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Sell Books";
            // 
            // textBox_Barcode
            // 
            this.textBox_Barcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Barcode.Location = new System.Drawing.Point(158, 189);
            this.textBox_Barcode.MaxLength = 10;
            this.textBox_Barcode.Name = "textBox_Barcode";
            this.textBox_Barcode.Size = new System.Drawing.Size(157, 27);
            this.textBox_Barcode.TabIndex = 1;
            this.textBox_Barcode.TextChanged += new System.EventHandler(this.textBox_Barcode_TextChanged);
            // 
            // button_AddToCart
            // 
            this.button_AddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_AddToCart.FlatAppearance.BorderSize = 0;
            this.button_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddToCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddToCart.ForeColor = System.Drawing.Color.White;
            this.button_AddToCart.Location = new System.Drawing.Point(376, 363);
            this.button_AddToCart.Name = "button_AddToCart";
            this.button_AddToCart.Size = new System.Drawing.Size(112, 42);
            this.button_AddToCart.TabIndex = 2;
            this.button_AddToCart.Text = "Add to cart";
            this.button_AddToCart.UseVisualStyleBackColor = false;
            this.button_AddToCart.Click += new System.EventHandler(this.button_AddToCart_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.listViewCart);
            this.panelLeft.Controls.Add(this.panel4);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(670, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(339, 592);
            this.panelLeft.TabIndex = 3;
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.GridLines = true;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(10, 0);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.ShowItemToolTips = true;
            this.listViewCart.Size = new System.Drawing.Size(319, 388);
            this.listViewCart.TabIndex = 5;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book TItle";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.button_Finish);
            this.panel4.Controls.Add(this.button_ClearCart);
            this.panel4.Controls.Add(this.label_Amount);
            this.panel4.Controls.Add(this.label_TotalAmount);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 204);
            this.panel4.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 7);
            this.panel7.TabIndex = 6;
            // 
            // button_Finish
            // 
            this.button_Finish.BackColor = System.Drawing.Color.Turquoise;
            this.button_Finish.FlatAppearance.BorderSize = 0;
            this.button_Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Finish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Finish.ForeColor = System.Drawing.Color.White;
            this.button_Finish.Location = new System.Drawing.Point(162, 159);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(154, 42);
            this.button_Finish.TabIndex = 2;
            this.button_Finish.Text = "Finish";
            this.button_Finish.UseVisualStyleBackColor = false;
            this.button_Finish.Click += new System.EventHandler(this.button_Finish_Click);
            // 
            // button_ClearCart
            // 
            this.button_ClearCart.BackColor = System.Drawing.Color.Red;
            this.button_ClearCart.FlatAppearance.BorderSize = 0;
            this.button_ClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearCart.ForeColor = System.Drawing.Color.White;
            this.button_ClearCart.Location = new System.Drawing.Point(6, 159);
            this.button_ClearCart.Name = "button_ClearCart";
            this.button_ClearCart.Size = new System.Drawing.Size(150, 42);
            this.button_ClearCart.TabIndex = 2;
            this.button_ClearCart.Text = "Clear";
            this.button_ClearCart.UseVisualStyleBackColor = false;
            this.button_ClearCart.Click += new System.EventHandler(this.button_ClearCart_Click);
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(133, 84);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(54, 21);
            this.label_Amount.TabIndex = 0;
            this.label_Amount.Text = "0.00 $";
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Location = new System.Drawing.Point(7, 84);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(120, 21);
            this.label_TotalAmount.TabIndex = 0;
            this.label_TotalAmount.Text = "Total amount:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button_IncreaseAmount);
            this.panel6.Controls.Add(this.button_DeleteSelectedItem);
            this.panel6.Controls.Add(this.button_DecreaseAmount);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(319, 57);
            this.panel6.TabIndex = 5;
            // 
            // button_IncreaseAmount
            // 
            this.button_IncreaseAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_IncreaseAmount.FlatAppearance.BorderSize = 0;
            this.button_IncreaseAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_IncreaseAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IncreaseAmount.ForeColor = System.Drawing.Color.White;
            this.button_IncreaseAmount.Location = new System.Drawing.Point(59, 6);
            this.button_IncreaseAmount.Name = "button_IncreaseAmount";
            this.button_IncreaseAmount.Size = new System.Drawing.Size(47, 42);
            this.button_IncreaseAmount.TabIndex = 2;
            this.button_IncreaseAmount.Text = "+";
            this.button_IncreaseAmount.UseVisualStyleBackColor = false;
            this.button_IncreaseAmount.Click += new System.EventHandler(this.button_IncreaseAmount_Click);
            // 
            // button_DeleteSelectedItem
            // 
            this.button_DeleteSelectedItem.BackColor = System.Drawing.Color.OrangeRed;
            this.button_DeleteSelectedItem.FlatAppearance.BorderSize = 0;
            this.button_DeleteSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteSelectedItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteSelectedItem.ForeColor = System.Drawing.Color.White;
            this.button_DeleteSelectedItem.Location = new System.Drawing.Point(112, 6);
            this.button_DeleteSelectedItem.Name = "button_DeleteSelectedItem";
            this.button_DeleteSelectedItem.Size = new System.Drawing.Size(201, 42);
            this.button_DeleteSelectedItem.TabIndex = 2;
            this.button_DeleteSelectedItem.Text = "Delete";
            this.button_DeleteSelectedItem.UseVisualStyleBackColor = false;
            this.button_DeleteSelectedItem.Click += new System.EventHandler(this.button_DeleteSelectedItem_Click);
            // 
            // button_DecreaseAmount
            // 
            this.button_DecreaseAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_DecreaseAmount.FlatAppearance.BorderSize = 0;
            this.button_DecreaseAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DecreaseAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DecreaseAmount.ForeColor = System.Drawing.Color.White;
            this.button_DecreaseAmount.Location = new System.Drawing.Point(6, 6);
            this.button_DecreaseAmount.Name = "button_DecreaseAmount";
            this.button_DecreaseAmount.Size = new System.Drawing.Size(47, 42);
            this.button_DecreaseAmount.TabIndex = 2;
            this.button_DecreaseAmount.Text = "-";
            this.button_DecreaseAmount.UseVisualStyleBackColor = false;
            this.button_DecreaseAmount.Click += new System.EventHandler(this.button_DecreaseAmount_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 7);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(329, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 592);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 592);
            this.panel2.TabIndex = 4;
            // 
            // label_Barcode
            // 
            this.label_Barcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Barcode.AutoSize = true;
            this.label_Barcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Barcode.Location = new System.Drawing.Point(67, 193);
            this.label_Barcode.Name = "label_Barcode";
            this.label_Barcode.Size = new System.Drawing.Size(85, 19);
            this.label_Barcode.TabIndex = 0;
            this.label_Barcode.Text = "Bar Code:";
            // 
            // label_BookTitle
            // 
            this.label_BookTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_BookTitle.AutoSize = true;
            this.label_BookTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookTitle.Location = new System.Drawing.Point(336, 193);
            this.label_BookTitle.Name = "label_BookTitle";
            this.label_BookTitle.Size = new System.Drawing.Size(84, 19);
            this.label_BookTitle.TabIndex = 0;
            this.label_BookTitle.Text = "Book Title:";
            // 
            // textBox_BookTitle
            // 
            this.textBox_BookTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_BookTitle.Location = new System.Drawing.Point(427, 189);
            this.textBox_BookTitle.Name = "textBox_BookTitle";
            this.textBox_BookTitle.ReadOnly = true;
            this.textBox_BookTitle.Size = new System.Drawing.Size(157, 27);
            this.textBox_BookTitle.TabIndex = 1;
            // 
            // label_Author
            // 
            this.label_Author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Author.Location = new System.Drawing.Point(67, 248);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(64, 19);
            this.label_Author.TabIndex = 0;
            this.label_Author.Text = "Author:";
            // 
            // textBox_Author
            // 
            this.textBox_Author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Author.Location = new System.Drawing.Point(158, 244);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.ReadOnly = true;
            this.textBox_Author.Size = new System.Drawing.Size(157, 27);
            this.textBox_Author.TabIndex = 1;
            // 
            // label_Price
            // 
            this.label_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(336, 252);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(51, 19);
            this.label_Price.TabIndex = 0;
            this.label_Price.Text = "Price:";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Price.Location = new System.Drawing.Point(427, 248);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.ReadOnly = true;
            this.textBox_Price.Size = new System.Drawing.Size(157, 27);
            this.textBox_Price.TabIndex = 1;
            // 
            // label_Publisher
            // 
            this.label_Publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Publisher.AutoSize = true;
            this.label_Publisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Publisher.Location = new System.Drawing.Point(67, 305);
            this.label_Publisher.Name = "label_Publisher";
            this.label_Publisher.Size = new System.Drawing.Size(82, 19);
            this.label_Publisher.TabIndex = 0;
            this.label_Publisher.Text = "Publisher:";
            // 
            // textBox_Publisher
            // 
            this.textBox_Publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Publisher.Location = new System.Drawing.Point(158, 301);
            this.textBox_Publisher.Name = "textBox_Publisher";
            this.textBox_Publisher.ReadOnly = true;
            this.textBox_Publisher.Size = new System.Drawing.Size(426, 27);
            this.textBox_Publisher.TabIndex = 1;
            // 
            // button_FindByBarcode
            // 
            this.button_FindByBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_FindByBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_FindByBarcode.FlatAppearance.BorderSize = 0;
            this.button_FindByBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FindByBarcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FindByBarcode.ForeColor = System.Drawing.Color.White;
            this.button_FindByBarcode.Location = new System.Drawing.Point(188, 363);
            this.button_FindByBarcode.Name = "button_FindByBarcode";
            this.button_FindByBarcode.Size = new System.Drawing.Size(146, 42);
            this.button_FindByBarcode.TabIndex = 4;
            this.button_FindByBarcode.Text = "Find by barcode";
            this.button_FindByBarcode.UseVisualStyleBackColor = false;
            this.button_FindByBarcode.Click += new System.EventHandler(this.button_FindByBarcode_Click);
            // 
            // UC_Sales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_FindByBarcode);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.button_AddToCart);
            this.Controls.Add(this.textBox_Publisher);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.textBox_BookTitle);
            this.Controls.Add(this.label_Publisher);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.textBox_Barcode);
            this.Controls.Add(this.label_BookTitle);
            this.Controls.Add(this.label_Barcode);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(1009, 592);
            this.Load += new System.EventHandler(this.UC_Sales_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Barcode;
        private System.Windows.Forms.Button button_AddToCart;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_Finish;
        private System.Windows.Forms.Button button_ClearCart;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.Button button_IncreaseAmount;
        private System.Windows.Forms.Button button_DeleteSelectedItem;
        private System.Windows.Forms.Button button_DecreaseAmount;
        private System.Windows.Forms.Label label_Barcode;
        private System.Windows.Forms.Label label_BookTitle;
        private System.Windows.Forms.TextBox textBox_BookTitle;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_Publisher;
        private System.Windows.Forms.TextBox textBox_Publisher;
        private System.Windows.Forms.Button button_FindByBarcode;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
