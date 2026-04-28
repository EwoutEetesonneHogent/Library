using Library.Domain.Models;

namespace Library.Domain.Repository
{
    public interface IBookRepository
    {
        List<Book> LendExistingBooks(Book book, Lender lender);
    }
}
