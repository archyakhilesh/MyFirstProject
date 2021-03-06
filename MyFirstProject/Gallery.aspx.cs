﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstProject
{
    public partial class Gallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Mobile");
            table.Columns.Add("Email ID");
            table.Columns.Add("D.O.B");

            string name = (string)Session["name"];
            string email = (string)Session["email"];
            string mobile = (string)Session["mobile"];
            string dob = (string)Session["dob"];

            table.Rows.Add(name, mobile, email, dob);
            table.Rows.Add("Ritvick","8594668945","rsingh@talentquest.com","1994-07-15");
            table.Rows.Add("Manisha", "7036458549", "mshukla@talentquest.com","1996-04-21");
            table.Rows.Add("Ritvick", "7564668945", "dpodder@talentquest.com","1995-09-02");
            grdViewTable.DataSource = table;
            grdViewTable.DataBind();
        }

        
    }
}