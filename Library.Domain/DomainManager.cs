using Library.Domain.Models;
using Library.Domain.Repository;
using Microsoft.Data.SqlClient;

namespace Library.Domain
{
    public class DomainManager
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILendingRepository _lendingRepository;

        public DomainManager(IBookRepository bookRepository, ILendingRepository lendingRepository)
        {
            _bookRepository = bookRepository;
            _lendingRepository = lendingRepository;
        }

        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        
        }




    }
}
