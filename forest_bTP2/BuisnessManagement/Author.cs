using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forest_bTP2.BuisnessManagement
{
    public class Author
    {
        public static List<Dbo.Author> ListAuthors()
        {
            using (DataAccess.Author e = new DataAccess.Author())
            {
                e.Initializer();
                return e.ListAuthors();
            }
        }

        public static bool AddAuthors(Dbo.Author e)
        {
            using (DataAccess.Author a = new DataAccess.Author())
            {
                a.Initializer();
                return a.Add(e);
            }
        }
    }
}