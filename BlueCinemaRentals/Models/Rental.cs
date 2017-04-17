using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BlueCinemaRentals.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public int MovieId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateDue { get; set; }

        public Rental() { }
        public Rental(SqlDataReader reader)
        {
            this.Id = (int)reader["id"];
            this.ClientId = reader["ClientId"].ToString();
            this.MovieId = (int)reader["MovieId"];
            this.DateOut = (DateTime)reader["DateOut"];
            this.DateDue = (DateTime)reader["DateDue"];
        }

    }
}