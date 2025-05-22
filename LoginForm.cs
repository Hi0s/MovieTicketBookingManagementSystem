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

namespace MovieTicketBookingManagementSystem
{
    public partial class LoginForm : Form
    {
        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\STUDY\IT\113-2\C\PROJECT\MOVIETICKETBOOKINGMANAGEMENTSYSTEM\DBO\MOVIE.MDF;Integrated Security=True;Connect Timeout=30";
        public LoginForm()
        {
            InitializeComponent();
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

        }
    }
}
