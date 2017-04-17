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
        public string DateOut { get; set; }
        public int DateDue { get; set; }

        public Rental() { }
        public Rental(SqlDataReader reader)
        {
            this.Id = (int)reader["id"];
            this.ClientId = reader["ClientId"].ToString();
            this.MovieId = (int)reader["MovieId"];
            this.DateOut = reader["DateOut"].ToString();
            this.DateDue = (int)reader["DateDue"];
        }

    }
}