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
        public List<Lender> GetAllLenders()
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            using SqlCommand command = new("SELECT * FROM Lenders", connection);
            List<Lender> lenders = [];

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int LendersId = (int)reader["Id"];
                        string name = (string)reader["Name"];

                        Lender lender = new(LendersId, name);
                        lenders.Add(lender);

                    }
                }
            }
            return lenders;
        }

        public void AddLender(Lender lender)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            using SqlCommand command = new("INSERT INTO Lenders (Name) VALUES (@name)", connection);
            command.Parameters.AddWithValue("@name", lender.Name);
            command.ExecuteNonQuery();
        }
    }
}
