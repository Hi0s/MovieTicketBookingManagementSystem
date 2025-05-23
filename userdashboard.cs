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
    public partial class userdashboard : Form
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
        public userdashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            listofmovie_Click(new object(), new EventArgs());
            this.AcceptButton = listofmovie_btn;
        }

        private void userdashboard_Load(object sender, EventArgs e)
        {

        }

        private void listofmovie_Click(object sender, EventArgs e)
        {
            listofmovie_btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void yourticket_btn_Click(object sender, EventArgs e)
        {
            yourticket_btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void listofmovie_btn_Leave(object sender, EventArgs e)
        {
            listofmovie_btn.BackColor = Color.FromArgb(79, 144, 255);
        }

        private void yourticket_btn_Leave(object sender, EventArgs e)
        {
            yourticket_btn.BackColor = Color.FromArgb(79, 144, 255);
        }

        private void admin_logout_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
