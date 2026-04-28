using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Library.Persistence.Models {
    internal class Book {
        private int _id;
        private string _title;
        private int _publicationYear;
        private Author _author;

        public int Id { get => _id; set => _id = value; }

        public string Title { get => _title; set => _title = value; }

        public int PublicationYear => _publicationYear;

        public Author Author { get => _author; set => _author = value; }
    }
}
