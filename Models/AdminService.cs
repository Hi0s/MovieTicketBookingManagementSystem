using MovieTicketBookingManagementSystem.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketBookingManagementSystem.Models
{
    public static class AdminService
    {
        private static readonly string conn = DatabaseConfig.ConnectionString;
        public static bool ShowActiveMovies(DataGridView moviesGridView)
        {
            UpdatePremieredShowtimes();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"SELECT movies.MovieID, showtimes.ShowtimeID,showtimes.TheaterID ,movies.Title,showtimes.StartTime, showtimes.TotalSeats, 
                showtimes.AvailableSeats,showtimes.Status as 'Premiere Status',movies.PosterPath
                FROM showtimes 
                INNER JOIN movies ON showtimes.MovieID = movies.MovieID
                WHERE showtimes.Status='Scheduled' OR showtimes.Status='Premiered'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    //SqlDataReader showActiveMovies_rd = cmd.ExecuteReader();
                    SqlDataAdapter moviesAdapter= new SqlDataAdapter(cmd);
                    DataTable activeMovies= new DataTable();
                    moviesAdapter.Fill(activeMovies); // Fill the DataTable with the results
                    moviesGridView.DataSource = activeMovies; // Bind the DataTable to the DataGridView
                    connect.Close();

                    moviesGridView.Columns["StartTime"].DefaultCellStyle.Format = "yyyy/M/d hh:mm:ss tt";
                    //moviesGridView.Columns["StartTime"].DefaultCellStyle.FormatProvider = new CultureInfo("zh-CN");

                    return activeMovies.Rows.Count>0; // Returns true if there are active movies
                }
            }
        }
        public static bool ShowInactiveMovies(DataGridView moviesGridView)
        {
            UpdatePremieredShowtimes();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"SELECT movies.MovieID, showtimes.ShowtimeID,showtimes.TheaterID ,movies.Title,showtimes.StartTime, showtimes.TotalSeats, 
                showtimes.AvailableSeats,showtimes.Status as 'Premiere Status',movies.PosterPath
                FROM showtimes 
                INNER JOIN movies ON showtimes.MovieID = movies.MovieID
                WHERE showtimes.Status='Cancelled'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    //SqlDataReader showActiveMovies_rd = cmd.ExecuteReader();
                    SqlDataAdapter moviesAdapter = new SqlDataAdapter(cmd);
                    DataTable inactiveMovies = new DataTable();
                    moviesAdapter.Fill(inactiveMovies); // Fill the DataTable with the results
                    moviesGridView.DataSource = inactiveMovies; // Bind the DataTable to the DataGridView
                    connect.Close();
                    return inactiveMovies.Rows.Count > 0; // Returns true if there are active movies
                }
            }
        }
        public static bool ShowUsers(DataGridView usersGridView)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"SELECT UserID, Username, Firstname,Lastname,Gender,Birthdate,Email,Phone,Address,Role,CreatedAt,IsActive FROM users";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    //SqlDataReader showActiveMovies_rd = cmd.ExecuteReader();
                    SqlDataAdapter moviesAdapter = new SqlDataAdapter(cmd);
                    DataTable inactiveMovies = new DataTable();
                    moviesAdapter.Fill(inactiveMovies); // Fill the DataTable with the results
                    usersGridView.DataSource = inactiveMovies; // Bind the DataTable to the DataGridView
                    connect.Close();
                    return inactiveMovies.Rows.Count > 0; // Returns true if there are active movies
                }
            }
            }
        public static Users ShowUsers(int userID)
        {
            Users user = new Users();
            user.UserID = userID;
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"SELECT UserID, Username, Firstname,Lastname,Gender,Birthdate,Email,Phone,Address,Role,CreatedAt,IsActive FROM users WHERE UserID=@userID";
                
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader user_load_dr = cmd.ExecuteReader();
                    if (user_load_dr.Read())
                    {
                        user.Username = user_load_dr["Username"].ToString();
                        user.Firstname = user_load_dr["Firstname"].ToString();
                        user.Lastname = user_load_dr["Lastname"].ToString();
                        user.Email = user_load_dr["Email"].ToString();
                        user.Gender = user_load_dr["Gender"].ToString();
                        user.Birthdate = Convert.ToDateTime(user_load_dr["Birthdate"]);
                        user.Phone = user_load_dr["Phone"].ToString();
                        user.Address = user_load_dr["Address"].ToString();
                        user.Role = user_load_dr["Role"].ToString();
                        user.CreatedAt = Convert.ToDateTime(user_load_dr["CreatedAt"]);
                        user.IsActive = Convert.ToBoolean(user_load_dr["IsActive"]);
                    }
                    connect.Close();
                }
            }
            return user;
        }
        public static int MoviesCount()
        {
            int count = 0;
            using(SqlConnection connect = new SqlConnection(conn))
            {
                string query = "SELECT COUNT(*) FROM movies WHERE IsActive=1";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    count = (int)cmd.ExecuteScalar(); // Execute the query and get the count
                    connect.Close();
                }
            }
            return count;
        }
        public static int UsersCount()
        {
            int count = 0;
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = "SELECT COUNT(*) FROM users WHERE IsActive=1";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    count = (int)cmd.ExecuteScalar(); // Execute the query and get the count
                    connect.Close();
                }
            }
            return count;
        }
        public static int TicketsCount()
        {
            int count = 0;
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = "SELECT COUNT(*) FROM tickets WHERE Status='Reserved'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    count = (int)cmd.ExecuteScalar(); // Execute the query and get the count
                    connect.Close();
                }
            }
            return count;
        }

        
        public static int RevenueCalc()
        {
            int  sum = 0;
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = "SELECT Price FROM tickets WHERE Status='Reserved'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    SqlDataReader ticket_price_rd = cmd.ExecuteReader();
                    while (ticket_price_rd.Read())
                    {
                        sum += Convert.ToInt32(ticket_price_rd["Price"]);
                    }
                    connect.Close();
                }
            }
            return sum;
        }

        public static bool ShowTopMovies(DataGridView topMoviesGridView) 
        {
            string query = @"SELECT movies.Title, SUM(tickets.Price) AS 'Total Revenue' 
                                FROM tickets
                                INNER JOIN showtimes ON tickets.ShowtimeID = showtimes.ShowtimeID
                                INNER JOIN movies ON showtimes.MovieID = movies.MovieID
                                WHERE tickets.Status = 'Reserved' AND movies.IsActive = 1
                                GROUP BY movies.Title
                                ORDER BY 'Total Revenue' DESC";
            using (SqlConnection connect = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    SqlDataAdapter topMoviesAdapter = new SqlDataAdapter(cmd);
                    DataTable topMoviesTable = new DataTable();
                    topMoviesAdapter.Fill(topMoviesTable); // Fill the DataTable with the results
                    topMoviesGridView.DataSource = topMoviesTable; // Bind the DataTable to the DataGridView
                    connect.Close();
                    return topMoviesTable.Rows.Count > 0; // Returns true if there are active movies
                }
            }
        }

        public static bool ShowRecentBookings(DataGridView recentBookingGridView)
        {
            string query = @"SELECT TOP 10 movies.Title,tickets.BookingTime As 'Booking Date'
                            FROM tickets
                            INNER JOIN showtimes ON tickets.ShowtimeID = showtimes.ShowtimeID
                            INNER JOIN movies ON showtimes.MovieID = movies.MovieID
                            WHERE tickets.Status = 'Reserved' AND movies.IsActive = 1
                            ORDER BY tickets.BookingTime DESC;";
            using (SqlConnection connect = new SqlConnection(conn))
            {
                using (SqlCommand cmd= new SqlCommand(query, connect))
                {
                    connect.Open();
                    SqlDataAdapter recentBookingAdapter = new SqlDataAdapter(cmd);
                    DataTable recentBookingTable = new DataTable();
                    recentBookingAdapter.Fill(recentBookingTable); // Fill the DataTable with the results
                    recentBookingGridView.DataSource = recentBookingTable;
                    connect.Close();
                    return recentBookingTable.Rows.Count > 0;
                }
            }
        }
        public static bool ShowTickets(DataGridView ticketsGridView)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"SELECT tickets.TicketID, tickets.UserID, users.Username, tickets.ShowtimeID, showtimes.StartTime, 
                                 tickets.SeatCode, tickets.Price,tickets.BookingTime, tickets.Status
                                 FROM tickets 
                                 INNER JOIN users ON tickets.UserID = users.UserID
                                 INNER JOIN showtimes ON tickets.ShowtimeID = showtimes.ShowtimeID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    connect.Open();
                    //SqlDataReader showActiveMovies_rd = cmd.ExecuteReader();
                    SqlDataAdapter ticketsAdapter = new SqlDataAdapter(cmd);
                    DataTable ticketsTable = new DataTable();
                    ticketsAdapter.Fill(ticketsTable); // Fill the DataTable with the results
                    ticketsGridView.DataSource = ticketsTable; // Bind the DataTable to the DataGridView
                    connect.Close();
                    ticketsGridView.Columns["StartTime"].DefaultCellStyle.Format = "yyyy/M/d hh:mm:ss tt";
                    //ticketsGridView.Columns["StartTime"].DefaultCellStyle.FormatProvider = new CultureInfo("zh-CN");
                    ticketsGridView.Columns["BookingTime"].DefaultCellStyle.Format = "yyyy/M/d hh:mm:ss tt";
                    //ticketsGridView.Columns["StartTime"].DefaultCellStyle.FormatProvider = new CultureInfo("zh-CN");

                    return ticketsTable.Rows.Count > 0; // Returns true if there are active movies
                }
            }
        }
        public static bool UpdateUser(Users user)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"UPDATE users SET Username = @Username, Firstname = @Firstname, Lastname = @Lastname,
                                Gender=@Gender, Birthdate=@Birthdate, Email=@Email,Phone=@Phone,Address=@Address,
                                Role=@Role,IsActive=@IsActive FROM users WHERE UserID=@UserID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Firstname", user.Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", user.Lastname);
                    cmd.Parameters.AddWithValue("@Gender", user.Gender);
                    cmd.Parameters.AddWithValue("@Birthdate", user.Birthdate);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the movie was successfully updated
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
                        Pricing = Convert.ToInt32(movie_load_dr["Pricing"]),
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
                        Pricing=Convert.ToInt32(movie_load_dr["Pricing"]),
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
                string showtime_load = @"SELECT * FROM showtimes WHERE showtimes.Status='Scheduled'";
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

        public static bool AddMovie(Movies movie)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"INSERT INTO movies(Title, Genre, Duration, Description,  Rating, Pricing, PosterPath, ReleaseDate, CreatedAt)
                                 VALUES(@Title, @Genre, @Duration, @Description, @Rating,@Pricing, @PosterPath, @ReleaseDate, @CreatedAt)";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Title", movie.Title);
                    cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                    cmd.Parameters.AddWithValue("@Duration", movie.Duration);
                    cmd.Parameters.AddWithValue("@Description", movie.Description);
                    cmd.Parameters.AddWithValue("@Rating", movie.Rating);
                    cmd.Parameters.AddWithValue("@Pricing", movie.Pricing);
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
                                 Description = @Description, Rating = @Rating,Pricing=@Pricing, PosterPath = @PosterPath, 
                                 ReleaseDate = @ReleaseDate,IsActive=@IsActive WHERE MovieID = @MovieID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movie.MovieID);
                    cmd.Parameters.AddWithValue("@Title", movie.Title);
                    cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                    cmd.Parameters.AddWithValue("@Duration", movie.Duration);
                    cmd.Parameters.AddWithValue("@Description", movie.Description);
                    cmd.Parameters.AddWithValue("@Pricing", movie.Pricing);
                    cmd.Parameters.AddWithValue("@Rating", movie.Rating);
                    cmd.Parameters.AddWithValue("@PosterPath", movie.PosterImagePath);
                    cmd.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                    cmd.Parameters.AddWithValue("@IsActive", movie.IsActive);
                    connect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (!movie.IsActive) { // If the movie is being deactivated, also deactivate all associated showtimes
                        DeactivateMovie(movie.MovieID);
                    }
                    connect.Close();
                    return rowsAffected > 0; // Returns true if the movie was successfully updated
                }
            }
        }



        //Deactivating a movie means cancelling all its showtimes
        public static bool DeactivateMovie(int movieId)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = "UPDATE showtimes SET Status = 'Cancelled' WHERE MovieID = @MovieID AND NOT Status= 'Premiered'";
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

        public static bool CancelShowtime(int showtimeId)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = "UPDATE showtimes SET Status = 'Cancelled' WHERE ShowtimeID = @ShowtimeID";
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


        public static void UpdatePremieredShowtimes()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                string query = @"UPDATE showtimes
                                 SET Status = 'Premiered'
                                 WHERE Status = 'Scheduled' AND StartTime <= @Now";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Now", DateTime.Now);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
            }
        }
    }
}
