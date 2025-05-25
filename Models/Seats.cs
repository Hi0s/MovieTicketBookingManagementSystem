using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public class Seats
    {
        public int SeatID { get; set; }
        public int TheaterId { get; set; }
        public string RowLabel { get; set; }
        public int SeatNumber { get; set; }
        public string SeatCode => $"{RowLabel}{SeatNumber}"; // Generates a seat code like "A01", "B02", etc.
        public Seats() { }
        public Seats(int theaterId, string rowLabel, int seatNumber)
        {
            TheaterId = theaterId;
            RowLabel = rowLabel;
            SeatNumber = seatNumber;

        }
    }
}
