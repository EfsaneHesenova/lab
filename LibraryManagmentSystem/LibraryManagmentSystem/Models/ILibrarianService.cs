using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Models
{
    internal interface ILibrarianService
    {
        public Librarian GetLibrarianById(int id);
        public Librarian GetAllLibrarians();
        public void CreateLibrarian(Librarian librarian);
    }
}
