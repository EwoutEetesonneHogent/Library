namespace Library.Domain.Repository
{
    public interface IBookRepository
    {
        public List<Book> GetBooksByAuthor(Author author);
    }
}
