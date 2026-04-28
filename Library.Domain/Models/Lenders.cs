using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Library.Domain.Models
{
    public class Lenders
    {
        public int _id;
        private string _name;
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }



        public Lenders(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
