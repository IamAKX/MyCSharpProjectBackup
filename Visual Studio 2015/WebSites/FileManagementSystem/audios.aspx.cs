using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class audios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Menu m = (Menu)this.Master.FindControl("Menu1");
        m.Items[0].Text = "Hello " + Session["current_user"].ToString() + "!!";
        // Table1.Controls.Clear();
        string s = Session["current_user"].ToString();
        string query = "select FileName,Path from " + s + " where Extension = 'audios'";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        conn.Open();
       
        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        DataSet container = new DataSet();
        adapter.Fill(container);
        GridView1.DataSource = container.Tables[0];
        GridView1.DataBind();

    }
}