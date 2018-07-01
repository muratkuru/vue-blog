using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Blog.Models
{
    public class BlogContext
    {
        private readonly string connectionString;

        public BlogContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BlogDb"].ConnectionString;
            if (string.IsNullOrEmpty(connectionString)) throw new Exception("Connection string does not found.");
        }

        public ICollection<Post> GetAllPosts(int pageIndex = 0, int postPerPage = 10)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Posts";
                var command = new SqlCommand(query, connection);
                var posts = new List<Post>();

                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        posts.Add(new Post
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader["Title"].ToString(),
                            Url = reader["Url"].ToString(),
                            Content = reader["Content"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"])
                        });
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    Debug.Write(ex.Message);
                }
                finally
                {
                    command.Dispose();
                    connection.Dispose();
                }

                return posts;
            }
        }
    }
}