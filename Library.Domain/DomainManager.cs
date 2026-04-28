using Library.Domain.Models;
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

        public void AddLenders(Lenders lender)
        {
            _lendingRepository.AddLender(lender);
        }
    }
}
