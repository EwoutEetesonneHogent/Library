using Library.Domain.Models;
using Library.Domain.Repository;
using Microsoft.Data.SqlClient;

namespace Library.Persistence
{
    public class LendingRepository : ILendingRepository
    {
        private readonly string _connectionString;

        public LendingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Lenders> GetAllLenders()
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            using SqlCommand command = new("SELECT * FROM Lenders", connection);
            List<Lenders> lenders = [];

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int LendersId = (int)reader["Id"];
                        string name = (string)reader["Name"];

                        Lenders lender = new(LendersId, name);
                        lenders.Add(lender);

                    }
                }
            }
            return lenders;
        }

        public void AddLender(Lenders lender)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            using SqlCommand command = new("INSERT INTO Lenders (Name) VALUES (@name)", connection);
            command.Parameters.AddWithValue("@name", lender.Name);
            command.ExecuteNonQuery();
        }
    }
}
