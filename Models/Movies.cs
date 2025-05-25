using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBookingManagementSystem.Models
{
    public class Movies
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; } // Duration in minutes
        public string Rating { get; set; } // e.g., "PG-13", "R"
        public DateTime ReleaseDate { get; set; }

        public string PosterImagePath { get; set; }
        public bool IsActive { get; set; } = true; // Default value for IsActive
        public DateTime CreatedAt { get; set; }  // Default value for CreatedAt
        public Movies() { }
        public Movies( string title, string description,
            string genre, int duration, DateTime releaseDate,
            string posterImagePath, DateTime createdAt, bool isActive = true)
        {
            Title = title;
            Description = description;
            Genre = genre;
            Duration = duration;
            ReleaseDate = releaseDate;
            PosterImagePath = posterImagePath;
            IsActive = isActive;
            CreatedAt = createdAt;
        }
    }
}
