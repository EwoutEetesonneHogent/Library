using Library.Domain.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Persistence {
    public class AuthorRepository : IAuthorRepository {
        private readonly string _connectionString;

        public AuthorRepository(string connenctionString) {
            _connectionString = connenctionString;
        }

        public void CreateAuthor(string name) {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new("INSERT INTO Author (Name) Values (@name);", connection);
            command.Parameters.AddWithValue("@name", name);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
