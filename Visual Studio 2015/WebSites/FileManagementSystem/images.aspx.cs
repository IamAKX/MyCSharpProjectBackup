﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class images : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Menu m = (Menu)this.Master.FindControl("Menu1");
        m.Items[0].Text = "Hello " + Session["current_user"].ToString() + "!!";
        //Table1.Controls.Clear();
        string s = Session["current_user"].ToString();
        string query = "select FileName,Path from " + s + " where Extension = 'images'";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
        /*    SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();


              while (reader.Read())
              {
                  TableRow tr = new TableRow();
                  Table1.Controls.Add(tr);
                  for (int i = 0; i < 3; i++)
                  {
                      TableCell c = new TableCell();
                      Label l = new Label();
                      if (i < 2)
                          l.Text = reader.GetValue(i).ToString();
                      else
                          l.Text = "delete";
                      c.Controls.Add(l);
                      tr.Controls.Add(c);
                  }
              }*/
        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        DataSet container = new DataSet();
        adapter.Fill(container);
        GridView1.DataSource = container.Tables[0];
        GridView1.DataBind();
    }
}