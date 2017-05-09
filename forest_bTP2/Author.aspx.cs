using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forest_bTP2
{
    public partial class Author : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = BuisnessManagement.Author.ListAuthors();
            GridView1.DataBind();
        }
    }
}