using Library.Domain.Models;

namespace Library.Domain.Repository
{
    public interface ILendingRepository
    {
        List<Lenders> GetAllLenders();
        void AddLender(Lenders lender);
    }
}
