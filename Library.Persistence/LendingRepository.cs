using Library.Domain.Model;
using Library.Domain.Repository;
using Microsoft.Data.SqlClient;

namespace Library.Persistence
{
    public class LendingRepository : ILendingRepository
    {
        public List<Lenders> GetAllLenders()
        {
            using SqlConnection connection = new("Data Source=.;Initial Catalog=Library;Integrated Security=True;Trust Server Certificate=True");

            using SqlCommand command = new("SELECT * Lenders", connection);
            List<Lenders> lenders = [];

            return lenders;

        }
    }
}
