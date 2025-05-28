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

        

        public AdminDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            admin_dashboard_btn_Click(new object(), new EventArgs());
            this.ActiveControl = admin_dashboard_btn;

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
            addMoviesForm.ShowDialog();
        }
        private void admin_addshowtime_btn_Click_1(object sender, EventArgs e)
        {
            AddShowtimeForm addShowtimeForm = new AddShowtimeForm();
            addShowtimeForm.TopLevel = false;
            addShowtimeForm.FormBorderStyle = FormBorderStyle.None;
            addShowtimeForm.Dock = DockStyle.Fill;

            // Subscribe to the close event
            addShowtimeForm.RequestClose += (s, args) => manage_movies_pnl.Controls.Remove(addShowtimeForm);

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
