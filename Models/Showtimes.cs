using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public class Showtimes
    {
        public int ShowtimeID { get; set; }
        public int MovieID { get; set; }
        public int TheaterID { get; set; }
        public DateTime StartTime { get; set; } 
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public string Status { get; set; } // e.g., "Scheduled", "Cancelled"
        public Showtimes() { }
        public Showtimes( int movieID, int theaterID,
            DateTime startTime, int totalSeats,
            int availableSeats, string status)
        {
            MovieID = movieID;
            TheaterID = theaterID;
            StartTime = startTime;
            TotalSeats = totalSeats;
            AvailableSeats = availableSeats;
            Status = status;
        }
    }
}
