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
using System.Data.SqlClient;

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
        private DataGridView moviesDataGridView;
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
                    poster.Load(imageUrl);
            }
            catch
            {
                poster.BackColor = Color.Gray;
            }


            // Top tag label 
            Label tag = new Label
            {
                Text = $"Movie: {name}",
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
                Text = $"★ {rating}/10",
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

            Button buyButton = new Button
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
            buyButton.FlatAppearance.BorderSize = 0;
            // Center the button
            buyButton.Location = new Point(
                (poster.Width - buyButton.Width) / 2,
                (poster.Height - buyButton.Height) / 2
            );
            // Re-center on resize
            poster.Resize += (s, e) =>
            {
                buyButton.Location = new Point(
                    (poster.Width - buyButton.Width) / 2,
                    (poster.Height - buyButton.Height) / 2
                );
            };
            poster.Controls.Add(buyButton);
            buyButton.BringToFront();

            // Show/hide button on hover
            poster.MouseEnter += (s, e) => buyButton.Visible = true;
            poster.MouseLeave += (s, e) => buyButton.Visible = false;
            buyButton.MouseEnter += (s, e) => buyButton.Visible = true;
            buyButton.MouseLeave += (s, e) => buyButton.Visible = false;

            card.Controls.Add(poster);


            return card;
        }

        private void listofmovie_Click(object sender, EventArgs e)
        {
            listofmovie_btn.BackColor = Color.FromArgb(46, 51, 73);

            // Create a scrollable panel

            Panel scrollPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.LightGray
            };
            scrollPanel.AutoScroll = true;

            if (manage_movies_pnl.Controls.Contains(scrollPanel))
            {
                manage_movies_pnl.Controls.Remove(scrollPanel);
                scrollPanel.Dispose();
            }

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
            string connString = MovieTicketBookingManagementSystem.Config.DatabaseConfig.ConnectionString;
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
            manage_movies_pnl.Controls.Add(scrollPanel);
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
