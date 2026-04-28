using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Library.Persistence.Models {
    internal class Book {
        private string _title;
        private int _publicationYear;
        private Author _author;

        public string Title { get => _title; set => _title = value; }

        public int PublicationYear => _publicationYear;

        public Author Author { get => _author; set => _author = value; }
    }
}
