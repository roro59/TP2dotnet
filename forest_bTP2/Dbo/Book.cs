using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forest_bTP2.Dbo
{
    public class Book
    {
        public Book(long id, string title, DateTime? publication, long idauthor)
        {
            Id = id;
            Title = title;
            Publication = publication;
            Idauthor = idauthor;
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime? Publication { get; set; }
        public long Idauthor { get; set; }
        
    }
}