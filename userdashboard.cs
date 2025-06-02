using MovieTicketBookingManagementSystem.Config;
using MovieTicketBookingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem
{
    public partial class userdashboard : Form
    {
        Point lastPoint;
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
        private DataGridView moviesDataGridView;
        public userdashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            listofmovie_Click(new object(), new EventArgs());
            this.ActiveControl = listofmovie_btn;
        }

        private void userdashboard_Load(object sender, EventArgs e)
        {
            admin_username_lbl.Text = SessionManager.Username;
            admin_username_lbl.Location = new Point(menu_pnl.Width/2-admin_username_lbl.Width/2, 124);
        }


        private Panel CreateMoviePanel(string movieID, string name, string rating, string releaseDate, string imageUrl)
        {
            // Main card panel
            Panel card = new Panel
            {
                Size = new Size(290, 208),
                BackColor = Color.FromArgb(32, 32, 32),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None
            };

            // Poster image (fills the card)
            PictureBox poster = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Black
            };
            try
            {
                if (!string.IsNullOrEmpty(imageUrl))
                    poster.LoadAsync(imageUrl); // Use async loading to prevent UI lag
            }
            catch
            {
                poster.BackColor = Color.Gray;
            }


            // Top tag label 
            Label tag = new Label
            {
                Text = $"{name}",
                AutoSize = true,
                BackColor = Color.FromArgb(220, 60, 40),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Padding = new Padding(6, 2, 6, 2),
                Location = new Point(8, 8),
                Parent = card
            };
            card.Controls.Add(tag);
            tag.BringToFront();


            Panel overlayPanel = new Panel
            {
                Height = 48,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(160, 0, 0, 0) // semi-transparent black
            };

            // Release date label (first row)
            Label releaseLabel = new Label
            {
                Text = $"Release: {releaseDate}",
                Dock = DockStyle.Top,
                Height = 24,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            // Rating label (second row, with gold star)
            Label ratingLabel = new Label
            {
                Text = $"{rating}",
                Dock = DockStyle.Top,
                Height = 24,
                BackColor = Color.Transparent,
                ForeColor = Color.Gold,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            // Add labels to overlay panel (releaseLabel first, then ratingLabel)
            overlayPanel.Controls.Add(ratingLabel);
            overlayPanel.Controls.Add(releaseLabel);

            // Add overlay panel to poster
            poster.Controls.Add(overlayPanel);
            overlayPanel.BringToFront();

            Button viewDetail = new Button
            {
                Text = "View Detail",
                BackColor = Color.FromArgb(220, 60, 40),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 36),
                Visible = false,
                Tag = movieID
            };

            // Add event handler for button click
  
                viewDetail.Click += (s, e) =>
                {
                    // Hide panel1
                    panel1.Visible = false;

                    // Remove any existing DetailMovie controls
                    foreach (Control ctrl in manage_movies_pnl.Controls.OfType<DetailMovie>().ToList())
                    {
                        manage_movies_pnl.Controls.Remove(ctrl);
                        ctrl.Dispose();
                    }

                    // Optionally, pass movieID to DetailMovie via constructor or property if needed
                    DetailMovie detailForm = new DetailMovie(movieID);
                    detailForm.TopLevel = false;
                    detailForm.FormBorderStyle = FormBorderStyle.None;
                    detailForm.Dock = DockStyle.Fill;
                    detailForm.RequestClose += (sender2, args2) =>
                    {
                        panel1.Visible = true;
                        manage_movies_pnl.Controls.Remove(detailForm);
                        detailForm.Dispose();
                    };

                    manage_movies_pnl.Controls.Add(detailForm);
                    detailForm.BringToFront();
                    detailForm.Show();
                    viewDetail.Text = "View Detail";
                };
       


            viewDetail.FlatAppearance.BorderSize = 0;
            // Center the button
            viewDetail.Location = new Point(
                (poster.Width - viewDetail.Width) / 2,
                (poster.Height - viewDetail.Height) / 2
            );
            // Re-center on resize
            poster.Resize += (s, e) =>
            {
                viewDetail.Location = new Point(
                    (poster.Width - viewDetail.Width) / 2,
                    (poster.Height - viewDetail.Height) / 2
                );
            };
            poster.Controls.Add(viewDetail);
            viewDetail.BringToFront();

            // Show/hide button on hover
            Timer hideTimer = new Timer { Interval = 10 }; // 10

            poster.MouseEnter += (s, e) => {
                hideTimer.Stop();
                viewDetail.Visible = true;
            };
            poster.MouseLeave += (s, e) => {
                hideTimer.Start();
            };
            viewDetail.MouseEnter += (s, e) => {
                hideTimer.Stop();
                viewDetail.Visible = true;
            };
            viewDetail.MouseLeave += (s, e) => {
                hideTimer.Start();
            };
            hideTimer.Tick += (s, e) => {
                viewDetail.Visible = false;
                hideTimer.Stop();
            };
          
            card.Controls.Add(poster);


            return card;
        }

        private Panel CreateTicketPanel(string movieName, DateTime movieTime, DateTime bookingTime, decimal price, string theaterName, string seatCode)
        {
            Panel ticketPanel = new Panel
            {
                Size = new Size(500, 100),
                BackColor = Color.White,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None
            };

            // Add border radius to panel
            ticketPanel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ticketPanel.Width, ticketPanel.Height, 20, 20));


            // Movie Name
            Label lblMovie = new Label
            {
                Text = $"Movie: {movieName}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            ticketPanel.Controls.Add(lblMovie);

            // Time MovieShow
            Label lblMovieTime = new Label
            {
                Text = $"Movie Show: {movieTime:G}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(10, 35),
                AutoSize = true
            };
            ticketPanel.Controls.Add(lblMovieTime);


            // Seat Code
            Label lblSeat = new Label
            {
                Text = $"Seat: {seatCode}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(250, 35),
                AutoSize = true
            };
            ticketPanel.Controls.Add(lblSeat);

            // Time Buy
            Label lblTime = new Label
            {
                Text = $"Booking Time: {bookingTime:G}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(10, 55),
                AutoSize = true
            };
            ticketPanel.Controls.Add(lblTime);


            // Theater Name
            Label lblTheater = new Label
            {
                Text = $"Theater: {theaterName}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(250, 55),
                AutoSize = true
            };
            ticketPanel.Controls.Add(lblTheater);

            // Pricing
            Label lblPrice = new Label
            {
                Text = $"Price: ${price}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(10, 75),
                AutoSize = true
            };
            ticketPanel.Controls.Add(lblPrice);


            return ticketPanel;
        }

        private void listofmovie_Click(object sender, EventArgs e)
        {
            listofmovie_btn.BackColor = Color.FromArgb(46, 51, 73);
            label1.Text = "List of Movies";

            manage_movies_pnl.Controls.Clear();
            manage_movies_pnl.Controls.Add(panel1);
            panel1.Visible = true;



            // Create a scrollable panel
            Panel scrollPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.LightGray
            };
            scrollPanel.AutoScroll = true;

            // Create TableLayoutPanel for 3 columns, many rows
            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 3,
                Dock = DockStyle.Top,
                Padding = new Padding(0,50,0,100),
                BackColor = Color.LightGray,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3f));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3f));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3f));

            // Load movies from database
            string connString = DatabaseConfig.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT MovieID, Title, Rating, ReleaseDate, PosterPath FROM movies WHERE IsActive = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read())
                    {
                        string title = reader["Title"].ToString();
                        string rating = reader["Rating"].ToString();
                        string releaseDate = reader["ReleaseDate"] != DBNull.Value
                            ? Convert.ToDateTime(reader["ReleaseDate"]).ToShortDateString()
                            : "N/A";
                        string posterPath = reader["PosterPath"]?.ToString();
                        string movieId = reader["MovieID"].ToString();
                        string imageUrl = (!string.IsNullOrEmpty(posterPath) && System.IO.File.Exists(posterPath))
                            ? posterPath
                            : "";

                        Panel moviePanel = CreateMoviePanel(movieId, title, rating, releaseDate, imageUrl);

                        int col = index % 3;
                        int row = index / 3;

                        if (table.RowCount <= row)
                            table.RowCount = row + 1;

                        table.Controls.Add(moviePanel, col, row);
                        index++;
                    }
                }
            }

            scrollPanel.Controls.Add(table);
            // Add the scrollPanel with key "scrollPanel" to manage_movies_pnl
            scrollPanel.Name = "scrollPanel";
            manage_movies_pnl.Controls.Add(scrollPanel);
        }

        private void yourticket_btn_Click(object sender, EventArgs e)
        {
            // Clear all form 
            yourticket_btn.BackColor = Color.FromArgb(46, 51, 73);
            label1.Text = "List of Tickets";
            // Clear all controls in manage_movies_pnl except for the panel1
            manage_movies_pnl.Controls.Clear();
            manage_movies_pnl.Controls.Add(panel1);
            panel1.Visible = true;



            Panel scrollPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.LightGray
            };
            scrollPanel.AutoScroll = true;

            // Create TableLayoutPanel for 3 columns, many rows
            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = 1,
                Dock = DockStyle.Top,
                Padding = new Padding(0, 50, 0, 100),
                BackColor = Color.LightGray,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

            // Load tickets from database
            string connString = MovieTicketBookingManagementSystem.Config.DatabaseConfig.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT t.ShowTimeID, t.Price, t.SeatCode, t.BookingTime, m.Title, th.Name, st.StartTime 
                    FROM tickets t
                    LEFT JOIN showtimes st ON st.ShowTimeID = t.ShowTimeID
                    LEFT JOIN theaters th on th.TheaterID = st.TheaterID
                    LEFT JOIN movies m ON st.MovieID = m.MovieID
                    WHERE t.UserID = @UserID
                    ORDER BY t.BookingTime DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", SessionManager.UserID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            DateTime bookingTime = reader.GetDateTime(reader.GetOrdinal("BookingTime"));
                            decimal price = reader.GetDecimal(reader.GetOrdinal("Price"));
                            string theaterName = reader["Name"].ToString();
                            string seatCode = reader["SeatCode"].ToString();
                            DateTime movieTime = reader.GetDateTime(reader.GetOrdinal("StartTime"));
                            Panel moviePanel = CreateTicketPanel(title,
                                movieTime,
                                bookingTime,
                                price,
                                theaterName,
                                seatCode);

                            if (table.RowCount <= index)
                            {
                                table.RowCount = index + 1;
                            }

                            table.Controls.Add(moviePanel, 0, index);
                            index++;
                        }
                    }
                }
            }

            // Add DataGridView to the panel
            scrollPanel.Controls.Add(table);
            scrollPanel.Name = "scrollPanel";
            manage_movies_pnl.Controls.Add(scrollPanel);
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
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void admin_username_lbl_Click(object sender, EventArgs e)
        {

        }

        private void menu_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void menu_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
