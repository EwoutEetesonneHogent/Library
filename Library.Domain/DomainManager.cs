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

        public bool ExtendLendingDueDate(int lendingId)
        {
            return _lendingRepository.ExtendLendingDueDate(lendingId);
        }
    }
}
