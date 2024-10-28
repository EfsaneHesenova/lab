using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Models
{
    internal abstract class LibraryItem
    {
        public string Title {  get; set; }
        public DateTime? PublicationYear { get; set; }
        public abstract void DisplayInfo();

    }
}
