namespace BookShop
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_TurnOff = new System.Windows.Forms.Button();
            this.pictureBoxMiniIcon = new System.Windows.Forms.PictureBox();
            this.label_Header = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.buttonSql = new System.Windows.Forms.Button();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_HideShowPass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.button_TurnOff);
            this.panel1.Controls.Add(this.pictureBoxMiniIcon);
            this.panel1.Controls.Add(this.label_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 59);
            this.panel1.TabIndex = 0;
            // 
            // button_TurnOff
            // 
            this.button_TurnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_TurnOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_TurnOff.FlatAppearance.BorderSize = 0;
            this.button_TurnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_TurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TurnOff.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TurnOff.Image = ((System.Drawing.Image)(resources.GetObject("button_TurnOff.Image")));
            this.button_TurnOff.Location = new System.Drawing.Point(1111, 0);
            this.button_TurnOff.Name = "button_TurnOff";
            this.button_TurnOff.Size = new System.Drawing.Size(89, 59);
            this.button_TurnOff.TabIndex = 5;
            this.button_TurnOff.UseVisualStyleBackColor = false;
            this.button_TurnOff.Click += new System.EventHandler(this.button_TurnOff_Click);
            // 
            // pictureBoxMiniIcon
            // 
            this.pictureBoxMiniIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMiniIcon.Image")));
            this.pictureBoxMiniIcon.Location = new System.Drawing.Point(8, 4);
            this.pictureBoxMiniIcon.Name = "pictureBoxMiniIcon";
            this.pictureBoxMiniIcon.Size = new System.Drawing.Size(51, 51);
            this.pictureBoxMiniIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMiniIcon.TabIndex = 2;
            this.pictureBoxMiniIcon.TabStop = false;
            // 
            // label_Header
            // 
            this.label_Header.AutoSize = true;
            this.label_Header.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Header.ForeColor = System.Drawing.Color.White;
            this.label_Header.Location = new System.Drawing.Point(61, 21);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(161, 23);
            this.label_Header.TabIndex = 2;
            this.label_Header.Text = "North Book Store";
            // 
            // label_Username
            // 
            this.label_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Username.AutoSize = true;
            this.label_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Username.Location = new System.Drawing.Point(404, 370);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(98, 21);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "User Name:";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(546, 195);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(108, 107);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Title.Location = new System.Drawing.Point(516, 318);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(164, 23);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Please Login First";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(408, 394);
            this.textBox_Username.MaxLength = 45;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(368, 31);
            this.textBox_Username.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Password.Location = new System.Drawing.Point(404, 446);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 21);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(408, 470);
            this.textBox_Password.MaxLength = 25;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(368, 31);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            this.button_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(408, 554);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(368, 43);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Copyright
            // 
            this.label_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Copyright.Location = new System.Drawing.Point(3, 695);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(321, 17);
            this.label_Copyright.TabIndex = 1;
            this.label_Copyright.Text = "Copyrights@2019, All rights Reserved By It Kariera.";
            // 
            // buttonSql
            // 
            this.buttonSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSql.BackColor = System.Drawing.Color.White;
            this.buttonSql.Enabled = false;
            this.buttonSql.FlatAppearance.BorderSize = 0;
            this.buttonSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSql.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSql.Image = ((System.Drawing.Image)(resources.GetObject("buttonSql.Image")));
            this.buttonSql.Location = new System.Drawing.Point(1136, 667);
            this.buttonSql.Name = "buttonSql";
            this.buttonSql.Size = new System.Drawing.Size(67, 63);
            this.buttonSql.TabIndex = 5;
            this.buttonSql.UseVisualStyleBackColor = false;
            // 
            // button_Register
            // 
            this.button_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_Register.FlatAppearance.BorderSize = 0;
            this.button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Register.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(408, 617);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(368, 43);
            this.button_Register.TabIndex = 6;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_HideShowPass
            // 
            this.button_HideShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HideShowPass.Image = global::BookShop.Properties.Resources.visible_30px_blue;
            this.button_HideShowPass.Location = new System.Drawing.Point(1140, 650);
            this.button_HideShowPass.Name = "button_HideShowPass";
            this.button_HideShowPass.Size = new System.Drawing.Size(33, 31);
            this.button_HideShowPass.TabIndex = 7;
            this.button_HideShowPass.UseVisualStyleBackColor = false;
            this.button_HideShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_HideShowPass_MouseDown);
            this.button_HideShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_HideShowPass_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.button_HideShowPass);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.buttonSql);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_TurnOff;
        private System.Windows.Forms.PictureBox pictureBoxMiniIcon;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Copyright;
        private System.Windows.Forms.Button buttonSql;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_HideShowPass;
    }
}

