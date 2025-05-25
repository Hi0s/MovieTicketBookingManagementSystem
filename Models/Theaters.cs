using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public class Theaters
    {
        public int TheaterID { get; set; }
        public string Name { get; set; }
        public int RowsCount { get; set; } // Number of rows in the theater
        public int SeatsPerRow { get; set; } // Number of seats per row
        public int TotalSeats => RowsCount * SeatsPerRow; // Total seats in the theater
        public bool IsActive { get; set; } = true; // Default value for IsActive
        public Theaters() { }
        public Theaters(string name, int rowsCount, int seatsPerRow, bool isActive = true)
        {
            Name = name;
            RowsCount = rowsCount;
            SeatsPerRow = seatsPerRow;
            IsActive = isActive;
        }
    }
}
