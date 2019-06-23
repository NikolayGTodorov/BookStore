namespace BookShop.UserControls
{
    partial class UC_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Settings));
            this.label_Title = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label_newpass = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.button_ChangePass = new System.Windows.Forms.Button();
            this.button_showchngpass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Title.Location = new System.Drawing.Point(909, 249);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(123, 36);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Settings";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(680, 455);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(108, 23);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // label_newpass
            // 
            this.label_newpass.AutoSize = true;
            this.label_newpass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newpass.Location = new System.Drawing.Point(639, 552);
            this.label_newpass.Name = "label_newpass";
            this.label_newpass.Size = new System.Drawing.Size(149, 23);
            this.label_newpass.TabIndex = 2;
            this.label_newpass.Text = "New password:";
            this.label_newpass.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(755, 398);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 23);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(815, 399);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(0, 25);
            this.label_Id.TabIndex = 3;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(816, 457);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(0, 25);
            this.label_Username.TabIndex = 3;
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.Location = new System.Drawing.Point(820, 552);
            this.textBox_NewPass.MaxLength = 25;
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.Size = new System.Drawing.Size(157, 27);
            this.textBox_NewPass.TabIndex = 4;
            this.textBox_NewPass.Visible = false;
            // 
            // button_ChangePass
            // 
            this.button_ChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ChangePass.BackColor = System.Drawing.Color.White;
            this.button_ChangePass.FlatAppearance.BorderSize = 0;
            this.button_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePass.ForeColor = System.Drawing.Color.White;
            this.button_ChangePass.Image = ((System.Drawing.Image)(resources.GetObject("button_ChangePass.Image")));
            this.button_ChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ChangePass.Location = new System.Drawing.Point(1082, 609);
            this.button_ChangePass.Name = "button_ChangePass";
            this.button_ChangePass.Size = new System.Drawing.Size(37, 39);
            this.button_ChangePass.TabIndex = 22;
            this.button_ChangePass.UseVisualStyleBackColor = false;
            this.button_ChangePass.Visible = false;
            this.button_ChangePass.Click += new System.EventHandler(this.button_ChangePass_Click);
            // 
            // button_showchngpass
            // 
            this.button_showchngpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_showchngpass.BackColor = System.Drawing.Color.OrangeRed;
            this.button_showchngpass.FlatAppearance.BorderSize = 0;
            this.button_showchngpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showchngpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showchngpass.ForeColor = System.Drawing.Color.White;
            this.button_showchngpass.Location = new System.Drawing.Point(820, 561);
            this.button_showchngpass.Name = "button_showchngpass";
            this.button_showchngpass.Size = new System.Drawing.Size(138, 38);
            this.button_showchngpass.TabIndex = 22;
            this.button_showchngpass.Text = "Change password";
            this.button_showchngpass.UseVisualStyleBackColor = false;
            this.button_showchngpass.Click += new System.EventHandler(this.button_showchngpass_Click);
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_showchngpass);
            this.Controls.Add(this.button_ChangePass);
            this.Controls.Add(this.textBox_NewPass);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_newpass);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label_newpass;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_NewPass;
        private System.Windows.Forms.Button button_ChangePass;
        private System.Windows.Forms.Button button_showchngpass;
    }
}
