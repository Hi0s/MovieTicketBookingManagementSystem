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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
            admin_dashboard_btn_Click(new object(), new EventArgs());
            this.ActiveControl = admin_dashboard_btn;
            LoadMoviesGridView(new object(), new EventArgs());


        }

        private void admin_dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard_btn.BackColor = Color.FromArgb(46, 51, 73);
            admin_manageusers_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managemovies_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managetickets_btn.BackColor = Color.FromArgb(79, 144, 255);
            // Open the Dashboard panel
            // Hide the other panels if they are visible
            //this.admin_dashboard_pnl.BringToFront();
            //this.admin_dashboard_pnl.Visible = true;
            this.manage_movies_pnl.Visible = false;
            //this.manage_users_pnl.Visible = false;
            //this.manage_tickets_pnl.Visible = false;

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
            //this.manage_users_pnl.Visible = false;
            //this.manage_tickets_pnl.Visible = false;
            //this.admin_dashboard_pnl.Visible = false;
            

        }

        private void admin_manageusers_btn_Click(object sender, EventArgs e)
        {
            admin_manageusers_btn.BackColor = Color.FromArgb(46, 51, 73);
            admin_managetickets_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managemovies_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_dashboard_btn.BackColor = Color.FromArgb(79, 144, 255);
            // Open the Manage Users panel
            // Hide the other panels if they are visible
            //this.manage_users_pnl.BringToFront();
            //this.manage_users_pnl.Visible = true;
            //this.admin_dashboard_pnl.Visible = false;
            this.manage_movies_pnl.Visible = false;
            //this.manage_tickets_pnl.Visible = false;
        }

        private void admin_managetickets_btn_Click(object sender, EventArgs e)
        {
            admin_managetickets_btn.BackColor = Color.FromArgb(46, 51, 73);
            admin_manageusers_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_managemovies_btn.BackColor = Color.FromArgb(79, 144, 255);
            admin_dashboard_btn.BackColor = Color.FromArgb(79, 144, 255);
            // Open the Manage Movies panel
            // Hide the other panels if they are visible
            //this.manage_tickets_pnl.BringToFront();
            //this.manage_tickets_pnl.Visible = true;
            //this.manage_users_pnl.Visible = false;
            this.manage_movies_pnl.Visible = false;
            //this.admin_dashboard_pnl.Visible = false;
            


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


        private void LoadMoviesGridView(object sender, EventArgs e)
        {
            AdminService.ShowActiveMovies(manage_movie_datagridview);
        }

        private void admin_movieedit_btn_Click(object sender, EventArgs e)
        {
            //if(manage_movie_datagridview.SelectedRows.Count <1)
            //{
            //    MessageBox.Show("Please select a movie to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            //}
            //else if(manage_movie_datagridview.SelectedRows.Count > 1)
            //{
            //    MessageBox.Show("Please select only one movie to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


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
            lastPoint=new Point(e.X, e.Y); // Store the current mouse position
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
    }
}
