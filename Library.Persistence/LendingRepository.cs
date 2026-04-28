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

        public bool ExtendLendingDueDate(int lendingId)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("UPDATE Lendings SET ReturnDate = DATEADD(dat, 14, ReturnDate) WHERE Id = @LendingId", connection);
        }
    }
}
