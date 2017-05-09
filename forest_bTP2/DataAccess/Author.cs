using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace forest_bTP2.DataAccess
{
    public class Author : IDisposable
    {
        public DataAccess.ModelTP Context { get; set; }
        public void Dispose()
        {
            Context.Dispose();
        }
        public void Initializer()
        {
            Context = new ModelTP();
        }
        public Author()
        {
        }

        public List<Dbo.Author> ListAuthors()
        {
            var a = new List<Dbo.Author>();
            var qerry = from tmp in Context.T_Author
                select tmp;
            qerry.ToList().ForEach(e => a.Add(new Dbo.Author(e.Name, e.Firstname)));
            return a;
        }

        public bool Add(Dbo.Author e)
        {
            try
            {
                var t = new T_Author
                {
                    Firstname = e.Firstname,
                    Name = e.Name
                };
                Context.T_Author.Add(t);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}