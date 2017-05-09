using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using forest_bTP2.DataAccess;
using Microsoft.Ajax.Utilities;

namespace forest_bTP2.Dbo
{
    public class Author
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public long id { get; set; }
        public Author(string name, string firstname)
        {
            this.Name = name;
            this.Firstname = firstname;

        }

        public Author(string name, string firstname, long id)
        {
            Name = name;
            Firstname = firstname;
            this.id = id;
        }
    }
}