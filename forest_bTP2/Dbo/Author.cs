using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forest_bTP2.Dbo
{
    public class Author
    {
        public Author(long id, string name, string firstname)
        {
            this.id = id;
            Name = name;
            Firstname = firstname;

        }

        public long id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}