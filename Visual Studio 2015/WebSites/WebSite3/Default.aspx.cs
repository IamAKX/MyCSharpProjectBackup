﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void NextView(object sender, CommandEventArgs e)
    {

    }
    protected void View4_Activate(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Text = TextBox1.Text;
        Label2.Text = TextBox2.Text;
        Label3.Text = TextBox3.Text;
    }
}