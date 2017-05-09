using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forest_bTP2
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add(object sender, EventArgs eventArgs)
        {
            var listAuthors = BuisnessManagement.Author.ListAuthors();
            Dbo.Author a = listAuthors[0];
            foreach (Dbo.Author t in listAuthors)
            {
                if (t.Name == TextBox2.Text)
                    a = t;
            }
            var book = new Dbo.Book(0, TextBox1.Text, Calendar1.SelectedDate, a.id);
            BuisnessManagement.Book.AddBook(book);
        }
    }
}