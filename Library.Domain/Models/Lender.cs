using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Library.Domain.Models
{
    public class Lender
    {
        public int _id;
        private string _name;
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }



        public Lender(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
