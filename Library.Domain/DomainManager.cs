using Library.Domain.Model;
using Library.Domain.Repository;

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
        public List<Lenders> GetAllLenders()
        {
            return _lendingRepository.GetAllLenders();
        }
    }
}
