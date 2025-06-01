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
    public partial class ChooseDateTimeForm : Form
    {
        public DateTime SelectedDateTime { get; private set; }
        public int Tag_showTimeID { get; private set; }
        public int Tag_theaterID { get; private set; }
        public DateTime Tag_selectDateTime { get; private set; }

        private string movieID;
        public ChooseDateTimeForm(string movieID)
        {
            InitializeComponent();
            this.movieID = movieID;
            this.Load += ChooseDateTimeForm_Load;
        }

    
        private void ChooseDateTimeForm_Load(object sender, EventArgs e)
        {
            loadDateTime(movieID);
        }

        public static bool HasAvailableShowtimes(string movieID)
        {
            string connectionString = DatabaseConfig.ConnectionString;
            string query = "SELECT COUNT(*) FROM showtimes WHERE MovieID = @MovieID AND StartTime >= @Now";
            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MovieID", movieID);
                command.Parameters.AddWithValue("@Now", DateTime.Now.AddHours(-1));
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void loadDateTime(string movieID)
        {
            comboBoxDate.Items.Clear();
            comboBoxTime.Items.Clear();
            HashSet<DateTime> uniqueDates = new HashSet<DateTime>();

            string connectionString = DatabaseConfig.ConnectionString;
            string query = "SELECT DISTINCT CAST(StartTime AS DATE) FROM showtimes WHERE MovieID = @MovieID AND StartTime >= @Now";
            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MovieID", movieID);
                command.Parameters.AddWithValue("@Now", DateTime.Now.AddHours(-1));
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        uniqueDates.Add(date);
                    }
                }
            }

            foreach (var date in uniqueDates.OrderBy(d => d))
            {
                comboBoxDate.Items.Add(date.ToShortDateString());
            }
            comboBoxDate.SelectedIndexChanged += comboBoxDate_SelectedIndexChanged;



        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTime.Items.Clear();
            if (comboBoxDate.SelectedItem == null) return;

            DateTime selectedDate;
            if (!DateTime.TryParse(comboBoxDate.SelectedItem.ToString(), out selectedDate))
                return;

            string connectionString = DatabaseConfig.ConnectionString;
            string query = "SELECT ShowTimeID, StartTime, TheaterID FROM showtimes WHERE MovieID = @MovieID AND CAST(StartTime AS DATE) = @SelectedDate AND StartTime >= @NOW";

            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MovieID", movieID);
                command.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);
                command.Parameters.AddWithValue("@Now", DateTime.Now.AddHours(-1));
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int showTimeID = reader.GetInt32(0);
                        DateTime startTime = reader.GetDateTime(1);
                        int theaterID = reader.GetInt32(2);
                        string displayText = $"{startTime.ToString("hh\\:mm tt")}";
                        comboBoxTime.Items.Add(new ComboBoxItem { Text = displayText, ShowTimeID = showTimeID, TheaterID = theaterID });
                    }
                }
            }
       
        } 



        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int ShowTimeID { get; set; }
            public int TheaterID { get; set; }
            public override string ToString() => Text;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // Example: Get ShowTimeID from selected item in comboBoxTime
            if (comboBoxTime.SelectedItem is ComboBoxItem selectedItem)
            {
                this.Tag_showTimeID = selectedItem.ShowTimeID;
                this.Tag_theaterID = selectedItem.TheaterID;
                this.Tag_selectDateTime = DateTime.Parse($"{comboBoxDate.SelectedItem.ToString()} {selectedItem.Text}");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a showtime.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
