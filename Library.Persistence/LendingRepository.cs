using Library.Domain.Repository;

namespace Library.Persistence
{
    public class LendingRepository : ILendingRepository
    {
        public List<Lenders> GetAllLenders()
        {
            using SqlConnection connection = new("Data Source=.;Initial Catalog=Library;Integrated Security=True;Trust Server Certificate=True");
            connection.Open();
            using SqlCommand command = new("SELECT * FROM Lenders", connection);
            List<Lenders> lenders = [];

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int LendersId = (int)reader["Id"];
                        string name = (string)reader["Name"];

                        Lenders lender = new(LendersId, name);
                        lenders.Add(lender);

                    }
                }
            }
            return lenders;
        }
    }
}
