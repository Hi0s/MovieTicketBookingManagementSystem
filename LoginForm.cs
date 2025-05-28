using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MovieTicketBookingManagementSystem.Models;
using MovieTicketBookingManagementSystem.Config;

namespace MovieTicketBookingManagementSystem
{
    public partial class LoginForm : Form
    {
        string conn = DatabaseConfig.ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = login_btn;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar=login_showPassword.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(UserService.AuthenticateUser(login_username.Text.Trim(), login_password.Text.Trim(),out string role))
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (role == "admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else if (role == "user")
                {
                    userdashboard userDashboard = new userdashboard();
                    userDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Unknown role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
