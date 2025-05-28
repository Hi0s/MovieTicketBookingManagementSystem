using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int UserID { get; set; }
        public int ShowtimeID { get; set; }
        public string SeatCode { get; set; }
        public decimal Price { get; set; }
        public DateTime BookingTime { get; set; }
        public string Status { get; set; }
        public DateTime? CancelledTime { get; set; }

        public Ticket() { }

        public Ticket(int userID, int showtimeID, string seatCode, decimal price,
                      DateTime bookingTime, string status, DateTime? cancelledTime = null)
        {
            UserID = userID;
            ShowtimeID = showtimeID;
            SeatCode = seatCode;
            Price = price;
            BookingTime = bookingTime;
            Status = status;
            CancelledTime = cancelledTime;
        }
    }
}

