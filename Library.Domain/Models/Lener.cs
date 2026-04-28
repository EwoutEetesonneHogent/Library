using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Library.Domain.Models
{
    public class Lener
    {
        private int _id;
        private string _name;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public Lener(int id, string name)
        {
            if (id <= 0)
                throw new ArgumentException("Id moet groter zijn dan 0.", nameof(id));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Naam mag niet leeg zijn.", nameof(name));

            _id = id;
            _name = name;
        }
    }
}
