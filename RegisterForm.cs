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
using MovieTicketBookingManagementSystem.Resources;
using System.Runtime.InteropServices;

namespace MovieTicketBookingManagementSystem
{
    public partial class RegisterForm : Form
    {
        

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\STUDY\IT\113-2\C\PROJECT\MOVIETICKETBOOKINGMANAGEMENTSYSTEM\DBO\MOVIE.MDF;Integrated Security=True;Connect Timeout=30";
        DateTime birthdate;
        public RegisterForm()
        {
            InitializeComponent();
            
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
            if (reg_username.Text == "" || reg_password.Text=="" || reg_cPassword.Text == "" || (!reg_female_btn.Checked && !reg_male_btn.Checked) || reg_firstName.Text == ""|| reg_lastName.Text=="" || reg_email.Text=="" ||reg_phoneNumber.Text==""||reg_address.Text=="")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (reg_password.Text != reg_cPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (reg_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (birthdate ==DateTime.Today)
            {
                MessageBox.Show("Please choose a valid birthdate", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EmailAddressValidation.IsValid(reg_email.Text))
            {
                MessageBox.Show("Invalid email address", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!PhoneNumberValidation.IsValid(reg_phoneNumber.Text))
            {
                MessageBox.Show("Invalid Phone Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM users WHERE username = @usern";
                    // Check username already in the database or not
                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                    {
                        //Replace @usern with the reg_username from input
                        checkUsern.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Username \""+reg_username.Text.Trim() + "\" is already taken", "Error Message", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(Username,Password,Firstname,Lastname,Gender,Birthdate,Email,Phone,Address,CreatedAt)" +
                                " VALUES(@usern, @pw,@fname,@lname,@gender,@birthdate,@email,@phone,@address,@createdat)";

                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", reg_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pw", reg_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@fname", reg_firstName.Text.Trim());
                                cmd.Parameters.AddWithValue("@lname", reg_lastName.Text.Trim());
                                cmd.Parameters.AddWithValue("@gender", reg_female_btn.Checked?"female":"male");
                                cmd.Parameters.AddWithValue("@birthdate",birthdate);
                                cmd.Parameters.AddWithValue("@email", reg_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@phone", reg_phoneNumber.Text.Trim());
                                cmd.Parameters.AddWithValue("@address", reg_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@createdat", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }
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

        }

        private void reg_female_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reg_dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            birthdate = reg_dateOfBirth.Value;
        }
    }
}
