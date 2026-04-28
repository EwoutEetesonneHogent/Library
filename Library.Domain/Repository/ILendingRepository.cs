using Library.Domain.Models;

namespace Library.Domain.Repository
{
    public interface ILendingRepository
    {
        List<Lender> GetAllLenders();
        void AddLender(Lender lender);
    }
}
