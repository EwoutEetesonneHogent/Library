using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Persistence.Models
{
    internal class Author
    {
        private int _id;

        private string _name;

        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get =>  _id;  set => _id = value; }

        public string Name { get => _name; set => _name = value; }

    }
}
