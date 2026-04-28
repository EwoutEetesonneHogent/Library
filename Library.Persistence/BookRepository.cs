using Library.Domain.Repository;
using Microsoft.Data.SqlClient;

namespace Library.Persistence
{
    public class BookRepository : IBookRepository
	{
        public List<Book> GetBooksByAuthor(Author author) {
            using SqlConnection connection = new("Data Source=.;Initial Catalog=Library;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
            connection.Open();

            using SqlCommand command = new(@"SELECT * FROM Books WHERE AuthorId = @authorId", connection);
            command.Parameters.AddWithValue("@authorId", author.Id);
            using SqlDataReader reader = command.ExecuteReader();

            List<Book> output = [];

            if (reader.HasRows) {
                while (reader.Read()) {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    int publishDate = (int)reader["PublishDate"];

                    Book createdBook = new Book(id, name, publishDate, author);
                    output.Add(createdBook);
                }
            }
            return output;
        }
    }
}
