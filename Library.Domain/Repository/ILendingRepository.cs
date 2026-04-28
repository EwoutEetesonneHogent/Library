using Library.Domain.Model;

namespace Library.Domain.Repository
{
    public interface ILendingRepository
    {
        List<Lenders> GetAllLenders();
    }
}
