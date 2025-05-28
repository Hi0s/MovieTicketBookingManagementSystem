using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketBookingManagementSystem.Config;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem.Models
{
    public static class AdminService
    {
        private static readonly string conn = DatabaseConfig.ConnectionString;
        public static bool ShowActiveMovies(DataGridView moviesGridView)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"SELECT movies.Title,showtimes.StartTime, showtimes.TotalSeats, 
                showtimes.AvailableSeats,showtimes.Status as 'Premiere Status',movies.PosterPath
                FROM showtimes 
                INNER JOIN movies ON showtimes.MovieID = movies.MovieID
                WHERE movies.IsActive =1";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    //SqlDataReader showActiveMovies_rd = cmd.ExecuteReader();
                    SqlDataAdapter moviesAdapter= new SqlDataAdapter(cmd);
                    DataTable activeMovies= new DataTable();
                    moviesAdapter.Fill(activeMovies); // Fill the DataTable with the results
                    moviesGridView.DataSource = activeMovies; // Bind the DataTable to the DataGridView
                    connect.Close();
                    return activeMovies.Rows.Count>0; // Returns true if there are active movies
                }
            }
            return false; // Returns false if no active movies found
        }
    }
}
