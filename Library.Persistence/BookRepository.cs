using Library.Domain.Repository;

namespace Library.Persistence
{
    public class BookRepository : IBookRepository
	{
        private readonly string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
