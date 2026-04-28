using Library.Domain.Models;

namespace Library.Domain.Repository
{
    public interface IBookRepository
    {
        List<Book> GetBooksByAuthor(Author author);
    }
}
