﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forest_bTP2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Book.aspx");
           
        }

        protected void addA(object sender, EventArgs e)
        {
            BuisnessManagement.Author.AddAuthors(new Dbo.Author("dede", "slt"));
            BuisnessManagement.Author.AddAuthors(new Dbo.Author("dada", "mana"));

        }
    }
}