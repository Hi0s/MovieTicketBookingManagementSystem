using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Config
{
    public static class DatabaseConfig
    {
        public static readonly string ConnectionString=
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MovieTicketBookingManagementSystem\dbo\movie.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
