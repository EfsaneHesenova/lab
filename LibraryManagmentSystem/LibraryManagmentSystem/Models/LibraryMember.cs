using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Models
{
    public sealed class LibraryMember : Person
    {
        

        public DateTime MemberShipDate { get; set; }
        private static int _id = 0;
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public LibraryMember(string name, DateTime memberShipDate) : base(name)
        {
            Name = name;
            MemberShipDate = memberShipDate;
        }
    }
}
