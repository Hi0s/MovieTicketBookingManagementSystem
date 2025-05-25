using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public static class SessionManager
    {
        public static string Username { get; set; }
        public static string Role { get; set; } // e.g., "Admin", "User", etc.
        public static int UserID { get; set; } // Optional: if you want to store user ID for further operations
        public static bool IsLoggedIn => !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Role);
        public static void ClearSession()
        {
            Username = null;
            Role = null;
            UserID = 0;
        }
    }
}
