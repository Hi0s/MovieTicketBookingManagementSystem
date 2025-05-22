using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Resources
{
    public static class PhoneNumberValidation
    {
        public static bool IsValid(string phone)
        {
            string regex = @"^09\d{8}$";
            return Regex.IsMatch(phone, regex, RegexOptions.IgnoreCase);
        }
    }
}
