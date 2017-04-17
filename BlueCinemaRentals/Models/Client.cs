using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BlueCinemaRentals.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Client() { }
        public Client(SqlDataReader reader)
        {
            this.Id = (int)reader["id"];
            this.ClientName = reader["ClientName"].ToString();
            this.Email = reader["Email"].ToString();
            this.Phone = reader["Phone"].ToString();
        }

    }
}