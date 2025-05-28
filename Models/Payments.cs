using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public class Payments
    {
        public int PaymentID { get; set; }
        public int TicketID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Method { get; set; } // e.g., "Credit Card", "PayPal", etc.
        public string Status { get; set; } // e.g., "Completed", "Pending", "Failed"
        public Payments() { }
        public Payments(int ticketId, decimal amount, DateTime paymentDate,
            string method, string status)
        {
            TicketID = ticketId;
            Amount = amount;
            PaymentDate = paymentDate;
            Method = method;
            Status = status;
        }
    }
}
