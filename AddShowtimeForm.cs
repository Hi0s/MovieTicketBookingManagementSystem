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
        Point lastPoint;
        public event EventHandler RequestClose;

        private readonly string connString = DatabaseConfig.ConnectionString;
        private DateTime start;
        private DateTime end;
        private List<string> dailyTimes = new List<string>
        {
            "09:00 AM", "12:00 PM", "03:00 PM", "06:00 PM", "09:00 PM", "00:00 AM"
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

        }

        private void Add_Showtime_Load(object sender, EventArgs e)
        {

            
            movies = AdminService.GetActiveMoviesList(); // Load movies from the database
            theaters = AdminService.GetActiveTheatersList(); // Load theaters from the database
            showtimes = AdminService.GetActiveShowtimesList(); // Load showtimes from the database


            // Load movies and theaters into the combo boxes

            addshowtime_movie_cb.DisplayMember = "Title";
            addshowtime_movie_cb.ValueMember = "MovieID";
            addshowtime_movie_cb.DataSource = movies;

            addshowtime_theater_cb.DisplayMember = "Name";
            addshowtime_theater_cb.ValueMember = "TheaterID";
            addshowtime_theater_cb.DataSource = theaters;

        }

        private void addshowtime_btn_Click(object sender, EventArgs e)
        {
            // Use Chinese culture info
            var chineseCulture = new System.Globalization.CultureInfo("zh-CN");
            if (addshowtime_movie_cb.SelectedValue == null || addshowtime_theater_cb.SelectedValue == null || addshowtime_dailytime_lb.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a movie, theater, and showtime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Code to add showtime to database
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "INSERT INTO showtimes (MovieID, TheaterID, StartTime, TotalSeats, AvailableSeats) " +
                        "VALUES (@MovieID, @TheaterID, @StartTime, @TotalSeats, @AvailableSeats)";
                    foreach (string timeString in addshowtime_dailytime_lb.SelectedItems)
                    {
                        // Convert the timeString (e.g., "6/10/2024 10:00:00 AM") to DateTime
                        DateTime fullStartTime;

                        if (!DateTime.TryParseExact(timeString, "M/d/yyyy h:mm:ss tt", chineseCulture, System.Globalization.DateTimeStyles.None, out fullStartTime))
                        {
                            MessageBox.Show($"Invalid time format: {timeString}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                        var selectedTheater = addshowtime_theater_cb.SelectedItem as Theaters;
                        int totalSeats = (selectedTheater != null && selectedTheater.TotalSeats > 0)
                            ? selectedTheater.TotalSeats
                            : (selectedTheater != null ? selectedTheater.RowsCount * selectedTheater.SeatsPerRow : 0);

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MovieID", addshowtime_movie_cb.SelectedValue);
                            cmd.Parameters.AddWithValue("@TheaterID", addshowtime_theater_cb.SelectedValue);
                            cmd.Parameters.AddWithValue("@StartTime", fullStartTime);
                            cmd.Parameters.AddWithValue("@TotalSeats", totalSeats);
                            cmd.Parameters.AddWithValue("@AvailableSeats", totalSeats);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    MessageBox.Show("Showtime added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                ClearForm(); // Clear the form after successful addition
            }
        }

        private void addmovie_return_btn_Click(object sender, EventArgs e)
        {
            // If embedded, raise event; if standalone, close as usual
            if (RequestClose != null)
                RequestClose(this, EventArgs.Empty);
            else
                this.Close();
                
        }
        private void addshowtime_startdate_datepicker_ValueChanged(object sender, EventArgs e)
        {
            if (addshowtime_enddate_datepicker.Value < addshowtime_startdate_datepicker.Value)
            {
                addshowtime_enddate_datepicker.Value = addshowtime_startdate_datepicker.Value;
            }

            addshowtime_enddate_datepicker.MinDate = addshowtime_startdate_datepicker.Value; // Set the minimum date for end date picker to start date

            // Trigger enddate change
            addshowtime_enddate_datepicker_ValueChanged(sender, EventArgs.Empty);
         
        }


        private void addshowtime_enddate_datepicker_ValueChanged(object sender, EventArgs e)
        {
            // Focus on the first empty required field
            if (addshowtime_movie_cb.SelectedValue == null || addshowtime_movie_cb.SelectedIndex == -1)
            {
                addshowtime_movie_cb.Focus();
                addshowtime_dailytime_lb.DataSource = null;
                return;
            }
            if (addshowtime_theater_cb.SelectedValue == null || addshowtime_movie_cb.SelectedIndex == -1)
            {
                addshowtime_theater_cb.Focus();
                addshowtime_dailytime_lb.DataSource = null;
                return;
            }
            if (addshowtime_startdate_datepicker.Value == null)
            {
                addshowtime_startdate_datepicker.Focus();
                addshowtime_dailytime_lb.DataSource = null;
                return;
            }

            // Build availableTimes as a list of all date+time combinations in the selected range
            List<string> availableTimes = new List<string>();
            DateTime startDate = addshowtime_startdate_datepicker.Value.Date;
            DateTime endDate = addshowtime_enddate_datepicker.Value.Date;

            foreach (DateTime day in EachDay(startDate, endDate))
            {
                foreach (string timeString in dailyTimes)
                {
                    if (DateTime.TryParseExact(timeString, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var parsedTime))
                    {
                        DateTime fullDateTime = new DateTime(day.Year, day.Month, day.Day, parsedTime.Hour, parsedTime.Minute, 0);
                        string formatted = fullDateTime.ToString("M/d/yyyy h:mm:ss tt");
                        // Replace AM/PM with Chinese equivalents
                        formatted = formatted.Replace("AM", "上午").Replace("PM", "下午");
                        availableTimes.Add(formatted);
                    }
                }
            }

            // Remove times that already exist as showtimes for the selected theater
            if (addshowtime_theater_cb.SelectedValue != null)
            {
                MessageBox.Show("OK");
                int selectedTheaterId = (int)addshowtime_theater_cb.SelectedValue;
                foreach (var showtime in showtimes)
                {
                    MessageBox.Show("OK2");
                    if (showtime.TheaterID == selectedTheaterId)
                    {
                        string showtimeString = showtime.StartTime.ToString("M/d/yyyy h:mm:ss tt").Replace("AM", "上午").Replace("PM", "下午");
                        MessageBox.Show(showtimeString);
                        // Fix for CS1002 and CS1503 errors
                        // Replace the problematic line:

                        // With the corrected line:
                        MessageBox.Show(string.Join(", ", availableTimes));
                        availableTimes.Remove(showtimeString);
                    }
                }
            }

            // Update the list box with the filtered times
            addshowtime_dailytime_lb.DataSource = null;
            addshowtime_dailytime_lb.DataSource = availableTimes;
        }
        private void addshowtime_theater_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addshowtime_theater_cb.SelectedItem is Theaters selectedTheater)
            {
                // Calculate TotalSeats if not set
                int totalSeats = selectedTheater.TotalSeats > 0
                    ? selectedTheater.TotalSeats
                    : selectedTheater.RowsCount * selectedTheater.SeatsPerRow;

                addshowtime_totalseats_lbl.Text = "Total Seats:    " + totalSeats;
            }
            else
            {
                addshowtime_totalseats_lbl.Text = "Total Seats:    0";
             
            }
            addshowtime_enddate_datepicker_ValueChanged(sender, EventArgs.Empty);

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
            addshowtime_enddate_datepicker_ValueChanged(sender, EventArgs.Empty);

        }

        private void AddShowtimeForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AddShowtimeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.ParentForm != null)
            {
                this.ParentForm.Left += e.X - lastPoint.X;
                this.ParentForm.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
