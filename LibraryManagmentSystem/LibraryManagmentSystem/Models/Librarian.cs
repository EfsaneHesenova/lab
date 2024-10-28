using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Models
{
    internal class Librarian : Person
    {
        
        private static int _id = 0;
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public  DateTime HareDate { get; set; }
        public Librarian(string name, DateTime hareDate) : base(name)
        {
            Name = name;
            HareDate = hareDate;
            Id = _id++;
        }
    }
}
