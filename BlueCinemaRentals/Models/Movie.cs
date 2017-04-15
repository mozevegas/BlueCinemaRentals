using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BlueCinemaRentals.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYr { get; set; }
        public string Director { get; set; }
        public int GenreId { get; set; }

        public Movie() { }
        public Movie(SqlDataReader reader)
        {
            this.Id = (int)reader["id"];
            this.Title = reader["Title"].ToString();
            this.ReleaseYr = (int)reader["ReleaseYr"];
            this.Director = reader["Director"].ToString();
            this.GenreId = (int)reader["GenreId"];
        }

        // public Genres GenreType { get; set; }
    }
}