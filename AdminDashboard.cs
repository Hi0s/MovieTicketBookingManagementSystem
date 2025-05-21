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
            

        }

        private void admin_dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard_btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void admin_managemovies_btn_Click(object sender, EventArgs e)
        {
            admin_managemovies_btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void admin_manageusers_btn_Click(object sender, EventArgs e)
        {
            admin_manageusers_btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void admin_managetickets_btn_Click(object sender, EventArgs e)
        {
            admin_managetickets_btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void admin_dashboard_btn_Leave(object sender, EventArgs e)
        {
            admin_dashboard_btn.BackColor = Color.FromArgb(79, 144, 255); 
        }

        private void admin_managemovies_btn_Leave(object sender, EventArgs e)
        {
            admin_managemovies_btn.BackColor = Color.FromArgb(79, 144, 255);
        }

        private void admin_manageusers_btn_Leave(object sender, EventArgs e)
        {
            admin_manageusers_btn.BackColor = Color.FromArgb(79, 144, 255);
        }

        private void admin_managetickets_btn_Leave(object sender, EventArgs e)
        {
            admin_managetickets_btn.BackColor = Color.FromArgb(79, 144, 255);
        }
    }
}
