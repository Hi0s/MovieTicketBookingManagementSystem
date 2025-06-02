using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MovieTicketBookingManagementSystem.Models;

namespace MovieTicketBookingManagementSystem
{
    public partial class AdminDashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse

        );

        Point lastPoint;

        public AdminDashboard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
            admin_dashboard_btn_Click(new object(), new EventArgs());
            this.ActiveControl = admin_dashboard_btn;
            movies_pnl.Region = Region.FromHrgn(CreateRoundRectRgn(
    0, 0,
    movies_pnl.Width, movies_pnl.Height,
    25, 25));
            users_pnl.Region = Region.FromHrgn(CreateRoundRectRgn(
    0, 0,
    users_pnl.Width, users_pnl.Height,
    25, 25));
            bookings_pnl.Region= Region.FromHrgn(CreateRoundRectRgn(
    0, 0,
    bookings_pnl.Width, bookings_pnl.Height,
    25, 25));
            revenue_pnl.Region= Region.FromHrgn(CreateRoundRectRgn(
    0, 0,
    revenue_pnl.Width, revenue_pnl.Height,
    25, 25));



        }

        private void admin_dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard_btn.BackColor = Color.FromArgb(46, 51, 73);
            admin_manageusers_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managemovies_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managetickets_btn.BackColor = Color.FromArgb(79, 144, 255);
            LoadAdminDashboard(new object(), new EventArgs());

            // Open the Dashboard panel
            // Hide the other panels if they are visible
            //this.admin_dashboard_pnl.BringToFront();
            //this.admin_dashboard_pnl.Visible = true;
            this.manage_movies_pnl.Visible = false;
            this.manage_users_pnl.Visible = false;
            this.manage_tickets_pnl.Visible = false;


        }

        private void admin_managemovies_btn_Click(object sender, EventArgs e)
        {
            admin_managemovies_btn.BackColor = Color.FromArgb(46, 51, 73);
            admin_manageusers_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managetickets_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_dashboard_btn.BackColor = Color.FromArgb(79, 144, 255);
            LoadMoviesGridView(new object(), new EventArgs());

            // Open the Manage Movies panel
            // Hide the other panels if they are visible
            this.manage_movies_pnl.BringToFront();
            this.manage_movies_pnl.Visible = true;
            this.manage_users_pnl.Visible = false;
            this.manage_tickets_pnl.Visible = false;
            //this.admin_dashboard_pnl.Visible = false;


        }

        private void admin_manageusers_btn_Click(object sender, EventArgs e)
        {
            admin_manageusers_btn.BackColor = Color.FromArgb(46, 51, 73);
            admin_managetickets_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managemovies_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_dashboard_btn.BackColor = Color.FromArgb(79, 144, 255);

            LoadUsersGridView(new object(), new EventArgs());
            //this.manage_movies_pnl.SendToBack();
            this.manage_users_pnl.BringToFront();
            this.manage_users_pnl.Visible = true;
            this.manage_movies_pnl.Visible = false;
            //this.admin_dashboard_pnl.Visible = false;
            this.manage_tickets_pnl.Visible = false;
        }

        private void admin_managetickets_btn_Click(object sender, EventArgs e)
        {
            admin_managetickets_btn.BackColor = Color.FromArgb(46, 51, 73);
            admin_manageusers_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managemovies_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_dashboard_btn.BackColor = Color.FromArgb(79, 144, 255);
            // Open the Manage Movies panel
            // Hide the other panels if they are visible
            this.manage_tickets_pnl.BringToFront();
            this.manage_tickets_pnl.Visible = true;
            this.manage_users_pnl.Visible = false;
            this.manage_movies_pnl.Visible = false;
            //this.admin_dashboard_pnl.Visible = false;
            LoadTicketsGridView(new object(), new EventArgs());


        }

        private void admin_addmovies_btn_Click(object sender, EventArgs e)
        {
            AddMoviesForm addMoviesForm = new AddMoviesForm();
            //addMoviesForm.ShowDialog();
            addMoviesForm.TopLevel = false;
            addMoviesForm.FormBorderStyle = FormBorderStyle.None;
            addMoviesForm.Dock = DockStyle.Fill;

            // Subscribe to the close event
            addMoviesForm.RequestClose += (s, args) => {
                manage_movies_pnl.Controls.Remove(addMoviesForm);
                LoadMoviesGridView(new object(), new EventArgs()); // Refresh the movies grid view
            };

            manage_movies_pnl.Controls.Add(addMoviesForm);
            addMoviesForm.BringToFront();
            addMoviesForm.Show();

        }
        private void admin_addshowtime_btn_Click(object sender, EventArgs e)
        {
            AddShowtimeForm addShowtimeForm = new AddShowtimeForm();
            addShowtimeForm.TopLevel = false;
            addShowtimeForm.FormBorderStyle = FormBorderStyle.None;
            addShowtimeForm.Dock = DockStyle.Fill;

            // Subscribe to the close event
            addShowtimeForm.RequestClose += (s, args) => {
                manage_movies_pnl.Controls.Remove(addShowtimeForm);
                LoadMoviesGridView(new object(), new EventArgs()); // Refresh the movies grid view
            };

            manage_movies_pnl.Controls.Add(addShowtimeForm);
            addShowtimeForm.BringToFront();
            addShowtimeForm.Show();
        }

        private void admin_logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LoadAdminDashboard(object sender, EventArgs e)
        {
            movies_txt.Text = AdminService.MoviesCount().ToString().Trim();
            users_txt.Text = AdminService.UsersCount().ToString().Trim();
            bookings_txt.Text = AdminService.TicketsCount().ToString().Trim();
            revenue_txt.Text = AdminService.RevenueCalc().ToString().Trim();
            AdminService.ShowTopMovies(admin_dashboard_topmovies_gv);
            AdminService.ShowRecentBookings(admin_dashboard_recentbookings_gv);
        }

        private void LoadMoviesGridView(object sender, EventArgs e)
        {
            if(admin_activeshowtimes_rd.Checked)
                AdminService.ShowActiveMovies(manage_movie_datagridview);
            else if(admin_inactiveshowtimes_rd.Checked)
                AdminService.ShowInactiveMovies(manage_movie_datagridview);
        }
        private void LoadUsersGridView(object sender, EventArgs e)
        {
            AdminService.ShowUsers(manage_users_datagridview);
        }
        private void LoadTicketsGridView(object sender, EventArgs e)
        {
            AdminService.ShowTickets(manage_tickets_datagridview);
        }

        private void admin_movieedit_btn_Click(object sender, EventArgs e)
        {

                EditMovieForm editMovieForm = new EditMovieForm();
                editMovieForm.TopLevel = false;
                editMovieForm.FormBorderStyle = FormBorderStyle.None;
                editMovieForm.Dock = DockStyle.Fill;


                // Subscribe to the close event
                editMovieForm.RequestClose += (s, args) => {
                    manage_movies_pnl.Controls.Remove(editMovieForm);
                    LoadMoviesGridView(new object(), new EventArgs()); // Refresh the movies grid view
                };
                manage_movies_pnl.Controls.Add(editMovieForm);
                editMovieForm.BringToFront();
                editMovieForm.Show();

        }

        private void AdminDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; // Adjust the offset as needed
                this.Top += e.Y - lastPoint.Y; // Adjust the offset as needed
            }
        }

        private void AdminDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // Store the current mouse position
        }

        private void manage_movies_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // Store the current mouse position
        }

        private void manage_movies_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; // Adjust the offset as needed
                this.Top += e.Y - lastPoint.Y; // Adjust the offset as needed
            }
        }

        private void admin_activeshowtimes_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (admin_activeshowtimes_rd.Checked)
            {
                LoadMoviesGridView(new object(), new EventArgs());
                admin_cancelshowtime_btn.Enabled = true;
                admin_cancelshowtime_btn.Visible = true;
            }
            else admin_inactiveshowtimes_rd.Checked=true;
        }

        private void admin_inactiveshowtimes_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (admin_inactiveshowtimes_rd.Checked)
            {
                LoadMoviesGridView(new object(), new EventArgs());
                admin_cancelshowtime_btn.Enabled = false;
                admin_cancelshowtime_btn.Visible = false;
            }
            else admin_activeshowtimes_rd.Checked = true;
        }

        private void admin_cancelshowtime_btn_Click(object sender, EventArgs e)
        {
            if(manage_movie_datagridview.SelectedRows.Count < 1|| manage_movie_datagridview.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select an entire row to cancel its showtime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if(Convert.ToInt32(manage_movie_datagridview.SelectedRows[0].Cells["AvailableSeats"].Value) < Convert.ToInt32(manage_movie_datagridview.SelectedRows[0].Cells["TotalSeats"].Value) )
            {
                MessageBox.Show("Can not cancel this premiere, there are sold tickets already.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (manage_movie_datagridview.SelectedRows[0].Cells["Premiere Status"].Value.ToString().Trim() == "Premiered")
            {
                MessageBox.Show("This show is already premiered, can not cancel it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int movieId = Convert.ToInt32(manage_movie_datagridview.SelectedRows[0].Cells["ShowtimeID"].Value);
                _ = AdminService.CancelShowtime(movieId) ? MessageBox.Show("Successfully cancelled showtime!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    : MessageBox.Show("Failed to cancel showtime!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMoviesGridView(new object(), new EventArgs()); // Refresh the movies grid view
            }
        }

        private void admin_useredit_btn_Click(object sender, EventArgs e)
        {
            if (manage_users_datagridview.SelectedRows.Count < 1 || manage_users_datagridview.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select an entire row to edit user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int userID = Convert.ToInt32(manage_users_datagridview.SelectedRows[0].Cells["UserID"].Value); UserEditForm userEditForm = new UserEditForm(userID);
                userEditForm.TopLevel = false;
                userEditForm.FormBorderStyle = FormBorderStyle.None;
                userEditForm.Dock = DockStyle.Fill;


                // Subscribe to the close event
                userEditForm.RequestClose += (s, args) =>
                {
                    manage_users_pnl.Controls.Remove(userEditForm);
                    LoadUsersGridView(new object(), new EventArgs()); // Refresh the users grid view
                };
                manage_users_pnl.Controls.Add(userEditForm);
                userEditForm.BringToFront();
                userEditForm.Show();
            }
        }
      
    }
    
}



