using System;
using System.Collections.Generic;
using System.Linq;


namespace forest_bTP2.DataAccess
{
    public class Book : IDisposable
    {
        public DataAccess.IdotTP2Entities1 Context { get; set; }
        public void Dispose()
        {
            Context.Dispose();
        }

        public Book()
        {
        }

        public void Initializer()
        {
            Context = new IdotTP2Entities1();
        }

        public List<Dbo.Book> ReadBooks()
        {
            var a = new List<Dbo.Book>();
            try
            {
                var qerry = from tmp in Context.T_Book 
                             select tmp;
                qerry.ToList().ForEach(e => a.Add(new Dbo.Book(e.Id, e.Title, e.Publication, e.IdAuthor)));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return a;
        }

        public bool AddBook(Dbo.Book e)
        {
            try
            {
                var book = new T_Book()
                {
                    Id = e.Id,
                    IdAuthor = e.Idauthor,
                    Title = e.Title,
                    Publication = e.Publication
                };
                Context.T_Book.Add(book);
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