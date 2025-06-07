namespace MovieTicketBookingManagementSystem
{
    partial class RegisterForm
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
            this.close_btn = new System.Windows.Forms.Button();
            this.reg_loginBtn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.reg_showPassword = new System.Windows.Forms.CheckBox();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.reg_username_lbl = new System.Windows.Forms.Label();
            this.reg_password_lbl = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.reg_login_lbl = new System.Windows.Forms.Label();
            this.reg_signup_lbl = new System.Windows.Forms.Label();
            this.regcPassword_lbl = new System.Windows.Forms.Label();
            this.reg_cPassword = new System.Windows.Forms.TextBox();
            this.reg_firstName_lbl = new System.Windows.Forms.Label();
            this.reg_firstName = new System.Windows.Forms.TextBox();
            this.reg_lastName_lbl = new System.Windows.Forms.Label();
            this.reg_lastName = new System.Windows.Forms.TextBox();
            this.reg_dateOfBirth_lbl = new System.Windows.Forms.Label();
            this.reg_gender_lbl = new System.Windows.Forms.Label();
            this.reg_male_btn = new System.Windows.Forms.RadioButton();
            this.reg_female_btn = new System.Windows.Forms.RadioButton();
            this.reg_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.reg_email_lbl = new System.Windows.Forms.Label();
            this.reg_phoneNumber = new System.Windows.Forms.TextBox();
            this.reg_phoneNumber_lbl = new System.Windows.Forms.Label();
            this.reg_address = new System.Windows.Forms.TextBox();
            this.reg_address_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(318, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(35, 35);
            this.close_btn.TabIndex = 14;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // reg_loginBtn
            // 
            this.reg_loginBtn.BackColor = System.Drawing.Color.White;
            this.reg_loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reg_loginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.reg_loginBtn.Location = new System.Drawing.Point(73, 990);
            this.reg_loginBtn.Name = "reg_loginBtn";
            this.reg_loginBtn.Size = new System.Drawing.Size(215, 36);
            this.reg_loginBtn.TabIndex = 14;
            this.reg_loginBtn.Text = "Sign in here";
            this.reg_loginBtn.UseVisualStyleBackColor = false;
            this.reg_loginBtn.Click += new System.EventHandler(this.reg_loginBtn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.White;
            this.reg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reg_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.reg_btn.Location = new System.Drawing.Point(35, 833);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(291, 60);
            this.reg_btn.TabIndex = 13;
            this.reg_btn.Text = "REGISTER";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg_showPassword
            // 
            this.reg_showPassword.AutoSize = true;
            this.reg_showPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_showPassword.ForeColor = System.Drawing.Color.White;
            this.reg_showPassword.Location = new System.Drawing.Point(36, 372);
            this.reg_showPassword.Name = "reg_showPassword";
            this.reg_showPassword.Size = new System.Drawing.Size(116, 19);
            this.reg_showPassword.TabIndex = 4;
            this.reg_showPassword.Text = "Show Password";
            this.reg_showPassword.UseVisualStyleBackColor = true;
            this.reg_showPassword.CheckedChanged += new System.EventHandler(this.reg_showPassword_CheckedChanged);
            // 
            // reg_password
            // 
            this.reg_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password.Location = new System.Drawing.Point(36, 252);
            this.reg_password.Multiline = true;
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.Size = new System.Drawing.Size(224, 31);
            this.reg_password.TabIndex = 2;
            // 
            // reg_username_lbl
            // 
            this.reg_username_lbl.AutoSize = true;
            this.reg_username_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_username_lbl.Location = new System.Drawing.Point(33, 148);
            this.reg_username_lbl.Name = "reg_username_lbl";
            this.reg_username_lbl.Size = new System.Drawing.Size(83, 17);
            this.reg_username_lbl.TabIndex = 5;
            this.reg_username_lbl.Text = "Username";
            // 
            // reg_password_lbl
            // 
            this.reg_password_lbl.AutoSize = true;
            this.reg_password_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_password_lbl.Location = new System.Drawing.Point(33, 232);
            this.reg_password_lbl.Name = "reg_password_lbl";
            this.reg_password_lbl.Size = new System.Drawing.Size(80, 17);
            this.reg_password_lbl.TabIndex = 6;
            this.reg_password_lbl.Text = "Password";
            // 
            // reg_username
            // 
            this.reg_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Location = new System.Drawing.Point(36, 168);
            this.reg_username.Multiline = true;
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(224, 31);
            this.reg_username.TabIndex = 1;
            // 
            // reg_login_lbl
            // 
            this.reg_login_lbl.AutoSize = true;
            this.reg_login_lbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_login_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_login_lbl.Location = new System.Drawing.Point(92, 949);
            this.reg_login_lbl.Name = "reg_login_lbl";
            this.reg_login_lbl.Size = new System.Drawing.Size(175, 17);
            this.reg_login_lbl.TabIndex = 7;
            this.reg_login_lbl.Text = "Already have an account?";
            // 
            // reg_signup_lbl
            // 
            this.reg_signup_lbl.AutoSize = true;
            this.reg_signup_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_signup_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_signup_lbl.Location = new System.Drawing.Point(32, 77);
            this.reg_signup_lbl.Name = "reg_signup_lbl";
            this.reg_signup_lbl.Size = new System.Drawing.Size(95, 22);
            this.reg_signup_lbl.TabIndex = 8;
            this.reg_signup_lbl.Text = "SIGN UP ";
            // 
            // regcPassword_lbl
            // 
            this.regcPassword_lbl.AutoSize = true;
            this.regcPassword_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regcPassword_lbl.ForeColor = System.Drawing.Color.White;
            this.regcPassword_lbl.Location = new System.Drawing.Point(33, 311);
            this.regcPassword_lbl.Name = "regcPassword_lbl";
            this.regcPassword_lbl.Size = new System.Drawing.Size(142, 17);
            this.regcPassword_lbl.TabIndex = 6;
            this.regcPassword_lbl.Text = "Confirm Password";
            // 
            // reg_cPassword
            // 
            this.reg_cPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_cPassword.Location = new System.Drawing.Point(36, 331);
            this.reg_cPassword.Multiline = true;
            this.reg_cPassword.Name = "reg_cPassword";
            this.reg_cPassword.PasswordChar = '*';
            this.reg_cPassword.Size = new System.Drawing.Size(224, 31);
            this.reg_cPassword.TabIndex = 3;
            // 
            // reg_firstName_lbl
            // 
            this.reg_firstName_lbl.AutoSize = true;
            this.reg_firstName_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_firstName_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_firstName_lbl.Location = new System.Drawing.Point(35, 421);
            this.reg_firstName_lbl.Name = "reg_firstName_lbl";
            this.reg_firstName_lbl.Size = new System.Drawing.Size(87, 17);
            this.reg_firstName_lbl.TabIndex = 15;
            this.reg_firstName_lbl.Text = "First Name";
            // 
            // reg_firstName
            // 
            this.reg_firstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_firstName.Location = new System.Drawing.Point(38, 441);
            this.reg_firstName.Multiline = true;
            this.reg_firstName.Name = "reg_firstName";
            this.reg_firstName.Size = new System.Drawing.Size(121, 31);
            this.reg_firstName.TabIndex = 5;
            // 
            // reg_lastName_lbl
            // 
            this.reg_lastName_lbl.AutoSize = true;
            this.reg_lastName_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_lastName_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_lastName_lbl.Location = new System.Drawing.Point(190, 421);
            this.reg_lastName_lbl.Name = "reg_lastName_lbl";
            this.reg_lastName_lbl.Size = new System.Drawing.Size(85, 17);
            this.reg_lastName_lbl.TabIndex = 17;
            this.reg_lastName_lbl.Text = "Last Name";
            // 
            // reg_lastName
            // 
            this.reg_lastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_lastName.Location = new System.Drawing.Point(193, 441);
            this.reg_lastName.Multiline = true;
            this.reg_lastName.Name = "reg_lastName";
            this.reg_lastName.Size = new System.Drawing.Size(121, 31);
            this.reg_lastName.TabIndex = 6;
            // 
            // reg_dateOfBirth_lbl
            // 
            this.reg_dateOfBirth_lbl.AutoSize = true;
            this.reg_dateOfBirth_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_dateOfBirth_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_dateOfBirth_lbl.Location = new System.Drawing.Point(190, 491);
            this.reg_dateOfBirth_lbl.Name = "reg_dateOfBirth_lbl";
            this.reg_dateOfBirth_lbl.Size = new System.Drawing.Size(98, 17);
            this.reg_dateOfBirth_lbl.TabIndex = 19;
            this.reg_dateOfBirth_lbl.Text = "Date of birth";
            // 
            // reg_gender_lbl
            // 
            this.reg_gender_lbl.AutoSize = true;
            this.reg_gender_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_gender_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_gender_lbl.Location = new System.Drawing.Point(35, 491);
            this.reg_gender_lbl.Name = "reg_gender_lbl";
            this.reg_gender_lbl.Size = new System.Drawing.Size(63, 17);
            this.reg_gender_lbl.TabIndex = 19;
            this.reg_gender_lbl.Text = "Gender";
            // 
            // reg_male_btn
            // 
            this.reg_male_btn.AutoSize = true;
            this.reg_male_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_male_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg_male_btn.Location = new System.Drawing.Point(35, 517);
            this.reg_male_btn.Name = "reg_male_btn";
            this.reg_male_btn.Size = new System.Drawing.Size(51, 19);
            this.reg_male_btn.TabIndex = 7;
            this.reg_male_btn.TabStop = true;
            this.reg_male_btn.Text = "Male";
            this.reg_male_btn.UseVisualStyleBackColor = true;
            this.reg_male_btn.CheckedChanged += new System.EventHandler(this.reg_male_btn_CheckedChanged);
            // 
            // reg_female_btn
            // 
            this.reg_female_btn.AutoSize = true;
            this.reg_female_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_female_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reg_female_btn.Location = new System.Drawing.Point(92, 517);
            this.reg_female_btn.Name = "reg_female_btn";
            this.reg_female_btn.Size = new System.Drawing.Size(67, 19);
            this.reg_female_btn.TabIndex = 8;
            this.reg_female_btn.TabStop = true;
            this.reg_female_btn.Text = "Female";
            this.reg_female_btn.UseVisualStyleBackColor = true;
            this.reg_female_btn.CheckedChanged += new System.EventHandler(this.reg_female_btn_CheckedChanged);
            // 
            // reg_dateOfBirth
            // 
            this.reg_dateOfBirth.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_dateOfBirth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_dateOfBirth.Location = new System.Drawing.Point(193, 517);
            this.reg_dateOfBirth.Name = "reg_dateOfBirth";
            this.reg_dateOfBirth.Size = new System.Drawing.Size(114, 21);
            this.reg_dateOfBirth.TabIndex = 9;
            this.reg_dateOfBirth.ValueChanged += new System.EventHandler(this.reg_dateOfBirth_ValueChanged);
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.Location = new System.Drawing.Point(37, 594);
            this.reg_email.Multiline = true;
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(224, 31);
            this.reg_email.TabIndex = 10;
            // 
            // reg_email_lbl
            // 
            this.reg_email_lbl.AutoSize = true;
            this.reg_email_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_email_lbl.Location = new System.Drawing.Point(34, 574);
            this.reg_email_lbl.Name = "reg_email_lbl";
            this.reg_email_lbl.Size = new System.Drawing.Size(113, 17);
            this.reg_email_lbl.TabIndex = 25;
            this.reg_email_lbl.Text = "Email Address";
            // 
            // reg_phoneNumber
            // 
            this.reg_phoneNumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_phoneNumber.Location = new System.Drawing.Point(36, 683);
            this.reg_phoneNumber.Multiline = true;
            this.reg_phoneNumber.Name = "reg_phoneNumber";
            this.reg_phoneNumber.Size = new System.Drawing.Size(224, 31);
            this.reg_phoneNumber.TabIndex = 11;
            // 
            // reg_phoneNumber_lbl
            // 
            this.reg_phoneNumber_lbl.AutoSize = true;
            this.reg_phoneNumber_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_phoneNumber_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_phoneNumber_lbl.Location = new System.Drawing.Point(33, 663);
            this.reg_phoneNumber_lbl.Name = "reg_phoneNumber_lbl";
            this.reg_phoneNumber_lbl.Size = new System.Drawing.Size(114, 17);
            this.reg_phoneNumber_lbl.TabIndex = 27;
            this.reg_phoneNumber_lbl.Text = "Phone number";
            // 
            // reg_address
            // 
            this.reg_address.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_address.Location = new System.Drawing.Point(36, 768);
            this.reg_address.Multiline = true;
            this.reg_address.Name = "reg_address";
            this.reg_address.Size = new System.Drawing.Size(224, 31);
            this.reg_address.TabIndex = 12;
            // 
            // reg_address_lbl
            // 
            this.reg_address_lbl.AutoSize = true;
            this.reg_address_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_address_lbl.ForeColor = System.Drawing.Color.White;
            this.reg_address_lbl.Location = new System.Drawing.Point(33, 748);
            this.reg_address_lbl.Name = "reg_address_lbl";
            this.reg_address_lbl.Size = new System.Drawing.Size(69, 17);
            this.reg_address_lbl.TabIndex = 29;
            this.reg_address_lbl.Text = "Address";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(353, 1048);
            this.Controls.Add(this.reg_address);
            this.Controls.Add(this.reg_address_lbl);
            this.Controls.Add(this.reg_phoneNumber);
            this.Controls.Add(this.reg_phoneNumber_lbl);
            this.Controls.Add(this.reg_email);
            this.Controls.Add(this.reg_email_lbl);
            this.Controls.Add(this.reg_dateOfBirth);
            this.Controls.Add(this.reg_female_btn);
            this.Controls.Add(this.reg_male_btn);
            this.Controls.Add(this.reg_gender_lbl);
            this.Controls.Add(this.reg_dateOfBirth_lbl);
            this.Controls.Add(this.reg_lastName_lbl);
            this.Controls.Add(this.reg_lastName);
            this.Controls.Add(this.reg_firstName_lbl);
            this.Controls.Add(this.reg_firstName);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.reg_loginBtn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_showPassword);
            this.Controls.Add(this.reg_cPassword);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.regcPassword_lbl);
            this.Controls.Add(this.reg_username_lbl);
            this.Controls.Add(this.reg_password_lbl);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.reg_login_lbl);
            this.Controls.Add(this.reg_signup_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button reg_loginBtn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.CheckBox reg_showPassword;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label reg_username_lbl;
        private System.Windows.Forms.Label reg_password_lbl;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label reg_login_lbl;
        private System.Windows.Forms.Label reg_signup_lbl;
        private System.Windows.Forms.Label regcPassword_lbl;
        private System.Windows.Forms.TextBox reg_cPassword;
        private System.Windows.Forms.Label reg_firstName_lbl;
        private System.Windows.Forms.TextBox reg_firstName;
        private System.Windows.Forms.Label reg_lastName_lbl;
        private System.Windows.Forms.TextBox reg_lastName;
        private System.Windows.Forms.Label reg_dateOfBirth_lbl;
        private System.Windows.Forms.Label reg_gender_lbl;
        private System.Windows.Forms.RadioButton reg_male_btn;
        private System.Windows.Forms.RadioButton reg_female_btn;
        private System.Windows.Forms.DateTimePicker reg_dateOfBirth;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.Label reg_email_lbl;
        private System.Windows.Forms.TextBox reg_phoneNumber;
        private System.Windows.Forms.Label reg_phoneNumber_lbl;
        private System.Windows.Forms.TextBox reg_address;
        private System.Windows.Forms.Label reg_address_lbl;
    }
}