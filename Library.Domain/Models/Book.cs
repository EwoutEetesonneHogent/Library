using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Library.Domain.Models {
    public class Book {
        private int _id;
        private string _title;
        private DateOnly _publicationYear;
        private Author _author;

        public Book(int id, string title, DateOnly publicationYear, Author author) {
            Id = id;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public int Id {
            get => _id;
            set {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
                _id = value;
            }
        }

        public string Title { get => _title; set => _title = value; }

        public DateOnly PublicationYear { get => _publicationYear; set => _publicationYear = value; }

        public Author Author { get => _author; set => _author = value; }
    }
}