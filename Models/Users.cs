using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Role { get; set; } // e.g., "Admin", "User"
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Default value for CreatedAt
        public bool IsActive { get; set; } = true; // Default value for IsActive
        public Users() { }
        public Users( string username, string password,
            string firstname, string lastname, string gender,
            DateTime birthdate, string email, string phone,
            string address, string role, DateTime createdAt, bool isActive)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Gender = gender;
            Birthdate = birthdate;
            Email = email;
            Phone = phone;
            Address = address;
            Role = role;
            CreatedAt = createdAt;
            IsActive = isActive;
        }
    }
}
