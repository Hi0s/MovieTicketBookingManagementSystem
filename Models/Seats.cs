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

        public Seats(int theaterID, string SeatCode)         
        {
            TheaterId = theaterID;
            RowLabel = SeatCode.Substring(0, 1); // Extracts the row label (e.g., "A" from "A01")
            SeatNumber = int.Parse(SeatCode.Substring(1)); // Extracts the seat number (e.g., "01" from "A01")
        }
    }
}
