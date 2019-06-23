namespace BookShop.Forms
{
    partial class Form_FinishOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FinishOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelNetAm = new System.Windows.Forms.Label();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.labelDiscountCode = new System.Windows.Forms.Label();
            this.textBoxDiscCode = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotalAm = new System.Windows.Forms.TextBox();
            this.labelPaid = new System.Windows.Forms.Label();
            this.textBoxPaid = new System.Windows.Forms.TextBox();
            this.labelChangeAm = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 10);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 10);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(790, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 440);
            this.panel4.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(364, 46);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(178, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Finalize your order";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(90, 30);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(85, 91);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 4;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelNetAm
            // 
            this.labelNetAm.AutoSize = true;
            this.labelNetAm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetAm.Location = new System.Drawing.Point(239, 136);
            this.labelNetAm.Name = "labelNetAm";
            this.labelNetAm.Size = new System.Drawing.Size(123, 23);
            this.labelNetAm.TabIndex = 1;
            this.labelNetAm.Text = "Net amount:";
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.Location = new System.Drawing.Point(368, 132);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new System.Drawing.Size(220, 27);
            this.textBoxNetAmount.TabIndex = 5;
            // 
            // labelDiscountCode
            // 
            this.labelDiscountCode.AutoSize = true;
            this.labelDiscountCode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountCode.Location = new System.Drawing.Point(269, 182);
            this.labelDiscountCode.Name = "labelDiscountCode";
            this.labelDiscountCode.Size = new System.Drawing.Size(93, 23);
            this.labelDiscountCode.TabIndex = 1;
            this.labelDiscountCode.Text = "Discount:";
            // 
            // textBoxDiscCode
            // 
            this.textBoxDiscCode.Location = new System.Drawing.Point(368, 178);
            this.textBoxDiscCode.MaxLength = 30;
            this.textBoxDiscCode.Name = "textBoxDiscCode";
            this.textBoxDiscCode.Size = new System.Drawing.Size(220, 27);
            this.textBoxDiscCode.TabIndex = 5;
            this.textBoxDiscCode.TextChanged += new System.EventHandler(this.textBoxDiscCode_TextChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(227, 228);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(135, 23);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total amount:";
            // 
            // textBoxTotalAm
            // 
            this.textBoxTotalAm.Location = new System.Drawing.Point(368, 227);
            this.textBoxTotalAm.Name = "textBoxTotalAm";
            this.textBoxTotalAm.ReadOnly = true;
            this.textBoxTotalAm.Size = new System.Drawing.Size(220, 27);
            this.textBoxTotalAm.TabIndex = 5;
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaid.Location = new System.Drawing.Point(227, 274);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(133, 23);
            this.labelPaid.TabIndex = 1;
            this.labelPaid.Text = "Paid amount:";
            // 
            // textBoxPaid
            // 
            this.textBoxPaid.Location = new System.Drawing.Point(368, 273);
            this.textBoxPaid.MaxLength = 12;
            this.textBoxPaid.Name = "textBoxPaid";
            this.textBoxPaid.Size = new System.Drawing.Size(220, 27);
            this.textBoxPaid.TabIndex = 5;
            // 
            // labelChangeAm
            // 
            this.labelChangeAm.AutoSize = true;
            this.labelChangeAm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeAm.Location = new System.Drawing.Point(86, 383);
            this.labelChangeAm.Name = "labelChangeAm";
            this.labelChangeAm.Size = new System.Drawing.Size(166, 23);
            this.labelChangeAm.TabIndex = 1;
            this.labelChangeAm.Text = "Change amount:";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.Location = new System.Drawing.Point(255, 385);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(64, 23);
            this.labelChange.TabIndex = 1;
            this.labelChange.Text = "0.00 $";
            // 
            // buttonPay
            // 
            this.buttonPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPay.BackColor = System.Drawing.Color.Red;
            this.buttonPay.FlatAppearance.BorderSize = 0;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(536, 342);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(133, 42);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "$";
            // 
            // button_Close
            // 
            this.button_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Close.BackColor = System.Drawing.Color.White;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(701, 30);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(57, 39);
            this.button_Close.TabIndex = 21;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form_FinishOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxPaid);
            this.Controls.Add(this.textBoxTotalAm);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelChangeAm);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.textBoxDiscCode);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxNetAmount);
            this.Controls.Add(this.labelDiscountCode);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelNetAm);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_FinishOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_FinishOrder";
            this.Load += new System.EventHandler(this.Form_FinishOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelNetAm;
        private System.Windows.Forms.TextBox textBoxNetAmount;
        private System.Windows.Forms.Label labelDiscountCode;
        private System.Windows.Forms.TextBox textBoxDiscCode;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotalAm;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.TextBox textBoxPaid;
        private System.Windows.Forms.Label labelChangeAm;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Close;
    }
}