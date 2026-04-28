using Library.Domain.Models;
using Library.Domain.Repository;

namespace Library.Domain
{
    public class DomainManager
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILendingRepository _lendingRepository;
        private readonly IAuthorRepository _authorRepository;

        public DomainManager(IBookRepository bookRepository, ILendingRepository lendingRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _lendingRepository = lendingRepository;
            _authorRepository = authorRepository;
        }

        public void CreateAuthor(string name) {
            _authorRepository.CreateAuthor(name);
        }

        public void CreateBook(string name, DateOnly publishDate, Author author) {
            _bookRepository.CreateBook(name, publishDate, author);
        }
    }
}
