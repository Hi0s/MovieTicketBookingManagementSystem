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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_cPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(256, 0);
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
            this.reg_loginBtn.Location = new System.Drawing.Point(36, 612);
            this.reg_loginBtn.Name = "reg_loginBtn";
            this.reg_loginBtn.Size = new System.Drawing.Size(215, 36);
            this.reg_loginBtn.TabIndex = 12;
            this.reg_loginBtn.Text = "Sign in here";
            this.reg_loginBtn.UseVisualStyleBackColor = false;
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.White;
            this.reg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reg_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.reg_btn.Location = new System.Drawing.Point(38, 418);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(215, 36);
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
            this.reg_showPassword.TabIndex = 11;
            this.reg_showPassword.Text = "Show Password";
            this.reg_showPassword.UseVisualStyleBackColor = true;
            this.reg_showPassword.CheckedChanged += new System.EventHandler(this.reg_showPassword_CheckedChanged);
            // 
            // reg_password
            // 
            this.reg_password.Location = new System.Drawing.Point(36, 252);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(217, 22);
            this.reg_password.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // reg_username
            // 
            this.reg_username.Location = new System.Drawing.Point(36, 168);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(217, 22);
            this.reg_username.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Already have an account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "SIGN UP ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password";
            // 
            // reg_cPassword
            // 
            this.reg_cPassword.Location = new System.Drawing.Point(36, 331);
            this.reg_cPassword.Name = "reg_cPassword";
            this.reg_cPassword.Size = new System.Drawing.Size(217, 22);
            this.reg_cPassword.TabIndex = 9;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(290, 680);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.reg_loginBtn);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_showPassword);
            this.Controls.Add(this.reg_cPassword);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button reg_loginBtn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.CheckBox reg_showPassword;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_cPassword;
    }
}