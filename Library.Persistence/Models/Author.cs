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
            _id = id;
            _name = name;
        }
    }
}
