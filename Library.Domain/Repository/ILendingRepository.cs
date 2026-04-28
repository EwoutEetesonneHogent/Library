namespace Library.Domain.Repository
{
    public interface ILendingRepository
    {
        bool ExtendLendingDueDate(int lendingId);
    }
}
