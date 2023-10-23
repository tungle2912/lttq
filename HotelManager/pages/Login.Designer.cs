namespace HotelManager
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeLoginPageBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.directToRegisterPage = new System.Windows.Forms.Label();
            this.forgetPassword = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.LoginFormControl = new System.Windows.Forms.Panel();
            this.eyePassword = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.passwordWarningText = new System.Windows.Forms.Label();
            this.loginPasswordInput = new System.Windows.Forms.TextBox();
            this.labelForPassword = new FontAwesome.Sharp.IconButton();
            this.usernameWarningText = new System.Windows.Forms.Label();
            this.loginUsernameInput = new System.Windows.Forms.TextBox();
            this.labelForUsername = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.LoginFormControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.closeLoginPageBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 50);
            this.panel1.TabIndex = 0;
            // 
            // closeLoginPageBtn
            // 
            this.closeLoginPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLoginPageBtn.BackColor = System.Drawing.Color.White;
            this.closeLoginPageBtn.FlatAppearance.BorderSize = 0;
            this.closeLoginPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLoginPageBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeLoginPageBtn.IconColor = System.Drawing.Color.Black;
            this.closeLoginPageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeLoginPageBtn.IconSize = 24;
            this.closeLoginPageBtn.Location = new System.Drawing.Point(835, 13);
            this.closeLoginPageBtn.Name = "closeLoginPageBtn";
            this.closeLoginPageBtn.Size = new System.Drawing.Size(30, 26);
            this.closeLoginPageBtn.TabIndex = 0;
            this.closeLoginPageBtn.UseVisualStyleBackColor = false;
            this.closeLoginPageBtn.Click += new System.EventHandler(this.closeLoginPageBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 417);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManager.Properties.Resources.hotel_logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.directToRegisterPage);
            this.panel3.Controls.Add(this.forgetPassword);
            this.panel3.Controls.Add(this.loginBtn);
            this.panel3.Controls.Add(this.LoginFormControl);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(356, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 417);
            this.panel3.TabIndex = 2;
            // 
            // directToRegisterPage
            // 
            this.directToRegisterPage.AutoSize = true;
            this.directToRegisterPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.directToRegisterPage.ForeColor = System.Drawing.Color.White;
            this.directToRegisterPage.Location = new System.Drawing.Point(188, 350);
            this.directToRegisterPage.Name = "directToRegisterPage";
            this.directToRegisterPage.Size = new System.Drawing.Size(248, 15);
            this.directToRegisterPage.TabIndex = 4;
            this.directToRegisterPage.Text = "Don\'t have an account? Register here";
            this.directToRegisterPage.Click += new System.EventHandler(this.directToRegisterPage_Click);
            // 
            // forgetPassword
            // 
            this.forgetPassword.AutoSize = true;
            this.forgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline);
            this.forgetPassword.ForeColor = System.Drawing.Color.White;
            this.forgetPassword.Location = new System.Drawing.Point(337, 233);
            this.forgetPassword.Name = "forgetPassword";
            this.forgetPassword.Size = new System.Drawing.Size(105, 15);
            this.forgetPassword.TabIndex = 3;
            this.forgetPassword.Text = "Forget password?";
            this.forgetPassword.Click += new System.EventHandler(this.forgetPassword_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(192, 280);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(233, 38);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.handleMouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.handleMouseLeave);
            // 
            // LoginFormControl
            // 
            this.LoginFormControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginFormControl.Controls.Add(this.eyePassword);
            this.LoginFormControl.Controls.Add(this.panel5);
            this.LoginFormControl.Controls.Add(this.panel6);
            this.LoginFormControl.Controls.Add(this.passwordWarningText);
            this.LoginFormControl.Controls.Add(this.loginPasswordInput);
            this.LoginFormControl.Controls.Add(this.labelForPassword);
            this.LoginFormControl.Controls.Add(this.usernameWarningText);
            this.LoginFormControl.Controls.Add(this.loginUsernameInput);
            this.LoginFormControl.Controls.Add(this.labelForUsername);
            this.LoginFormControl.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.LoginFormControl.Location = new System.Drawing.Point(45, 89);
            this.LoginFormControl.Name = "LoginFormControl";
            this.LoginFormControl.Size = new System.Drawing.Size(406, 142);
            this.LoginFormControl.TabIndex = 1;
            // 
            // eyePassword
            // 
            this.eyePassword.FlatAppearance.BorderSize = 0;
            this.eyePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyePassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.eyePassword.IconColor = System.Drawing.Color.White;
            this.eyePassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.eyePassword.IconSize = 28;
            this.eyePassword.Location = new System.Drawing.Point(351, 75);
            this.eyePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eyePassword.Name = "eyePassword";
            this.eyePassword.Size = new System.Drawing.Size(31, 25);
            this.eyePassword.TabIndex = 5;
            this.eyePassword.UseVisualStyleBackColor = true;
            this.eyePassword.Click += new System.EventHandler(this.eyePassword_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(140, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 1);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(140, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 1);
            this.panel6.TabIndex = 1;
            // 
            // passwordWarningText
            // 
            this.passwordWarningText.AutoSize = true;
            this.passwordWarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.passwordWarningText.ForeColor = System.Drawing.Color.Red;
            this.passwordWarningText.Location = new System.Drawing.Point(143, 113);
            this.passwordWarningText.Name = "passwordWarningText";
            this.passwordWarningText.Size = new System.Drawing.Size(0, 13);
            this.passwordWarningText.TabIndex = 5;
            // 
            // loginPasswordInput
            // 
            this.loginPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.loginPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginPasswordInput.ForeColor = System.Drawing.Color.White;
            this.loginPasswordInput.Location = new System.Drawing.Point(140, 82);
            this.loginPasswordInput.Name = "loginPasswordInput";
            this.loginPasswordInput.Size = new System.Drawing.Size(240, 19);
            this.loginPasswordInput.TabIndex = 4;
            // 
            // labelForPassword
            // 
            this.labelForPassword.FlatAppearance.BorderSize = 0;
            this.labelForPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelForPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelForPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelForPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.labelForPassword.IconColor = System.Drawing.Color.Gainsboro;
            this.labelForPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.labelForPassword.IconSize = 24;
            this.labelForPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelForPassword.Location = new System.Drawing.Point(3, 75);
            this.labelForPassword.Name = "labelForPassword";
            this.labelForPassword.Size = new System.Drawing.Size(113, 34);
            this.labelForPassword.TabIndex = 3;
            this.labelForPassword.Text = "Password";
            this.labelForPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelForPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.labelForPassword.UseVisualStyleBackColor = true;
            // 
            // usernameWarningText
            // 
            this.usernameWarningText.AutoSize = true;
            this.usernameWarningText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.usernameWarningText.ForeColor = System.Drawing.Color.Red;
            this.usernameWarningText.Location = new System.Drawing.Point(144, 47);
            this.usernameWarningText.Name = "usernameWarningText";
            this.usernameWarningText.Size = new System.Drawing.Size(0, 13);
            this.usernameWarningText.TabIndex = 2;
            // 
            // loginUsernameInput
            // 
            this.loginUsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.loginUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginUsernameInput.ForeColor = System.Drawing.Color.White;
            this.loginUsernameInput.Location = new System.Drawing.Point(140, 17);
            this.loginUsernameInput.Name = "loginUsernameInput";
            this.loginUsernameInput.Size = new System.Drawing.Size(240, 19);
            this.loginUsernameInput.TabIndex = 1;
            // 
            // labelForUsername
            // 
            this.labelForUsername.FlatAppearance.BorderSize = 0;
            this.labelForUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelForUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelForUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelForUsername.IconChar = FontAwesome.Sharp.IconChar.User;
            this.labelForUsername.IconColor = System.Drawing.Color.Gainsboro;
            this.labelForUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.labelForUsername.IconSize = 24;
            this.labelForUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelForUsername.Location = new System.Drawing.Point(3, 10);
            this.labelForUsername.Name = "labelForUsername";
            this.labelForUsername.Size = new System.Drawing.Size(113, 34);
            this.labelForUsername.TabIndex = 0;
            this.labelForUsername.Text = "Username";
            this.labelForUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelForUsername.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.labelForUsername.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(887, 475);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LoginFormControl.ResumeLayout(false);
            this.LoginFormControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton closeLoginPageBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LoginFormControl;
        private System.Windows.Forms.TextBox loginUsernameInput;
        private FontAwesome.Sharp.IconButton labelForUsername;
        private System.Windows.Forms.Label usernameWarningText;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwordWarningText;
        private System.Windows.Forms.TextBox loginPasswordInput;
        private FontAwesome.Sharp.IconButton labelForPassword;
        private System.Windows.Forms.Label forgetPassword;
        private System.Windows.Forms.Label directToRegisterPage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton eyePassword;
    }
}