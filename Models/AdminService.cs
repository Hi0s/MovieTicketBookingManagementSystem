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
                string query = @"SELECT movies.MovieID, showtimes.showtimeID ,movies.Title,showtimes.StartTime, showtimes.TotalSeats, 
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
        }
        public static List<Movies> GetActiveMoviesList() {
            List<Movies> moviesList = new List<Movies>();
            using(SqlConnection connect=new SqlConnection(conn))
            {
                string movie_load=@"SELECT * FROM movies WHERE IsActive=1";
                connect.Open();
                SqlCommand movie_cmd=new SqlCommand(movie_load, connect);
                SqlDataReader movie_load_dr = movie_cmd.ExecuteReader();
                while(movie_load_dr.Read())
                {
                    Movies movie = new Movies
                    {
                        MovieID = Convert.ToInt32(movie_load_dr["MovieID"]),
                        Title = movie_load_dr["Title"].ToString(),
                        Genre = movie_load_dr["Genre"].ToString(),
                        Duration = Convert.ToInt32(movie_load_dr["Duration"]),
                        Description = movie_load_dr["Description"].ToString(),
                        Rating = movie_load_dr["Rating"].ToString(),
                        PosterImagePath = movie_load_dr["PosterPath"].ToString(),
                        ReleaseDate = Convert.ToDateTime(movie_load_dr["ReleaseDate"]),
                        CreatedAt = Convert.ToDateTime(movie_load_dr["CreatedAt"]),
                        IsActive = Convert.ToBoolean(movie_load_dr["IsActive"])
                    };
                    moviesList.Add(movie);
                }
                movie_load_dr.Close();
                connect.Close();
            }
            return moviesList;
        }
        public static List<Movies> GetMoviesList()
        {
            List<Movies> moviesList = new List<Movies>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string movie_load = @"SELECT * FROM movies";
                connect.Open();
                SqlCommand movie_cmd = new SqlCommand(movie_load, connect);
                SqlDataReader movie_load_dr = movie_cmd.ExecuteReader();
                while (movie_load_dr.Read())
                {
                    Movies movie = new Movies
                    {
                        MovieID = Convert.ToInt32(movie_load_dr["MovieID"]),
                        Title = movie_load_dr["Title"].ToString(),
                        Genre = movie_load_dr["Genre"].ToString(),
                        Duration = Convert.ToInt32(movie_load_dr["Duration"]),
                        Description = movie_load_dr["Description"].ToString(),
                        Rating = movie_load_dr["Rating"].ToString(),
                        PosterImagePath = movie_load_dr["PosterPath"].ToString(),
                        ReleaseDate = Convert.ToDateTime(movie_load_dr["ReleaseDate"]),
                        CreatedAt = Convert.ToDateTime(movie_load_dr["CreatedAt"]),
                        IsActive = Convert.ToBoolean(movie_load_dr["IsActive"])
                    };
                    moviesList.Add(movie);
                }
                movie_load_dr.Close();
                connect.Close();
            }
            return moviesList;
        }
        public static List<Showtimes> GetActiveShowtimesList()
        {
            List<Showtimes> showtimesList = new List<Showtimes>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string showtime_load = @"SELECT * FROM showtimes WHERE showtimes.Status='Active'";
                connect.Open();
                SqlCommand showtime_cmd = new SqlCommand(showtime_load, connect);
                SqlDataReader showtime_load_dr = showtime_cmd.ExecuteReader();
                while (showtime_load_dr.Read())
                {
                    Showtimes showtime = new Showtimes
                    {
                        ShowtimeID = Convert.ToInt32(showtime_load_dr["ShowtimeID"]),
                        MovieID = Convert.ToInt32(showtime_load_dr["MovieID"]),
                        TheaterID = Convert.ToInt32(showtime_load_dr["TheaterID"]),
                        StartTime = Convert.ToDateTime(showtime_load_dr["StartTime"]),
                        TotalSeats = Convert.ToInt32(showtime_load_dr["TotalSeats"]),
                        AvailableSeats = Convert.ToInt32(showtime_load_dr["AvailableSeats"]),
                        Status = showtime_load_dr["Status"].ToString()
                    };
                    showtimesList.Add(showtime);
                }
                showtime_load_dr.Close();
                connect.Close();
            }
            return showtimesList;
        }
        public static List<Theaters> GetActiveTheatersList()
        {
            List<Theaters> theatersList = new List<Theaters>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string theater_load = @"SELECT * FROM theaters WHERE IsActive=1";
                connect.Open();
                SqlCommand theater_cmd = new SqlCommand(theater_load, connect);
                SqlDataReader theater_load_dr = theater_cmd.ExecuteReader();
                while (theater_load_dr.Read())
                {
                    Theaters theater = new Theaters
                    {
                        TheaterID = Convert.ToInt32(theater_load_dr["TheaterID"]),
                        Name = theater_load_dr["Name"].ToString(),
                        RowsCount= Convert.ToInt32(theater_load_dr["RowsCount"]),
                        SeatsPerRow = Convert.ToInt32(theater_load_dr["SeatsPerRow"]),
                        IsActive = Convert.ToBoolean(theater_load_dr["IsActive"])
                    };
                    theatersList.Add(theater);
                }
                theater_load_dr.Close();
                connect.Close();
            }
            return theatersList;
        }

        public static List<Users> GetUsersList()
        {
            List<Users> usersList = new List<Users>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string user_load = @"SELECT * FROM users WHERE IsActive=1";
                connect.Open();
                SqlCommand user_cmd = new SqlCommand(user_load, connect);
                SqlDataReader user_load_dr = user_cmd.ExecuteReader();
                while (user_load_dr.Read())
                {
                    Users user = new Users
                    {
                        UserID = Convert.ToInt32(user_load_dr["UserID"]),
                        Username = user_load_dr["Username"].ToString(),
                        Password = user_load_dr["Password"].ToString(),
                        Firstname = user_load_dr["Firstname"].ToString(),
                        Lastname = user_load_dr["Lastname"].ToString(),
                        Gender = user_load_dr["Gender"].ToString(),
                        Birthdate = Convert.ToDateTime(user_load_dr["Birthdate"]),
                        Email = user_load_dr["Email"].ToString(),
                        Phone = user_load_dr["Phone"].ToString(),
                        Address = user_load_dr["Address"].ToString(),
                        Role = user_load_dr["Role"].ToString(),
                        CreatedAt = Convert.ToDateTime(user_load_dr["CreatedAt"]),
                        IsActive = Convert.ToBoolean(user_load_dr["IsActive"])
                    };
                    usersList.Add(user);
                }
                user_load_dr.Close();
                connect.Close();
            }
            return usersList;
        }

        public static bool AddMovie(Movies movie)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"INSERT INTO movies(Title, Genre, Duration, Description, Rating, PosterPath, ReleaseDate, CreatedAt)
                                 VALUES(@Title, @Genre, @Duration, @Description, @Rating, @PosterPath, @ReleaseDate, @CreatedAt)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Title", movie.Title);
                    cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                    cmd.Parameters.AddWithValue("@Duration", movie.Duration);
                    cmd.Parameters.AddWithValue("@Description", movie.Description);
                    cmd.Parameters.AddWithValue("@Rating", movie.Rating);
                    cmd.Parameters.AddWithValue("@PosterPath", movie.PosterImagePath);
                    cmd.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                    cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the movie was successfully added
                }
            }
        }
        public static bool UpdateMovie(Movies movie)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"UPDATE movies SET Title = @Title, Genre = @Genre, Duration = @Duration, 
                                 Description = @Description, Rating = @Rating, PosterPath = @PosterPath, 
                                 ReleaseDate = @ReleaseDate,IsActive=@IsActive WHERE MovieID = @MovieID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movie.MovieID);
                    cmd.Parameters.AddWithValue("@Title", movie.Title);
                    cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                    cmd.Parameters.AddWithValue("@Duration", movie.Duration);
                    cmd.Parameters.AddWithValue("@Description", movie.Description);
                    cmd.Parameters.AddWithValue("@Rating", movie.Rating);
                    cmd.Parameters.AddWithValue("@PosterPath", movie.PosterImagePath);
                    cmd.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                    cmd.Parameters.AddWithValue("@IsActive", movie.IsActive);
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the movie was successfully updated
                }
            }
        }


        public static bool AddShowtime(Showtimes showtime)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"INSERT INTO showtimes(MovieID, TheaterID, StartTime, TotalSeats, AvailableSeats, Status)
                                 VALUES(@MovieID, @TheaterID, @StartTime, @TotalSeats, @AvailableSeats, @Status)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@MovieID", showtime.MovieID);
                    cmd.Parameters.AddWithValue("@TheaterID", showtime.TheaterID);
                    cmd.Parameters.AddWithValue("@StartTime", showtime.StartTime);
                    cmd.Parameters.AddWithValue("@TotalSeats", showtime.TotalSeats);
                    cmd.Parameters.AddWithValue("@AvailableSeats", showtime.AvailableSeats);
                    cmd.Parameters.AddWithValue("@Status", showtime.Status);
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the showtime was successfully added
                }
            }
        }
        public static bool DeactivateMovie(int movieId)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = "UPDATE movies SET IsActive = 0 WHERE MovieID = @MovieID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the movie was successfully deactivated
                }
            }
        }

        public static bool DeactivateShowtime(int showtimeId)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = "UPDATE showtimes SET Status = 'Inactive' WHERE ShowtimeID = @ShowtimeID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the showtime was successfully deactivated
                }
            }
        }

    }
}
