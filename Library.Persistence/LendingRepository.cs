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
    }
}
