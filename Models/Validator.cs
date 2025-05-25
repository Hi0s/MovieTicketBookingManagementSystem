using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public static class Validator
    {
        public static bool IsValidEmail(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        public static bool IsValidPhone(string phone)
        {
            string regex = @"^09\d{8}$";
            return Regex.IsMatch(phone, regex, RegexOptions.IgnoreCase);
        }
    }
}
