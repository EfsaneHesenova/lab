using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Models
{
    internal class Book : LibraryItem
    {
        public string Genre { get; set; }
        public string LibraryLocation { get; set; }

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
