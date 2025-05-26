using MovieTicketBookingManagementSystem.Config;
using MovieTicketBookingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem
{
    public partial class AddShowtimeForm : Form
    {
        private readonly string connString = DatabaseConfig.ConnectionString;
        private DateTime start;
        private DateTime end;
        private List<string> dailyTimes = new List<string>
        {
            "10:00 AM", "12:00 PM", "02:00 PM", "04:00 PM", "06:00 PM", "08:00 PM"
        };
        private List<Movies> movies = new List<Movies>();
        private List<Theaters> theaters = new List<Theaters>();
        private List<Showtimes> showtimes = new List<Showtimes>();
        public AddShowtimeForm()
        {
            InitializeComponent();
            start = DateTime.Now;
            end = start.AddDays(1);
            addshowtime_startdate_datepicker.Value = start;
            addshowtime_startdate_datepicker.MinDate = DateTime.Now;
            addshowtime_enddate_datepicker.Value = end;
            addshowtime_startdate_datepicker.MinDate = DateTime.Now;
            addshowtime_dailytime_lb.DataSource = dailyTimes;

        }

        private void Add_Showtime_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Load movies and theaters into the combo boxes
                conn.Open();
                string movie_load = "SELECT MovieID, Title FROM movies";
                string theater_load = "SELECT TheaterID, Name, RowsCount,SeatsPerRow  FROM theaters";
                string showtimes_load = "SELECT TheaterID, StartTime, Status FROM showtimes";
                SqlCommand movie_cmd = new SqlCommand(movie_load, conn);
                SqlCommand theater_cmd = new SqlCommand(theater_load, conn);
                SqlCommand showtimes_cmd = new SqlCommand(showtimes_load, conn);

                SqlDataReader movie_dr = movie_cmd.ExecuteReader();
                while (movie_dr.Read())
                {
                    movies.Add(new Movies{ 
                        Title = movie_dr["Title"].ToString(),
                        MovieID = Convert.ToInt32(movie_dr["MovieID"]) 
                    });
                }
                movie_dr.Close(); // Close the reader before executing another command

                SqlDataReader theater_dr = theater_cmd.ExecuteReader();
                while (theater_dr.Read())
                {
                    theaters.Add(new Theaters{
                        Name = theater_dr["Name"].ToString(),
                        TheaterID = Convert.ToInt32(theater_dr["TheaterID"]),
                        RowsCount = Convert.ToInt32(theater_dr["RowsCount"]),
                        SeatsPerRow=Convert.ToInt32(theater_dr["SeatsPerRow"])
                    });
                }
                theater_dr.Close();

                SqlDataReader showtimes_dr= showtimes_cmd.ExecuteReader();
                while (showtimes_dr.Read())
                {
                    showtimes.Add(new Showtimes{
                        TheaterID = Convert.ToInt32(showtimes_dr["TheaterID"]),
                        StartTime = showtimes_dr.GetDateTime(showtimes_dr.GetOrdinal("StartTime")),
                        Status = showtimes_dr.ToString()
                    });
                }

                conn.Close();
            }
            addshowtime_movie_cb.DisplayMember = "Title";
            addshowtime_movie_cb.ValueMember = "MovieID";
            addshowtime_movie_cb.DataSource = movies;

            addshowtime_theater_cb.DisplayMember = "Name";
            addshowtime_theater_cb.ValueMember = "TheaterID";
            addshowtime_theater_cb.DataSource = theaters;

        }

        private void addshowtime_btn_Click(object sender, EventArgs e)
        {
            if (addshowtime_movie_cb.SelectedValue == null || addshowtime_theater_cb.SelectedValue == null || addshowtime_dailytime_lb.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a movie, theater, and showtime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Code to add showtime to database
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    string query = "INSERT INTO showtimes (MovieID, TheaterID,StartTime,TotalSeats,AvailableSeats) " +
                        "VALUES (@MovieID, @TheaterID,@StartTime,@TotalSeats,@AvailableSeats)";
                    foreach (DateTime day in EachDay(addshowtime_startdate_datepicker.Value
                        , addshowtime_enddate_datepicker.Value)) {
                        foreach (string timeString in addshowtime_dailytime_lb.SelectedItems)
                        {

                            if (TimeSpan.TryParse(timeString, out var time )==false) {
                                MessageBox.Show($"Invalid time format: {timeString}");
                            }
                            //else if(){

                            //}
                            else
                            {
                                DateTime fullStartTime = day.Add(time);
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@MovieID", addshowtime_movie_cb.SelectedValue);
                                    cmd.Parameters.AddWithValue("@TheaterID", addshowtime_theater_cb.SelectedValue);
                                    cmd.Parameters.AddWithValue("@StartTime", fullStartTime);
                                    cmd.Parameters.AddWithValue("@TotalSeats",
                                        (dynamic)addshowtime_theater_cb.SelectedItem).TotalSeats.ToString();
                                    cmd.Parameters.AddWithValue("@AvailableSeats",
                                        (dynamic)addshowtime_theater_cb.SelectedItem).TotalSeats.ToString();
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                }
                            }

                        } 
                    }
                    conn.Close();
                }
                MessageBox.Show("Showtime added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Clear the form after successful addition
            }
        }

        private void addmovie_return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addshowtime_startdate_datepicker_ValueChanged(object sender, EventArgs e)
        {
            if (addshowtime_enddate_datepicker.Value < addshowtime_startdate_datepicker.Value)
            {
                addshowtime_enddate_datepicker.Value = addshowtime_startdate_datepicker.Value;
            }

            addshowtime_enddate_datepicker.MinDate = addshowtime_startdate_datepicker.Value; // Set the minimum date for end date picker to start date
        }

        private void addshowtime_enddate_datepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addshowtime_theater_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            addshowtime_totalseats_lbl.Text = "Total Seats:    " +
                ((dynamic)addshowtime_theater_cb.SelectedItem).TotalSeats.ToString();

            addshowtime_dailytime_lb.Items.Clear(); // Clear the list box before adding new items

            foreach (var showtime in showtimes)
            {
                if (showtime.TheaterID.ToString() == addshowtime_theater_cb.SelectedValue.ToString())
                {
                    DateTime startTime = showtime.StartTime;
                    string TimeString = startTime.ToString("hh:mm tt"); // Format the time as "hh:mm AM/PM"
                }
            }
        }

        private void addshowtime_dailytime_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ClearForm()
        {
            addshowtime_movie_cb.SelectedIndex = -1;
            addshowtime_theater_cb.SelectedIndex = -1;
            addshowtime_dailytime_lb.ClearSelected();
            addshowtime_startdate_datepicker.Value = DateTime.Now;
            addshowtime_enddate_datepicker.Value = DateTime.Now.AddDays(1);
            addshowtime_totalseats_lbl.Text = "Total Seats:    0";
        }
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from; day <= thru; day = day.AddDays(1))
            {
                yield return day;
            }
        }

        private void addshowtime_movie_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
