using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forest_bTP2.BuisnessManagement
{
    public class Book
    {
        public static List<Dbo.Book> ListBooks()
        {
            using (DataAccess.Book e = new DataAccess.Book())
            {
                e.Initializer();
                return e.ReadBooks();
            }
        }

        public static bool AddBook(Dbo.Book e)
        {
            using (DataAccess.Book a = new DataAccess.Book())
            {
                a.Initializer();
                return a.AddBook(e);
            }
        }
    }
}