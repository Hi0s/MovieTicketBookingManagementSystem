using MovieTicketBookingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem
{
    public partial class UserEditForm : Form
    {
        private int userID;
        private Users user = new Users();
        Point lastPoint;
        public event EventHandler RequestClose;
        public UserEditForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            user=AdminService.ShowUsers(userID);
            edituser_userid_txt.Text=user.UserID.ToString();
            edituser_username_txt.Text = user.Username.ToString();
            edituser_firstname_txt.Text = user.Firstname;
            edituser_lastname_txt.Text = user.Lastname;
            edituser_male_rb.Checked = user.Gender == "male";
            edituser_female_rb.Checked = user.Gender == "female";
            edituser_birthdate_datepicker.Value = user.Birthdate;
            edituser_email_txt.Text= user.Email;
            edituser_phone_txt.Text = user.Phone;
            edituser_address_txt.Text = user.Address;

            edituser_user_rb.Checked=user.Role == "user";
            edituser_admin_rb.Checked = user.Role == "admin";

            edituser_createdat_txt.Text = user.CreatedAt.ToString("M/d/yyyy");
            edituser_active_rb.Checked = user.IsActive;
            edituser_inactive_rb.Checked = !user.IsActive;
            if (user.UserID == 1)
            {
                edituser_admin_rb.Enabled = false;
                edituser_user_rb.Enabled = false;
                edituser_active_rb.Enabled = false;
                edituser_inactive_rb.Enabled = false;
            }

        }

        private void editmovie_return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserEditForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.ParentForm != null)
            {
                this.ParentForm.Left += e.X - lastPoint.X;
                this.ParentForm.Top += e.Y - lastPoint.Y;
            }
        }

        private void UserEditForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void editmovie_save_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateUserFields())
                return;
            user.Username = edituser_username_txt.Text.Trim();
            user.UserID = int.Parse(edituser_userid_txt.Text.Trim());
            user.Firstname = edituser_firstname_txt.Text.Trim();
            user.Lastname = edituser_lastname_txt.Text.Trim();
            user.Gender=edituser_female_rb.Checked? "female" : edituser_male_rb.Checked? "male" : throw new InvalidOperationException("Please select a gender.");
            user.Email = edituser_email_txt.Text.Trim();
            user.Birthdate= edituser_birthdate_datepicker.Value;
            user.Phone = edituser_phone_txt.Text.Trim();
            user.Address = edituser_address_txt.Text.Trim();
            user.Role=edituser_admin_rb.Checked? "admin" : edituser_user_rb.Checked? "user" : throw new InvalidOperationException("Please select a user role.");
            user.IsActive = edituser_active_rb.Checked ? true :
                edituser_inactive_rb.Checked ? false : throw new InvalidOperationException("Please select an active status.");
            AdminService.UpdateUser(user);
            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RequestClose?.Invoke(this, EventArgs.Empty);
        }
        private bool ValidateUserFields()
        {
            if (string.IsNullOrWhiteSpace(edituser_username_txt.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(edituser_userid_txt.Text))
            {
                MessageBox.Show("UserID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(edituser_userid_txt.Text.Trim(), out _))
            {
                MessageBox.Show("UserID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(edituser_firstname_txt.Text))
            {
                MessageBox.Show("First name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(edituser_lastname_txt.Text))
            {
                MessageBox.Show("Last name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!edituser_male_rb.Checked && !edituser_female_rb.Checked)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (edituser_birthdate_datepicker.Value >= DateTime.Now)
            {
                MessageBox.Show("Birthdate must be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(edituser_email_txt.Text) ||
                !Validator.IsValidEmail(edituser_email_txt.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(edituser_phone_txt.Text) ||
                !Validator.IsValidPhone(edituser_phone_txt.Text))
            {
                MessageBox.Show("Please enter a valid phone number (10 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(edituser_address_txt.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!edituser_admin_rb.Checked && !edituser_user_rb.Checked)
            {
                MessageBox.Show("Please select a user role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!edituser_active_rb.Checked && !edituser_inactive_rb.Checked)
            {
                MessageBox.Show("Please select active/inactive status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // All fields validated successfully
        }

    }
}
