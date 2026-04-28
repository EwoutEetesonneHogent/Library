using Library.Domain.Repository;

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
