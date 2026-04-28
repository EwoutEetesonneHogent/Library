namespace Library.Domain.Models
{
    public class Book
    {
        private int _id;
        private string _title;
        private int _publicationYear;
        private Author _author;

        public Book(int id, string title, int publicationYear, Author author)
        {
            Id = id;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public int Id { get => _id; set => _id = value; }

        public string Title { get => _title; set => _title = value; }

        public int PublicationYear { get => _publicationYear; set => _publicationYear = value; }

        public Author Author { get => _author; set => _author = value; }
    }
}