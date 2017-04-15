using BlueCinemaRentals.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlueCinemaRentals.Services
{
    public class MovieServices
    {
        const string connectionString = @"Server=localhost\SQLEXPRESS;Database=BlueCinemaDB;Trusted_Connection=True;";

        public List<Movie> GetAllMovies()
        {
            var rv = new List<Movie>();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Movies";
                var cmd = new SqlCommand(query, connection);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rv.Add(new Movie(reader));
                }
                connection.Close();
            }
            return rv;
        }

        public Movie CreateMovie(Movie Movie)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = @"INSERT INTO [dbo].[Movies]
                           ([Title]
                           ,[ReleaseYr]
                           ,[Director]
                           ,[GenreId])                       
                            VALUES ( @Title, @ReleaseYr, @Director, @GenreId)";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Title", Movie.Title);
                cmd.Parameters.AddWithValue("@ReleaseYr", Movie.ReleaseYr);
                cmd.Parameters.AddWithValue("@Director", Movie.Director);
                cmd.Parameters.AddWithValue("@GenreId", Movie.GenreId);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return Movie;
        }

        public static Movie GetMovie(int Id)
        {
            var movie = new List<Movie>();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Movie WHERE Id=@Id";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Id);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movie.Add(new Movie(reader));
                }
                connection.Close();
            }
            return movie[0];
        }

        public Movie EditMovie(Movie Movie)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = @"UPDATE [dbo].[Movies]
                           SET[Title]=@Title
           			       ,[ReleaseYr]=@ReleaseYr
                           ,[Director]=@Director
                           ,[GenreId]=@GenreId
                            WHERE Id=@Id";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Movie.Id);
                cmd.Parameters.AddWithValue("@Title", Movie.Title);
                cmd.Parameters.AddWithValue("@ReleaseYr", Movie.ReleaseYr);
                cmd.Parameters.AddWithValue("@Director", Movie.Director);
                cmd.Parameters.AddWithValue("@GenreId", Movie.GenreId);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return Movie;
        }

        public Movie DeleteMovie(Movie Movie)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = @"DELETE FROM [dbo].[Movie]
                           WHERE Id=@Id";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", Movie.Id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            return Movie;
        }

    }
}