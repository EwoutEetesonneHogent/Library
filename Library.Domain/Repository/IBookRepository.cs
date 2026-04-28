using Library.Domain.Models;

namespace Library.Domain.Repository {
    public interface IBookRepository {
        void CreateBook(string name, DateOnly publishDate, Author author) {

        }
    }

}
