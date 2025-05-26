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
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using MovieTicketBookingManagementSystem.Models;
using BCrypt.Net;
using MovieTicketBookingManagementSystem.Config;

namespace MovieTicketBookingManagementSystem
{
    public partial class RegisterForm : Form
    {


        string conn = DatabaseConfig.ConnectionString;
        private DateTime birthdate;
        private string gender;
        public RegisterForm()
        {
            InitializeComponent();
            this.AcceptButton=reg_btn;
            reg_dateOfBirth.Value = DateTime.Now;

        }

        private void reg_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            reg_password.PasswordChar = reg_showPassword.Checked ? '\0' : '*';
            reg_cPassword.PasswordChar = reg_showPassword.Checked ? '\0' : '*';
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reg_username.Text == "" || reg_password.Text=="" ||
                reg_cPassword.Text == "" || (!reg_female_btn.Checked && !reg_male_btn.Checked) ||
                reg_firstName.Text == ""|| reg_lastName.Text=="" || reg_email.Text=="" ||
                reg_phoneNumber.Text==""||reg_address.Text=="")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (reg_password.Text != reg_cPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (reg_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (birthdate ==DateTime.Today)
            {
                MessageBox.Show("Please choose a valid birthdate", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validator.IsValidEmail(reg_email.Text))
            {
                MessageBox.Show("Invalid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validator.IsValidPhone(reg_phoneNumber.Text))
            {
                MessageBox.Show("Invalid Phone Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UserService.IsUsernameTaken(reg_username.Text.Trim())){
                MessageBox.Show("Username already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Users user = new Users
                {
                    Username = reg_username.Text.Trim(),
                    Password = PasswordHasher.HashPassword(reg_password.Text.Trim()),
                    Firstname = reg_firstName.Text.Trim(),
                    Lastname = reg_lastName.Text.Trim(),
                    Gender=gender.Trim(),
                    Birthdate = birthdate,
                    Email = reg_email.Text.Trim(),
                    Phone = reg_phoneNumber.Text.Trim(),
                    Address = reg_address.Text.Trim(),
                    Role = "user",
                };
                bool registerSuccess = UserService.RegisterUser(user);
                if (registerSuccess)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                    MessageBox.Show("Registered Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registration Failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reg_loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void reg_male_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (reg_male_btn.Checked) {
                gender = "male";
            }
        }

        private void reg_female_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (reg_female_btn.Checked)
            {
                gender = "female";
            }
        }

        private void reg_dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            birthdate = reg_dateOfBirth.Value;
        }
    }
}
