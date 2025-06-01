using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MovieTicketBookingManagementSystem.Config;
using MovieTicketBookingManagementSystem.Models; // Add this if you use SQL Server

namespace MovieTicketBookingManagementSystem
{
    public partial class SeatSelection : Form
    {
        public event EventHandler RequestClose;
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

        private int RowsCount;
        private int SeatsPerRow;
        private string movieID;
        private int showTimeId;
        private int theaterID;
        private string showTimesText;

        // List to hold selected seats with keys as SeatCode
        private Dictionary<string, Seats> soldSeats = new Dictionary<string, Seats>();
        private Dictionary<string, Seats> selectedSeats = new Dictionary<string, Seats>();
        private int pricingTicket;

        public SeatSelection(string movieID, int showTimeId, int theaterID, DateTime dateTime)
        {
            InitializeComponent();
            this.movieID = movieID;
            this.showTimeId = showTimeId;
            this.theaterID = theaterID;
            this.showTimesText = dateTime.ToString("M/d/yyyy h:mm:ss tt"); // Format the date and time for display

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //Retrieve RowsCount and SeatsPerRow from table
            LoadSeatConfiguration();

            //Render seats 
            RenderSeats();
        }

        private void LoadSeatConfiguration()
        {
            string connectionString = DatabaseConfig.ConnectionString;
            string query = "SELECT RowsCount, SeatsPerRow FROM theaters WHERE TheaterID = @theaterID";
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@theaterID", this.theaterID);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        RowsCount = reader.GetInt32(0);
                        SeatsPerRow = reader.GetInt32(1);
                    }
                }
                conn.Close();
            }

            // Load seats from table tickets 
            string loadSeatsQuery = "SELECT * FROM tickets WHERE ShowtimeID = @showTimeId";
            using (SqlCommand cmd = new SqlCommand(loadSeatsQuery, conn))
            {
                cmd.Parameters.AddWithValue("@showTimeId", this.showTimeId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string seatCode = reader["SeatCode"].ToString();
                        soldSeats.Add(seatCode, new Seats(theaterID, seatCode));
                    }
                }
                conn.Close();

            }

            // Load information movie from table movies
            string loadMovieQuery = "SELECT * FROM movies WHERE MovieID = @movieID";
            using (SqlCommand cmd = new SqlCommand(loadMovieQuery, conn))
            {
                cmd.Parameters.AddWithValue("@movieID", this.movieID);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // If title too long, add tooltip and ellipsis
                        string title = reader["Title"].ToString();
                        if (title.Length > 10)
                        {
                            ToolTip toolTip = new ToolTip();
                            toolTip.SetToolTip(lblMovieName, title);
                            lblMovieName.Text = title.Substring(0, 10) + "..."; // Show first 30 characters with ellipsis
                        }
                        else
                        {
                            lblMovieName.Text = title;
                        }

                        valDuration.Text = reader["Duration"].ToString();
                        valTime.Text = showTimesText;
                        valTicket.Text = "0";
                        valTotal.Text = "";
                        this.pricingTicket = (int)reader["Pricing"]; 
                    }
                }
                conn.Close();

            }


        }

        private void RenderSeats()
        {
            panelSeat.Controls.Clear();
            int buttonSize = 40;
            int padding = 5;

            // Calculate total grid size
            int totalWidth = SeatsPerRow * buttonSize + (SeatsPerRow - 1) * padding;
            int totalHeight = RowsCount * buttonSize + (RowsCount - 1) * padding;

            // Calculate starting point to center the grid
            int startX = (panelSeat.Width - totalWidth) / 2;
            int startY = (panelSeat.Height - totalHeight) / 2;

            for (int row = 0; row < RowsCount; row++)
            {
                for (int col = 0; col < SeatsPerRow; col++)
                {
                    Button seatButton = new Button();
                    seatButton.Name = $"btnSeat_{(char)('A' + row)}_{col}";
                    seatButton.Width = buttonSize;
                    seatButton.Height = buttonSize;
                    seatButton.Left = startX + col * (buttonSize + padding);
                    seatButton.Top = startY + row * (buttonSize + padding);
                    seatButton.Text = $"{(char)('A' + row)}{col + 1}";
                    seatButton.Tag = new Seats(theaterID, ((char)('A' + row)).ToString(), col + 1);
                    if (soldSeats.ContainsKey(seatButton.Text))
                    {
                        seatButton.BackColor = Color.Red; 
                        seatButton.Enabled = false; 
                    }
                    else
                    {
                        seatButton.BackColor = Color.White; // Available seat
                        seatButton.Click += SeatButton_Click;

                    }
                    panelSeat.Controls.Add(seatButton);
                }
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = btn.BackColor == Color.Green ? Color.White : Color.Green; // Toggle selection
            // add to selectedSeats or remove from it
            Seats seat = (Seats)btn.Tag;
            string seatCode = seat.SeatCode;
            if (selectedSeats.ContainsKey(seatCode))
            {
                selectedSeats.Remove(seatCode);
                btn.BackColor = Color.White; 
            }
            else
            {
                selectedSeats[seatCode] = seat;
                btn.BackColor = Color.Green; 
            }
            this.countTicket(); // Update ticket count and total price

        }

        private void countTicket()
        {
            valTicket.Text = selectedSeats.Count.ToString();
            valTotal.Text = $"${selectedSeats.Count * this.pricingTicket}"; // Assuming each ticket costs $10
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void seatSelection_back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buyTicket_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one seat.", "No Seats Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show messageBox confirming the purchase
            StringBuilder sb = new StringBuilder("You have selected the following seats:\n");
            foreach (var seat in selectedSeats.Values)
            {
                sb.AppendLine(seat.SeatCode);
            }
            sb.AppendLine($"Total Tickets: {selectedSeats.Count}");
            sb.AppendLine($"Total Price: ${selectedSeats.Count * this.pricingTicket}");
            DialogResult result = MessageBox.Show(sb.ToString(), "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Show Loading with progress bar for selected seats
                using (var loadingForm = new LoadingForm(selectedSeats.Count))
                {
                    loadingForm.Show();
                    loadingForm.Refresh();

                    string connectionString = DatabaseConfig.ConnectionString;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        foreach (var seat in selectedSeats.Values)
                        {
                            string insertQuery = "INSERT INTO tickets (UserID, ShowtimeID, SeatCode, Price, BookingTime) VALUES (@userID, @showTimeId, @seatCode, @pricing, @time)";
                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@userID", SessionManager.UserID);
                                cmd.Parameters.AddWithValue("@showTimeId", this.showTimeId);
                                cmd.Parameters.AddWithValue("@seatCode", seat.SeatCode);
                                cmd.Parameters.AddWithValue("@pricing", this.pricingTicket);
                                cmd.Parameters.AddWithValue("@time", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }
                            loadingForm.Increment();
                            Application.DoEvents(); // Allow UI to update
                        }
                        conn.Close();
                    }
                    loadingForm.Close();
                }

                MessageBox.Show("Tickets purchased successfully!", "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RequestClose?.Invoke(this, EventArgs.Empty); // Notify parent form to close
                this.Close(); // Close the current form
            }
        }
    }
}
