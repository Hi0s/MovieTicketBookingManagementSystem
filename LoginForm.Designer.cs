﻿namespace MovieTicketBookingManagementSystem
{
    partial class LoginForm
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
            this.login_login_lbl = new System.Windows.Forms.Label();
            this.login_signup_lbl = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password_lbl = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_showPassword = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.login_username_lbl = new System.Windows.Forms.Label();
            this.login_signupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_login_lbl
            // 
            this.login_login_lbl.AutoSize = true;
            this.login_login_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_login_lbl.ForeColor = System.Drawing.Color.White;
            this.login_login_lbl.Location = new System.Drawing.Point(32, 76);
            this.login_login_lbl.Name = "login_login_lbl";
            this.login_login_lbl.Size = new System.Drawing.Size(173, 22);
            this.login_login_lbl.TabIndex = 0;
            this.login_login_lbl.Text = "LOGIN ACCOUNT";
            // 
            // login_signup_lbl
            // 
            this.login_signup_lbl.AutoSize = true;
            this.login_signup_lbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signup_lbl.ForeColor = System.Drawing.Color.White;
            this.login_signup_lbl.Location = new System.Drawing.Point(79, 571);
            this.login_signup_lbl.Name = "login_signup_lbl";
            this.login_signup_lbl.Size = new System.Drawing.Size(136, 17);
            this.login_signup_lbl.TabIndex = 0;
            this.login_signup_lbl.Text = "Create an account?";
            // 
            // login_username
            // 
            this.login_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(36, 167);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(224, 31);
            this.login_username.TabIndex = 1;
            // 
            // login_password_lbl
            // 
            this.login_password_lbl.AutoSize = true;
            this.login_password_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password_lbl.ForeColor = System.Drawing.Color.White;
            this.login_password_lbl.Location = new System.Drawing.Point(33, 231);
            this.login_password_lbl.Name = "login_password_lbl";
            this.login_password_lbl.Size = new System.Drawing.Size(80, 17);
            this.login_password_lbl.TabIndex = 0;
            this.login_password_lbl.Text = "Password";
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(36, 251);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(224, 31);
            this.login_password.TabIndex = 2;
            // 
            // login_showPassword
            // 
            this.login_showPassword.AutoSize = true;
            this.login_showPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPassword.ForeColor = System.Drawing.Color.White;
            this.login_showPassword.Location = new System.Drawing.Point(34, 341);
            this.login_showPassword.Name = "login_showPassword";
            this.login_showPassword.Size = new System.Drawing.Size(116, 19);
            this.login_showPassword.TabIndex = 3;
            this.login_showPassword.Text = "Show Password";
            this.login_showPassword.UseVisualStyleBackColor = true;
            this.login_showPassword.CheckedChanged += new System.EventHandler(this.login_showPassword_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.White;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.login_btn.Location = new System.Drawing.Point(36, 387);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(215, 36);
            this.login_btn.TabIndex = 4;
            this.login_btn.TabStop = false;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(266, -1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(35, 35);
            this.close_btn.TabIndex = 6;
            this.close_btn.TabStop = false;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // login_username_lbl
            // 
            this.login_username_lbl.AutoSize = true;
            this.login_username_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username_lbl.ForeColor = System.Drawing.Color.White;
            this.login_username_lbl.Location = new System.Drawing.Point(33, 147);
            this.login_username_lbl.Name = "login_username_lbl";
            this.login_username_lbl.Size = new System.Drawing.Size(83, 17);
            this.login_username_lbl.TabIndex = 0;
            this.login_username_lbl.Text = "Username";
            // 
            // login_signupBtn
            // 
            this.login_signupBtn.BackColor = System.Drawing.Color.White;
            this.login_signupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_signupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.login_signupBtn.Location = new System.Drawing.Point(36, 611);
            this.login_signupBtn.Name = "login_signupBtn";
            this.login_signupBtn.Size = new System.Drawing.Size(215, 36);
            this.login_signupBtn.TabIndex = 5;
            this.login_signupBtn.TabStop = false;
            this.login_signupBtn.Text = "Register here";
            this.login_signupBtn.UseVisualStyleBackColor = false;
            this.login_signupBtn.Click += new System.EventHandler(this.login_signupBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(299, 680);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.login_signupBtn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_showPassword);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username_lbl);
            this.Controls.Add(this.login_password_lbl);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.login_signup_lbl);
            this.Controls.Add(this.login_login_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_login_lbl;
        private System.Windows.Forms.Label login_signup_lbl;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label login_password_lbl;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.CheckBox login_showPassword;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label login_username_lbl;
        private System.Windows.Forms.Button login_signupBtn;
    }
}

