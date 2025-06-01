using MovieTicketBookingManagementSystem.Config;
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
    public partial class DetailMovie : Form
    {
        protected string movieID;
        public event EventHandler RequestClose;
        public DetailMovie(string movieID)
        {
            InitializeComponent();
            this.movieID = movieID;
            loadDetailMovie(movieID);

        }

        private void loadDetailMovie(string movieID)
        {
            // Assuming you have a connection string defined somewhere
            string connectionString = DatabaseConfig.ConnectionString;
            string query = "SELECT * FROM movies WHERE MovieID = @MovieID";

            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MovieID", movieID);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Example: set label values or other controls
                        lblTitle.Text = reader["Title"].ToString();
                        lblReleaseValue.Text = reader["ReleaseDate"].ToString();
                        lblDurationValue.Text = reader["Duration"].ToString();
                        lblReleaseValue.Text = reader["ReleaseDate"] != DBNull.Value
                            ? Convert.ToDateTime(reader["ReleaseDate"]).ToShortDateString()
                            : "N/A";
                        lblPrice.Text = "$";
                        lblRatedValue.Text = "PG-" + reader["Rating"].ToString();
                        lblGenreValue.Text = reader["Genre"].ToString();
                        lblDescription.Text = reader["Description"].ToString();
                        string posterPath = reader["PosterPath"].ToString();
                        string imageUrl = (!string.IsNullOrEmpty(posterPath) && System.IO.File.Exists(posterPath))
                            ? posterPath
                            : "";
                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            pictureBox1.Load(imageUrl);

                        }
                        // Add more fields as needed
                    }
                    else
                    {
                        MessageBox.Show("Movie not found.");
                    }
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblReleaseValue_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_list_Click(object sender, EventArgs e)
        {
            if (RequestClose != null)
                RequestClose(this, EventArgs.Empty);
            else
                this.Close();
        }

        private void btn_buy_ticket_Click(object sender, EventArgs e)
        {
            if (!ChooseDateTimeForm.HasAvailableShowtimes(movieID))
            {
                MessageBox.Show("No available showtimes for this movie.", "No Showtimes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dateTimeForm = new ChooseDateTimeForm(movieID))
            {

                if (dateTimeForm.ShowDialog() == DialogResult.OK)
                {
                    // Show seatSelection form
                    int showTimeID = (int)dateTimeForm.Tag_showTimeID; // Get ShowTimeID 
                    int theaterID = (int)dateTimeForm.Tag_theaterID; // Get TheaterID
                    DateTime dateTime = dateTimeForm.Tag_selectDateTime; // Get selected date and time
                    using (var seatSelectionForm = new SeatSelection(movieID, showTimeID, theaterID, dateTime))
                    {
                        seatSelectionForm.ShowDialog();
                    }


                }
            }
        }
    }
 
  
}
